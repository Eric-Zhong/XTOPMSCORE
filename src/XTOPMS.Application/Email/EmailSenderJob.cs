//
//  EmailSenderJob.cs
//
//  Author:
//       Eric-Zhong Xu <zhong.xu@biztalkgroup.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.IO;
using Abp.BackgroundJobs;
using Abp.MailKit;
using Abp.Net.Mail.Smtp;
using MailKit.Net.Smtp;
using MimeKit;

namespace XTOPMS.Email
{

    // TODO: 后期需要研究模板引擎 http://antaris.github.io/RazorEngine/

    public class EmailSenderJob
            : BackgroundJob<EmailTask>
    {
        ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration;
        IAbpMailKitConfiguration abpMailKitConfiguration;

        public EmailSenderJob(ISmtpEmailSenderConfiguration _smtpEmailSenderConfiguration,
                              IAbpMailKitConfiguration _abpMailKitConfiguration)
        {
            smtpEmailSenderConfiguration = _smtpEmailSenderConfiguration;
            abpMailKitConfiguration = _abpMailKitConfiguration;
        }

        public override void Execute(EmailTask args)
        {
            var from = this.GetFrom(args);
            var to = this.GetTo(args);
            var cc = this.GetCc(args);
            var attachments = this.GetAttachments(args);

            var message = new MimeMessage();
            message.From.Add(from);
            message.To.AddRange(to);
            if (cc != null)
            {
                message.Cc.AddRange(cc);
            }

            message.Subject = args.Subject;

            var builder = new BodyBuilder();

            if (args.IsBodyHtml)
            {
                builder.HtmlBody = args.Body;
            }
            else
            {
                builder.TextBody = args.Body;
            }

            if(attachments != null)
            {
                foreach(var att in attachments)
                {
                    builder.Attachments.Add(att);
                }
            }

            message.Body = builder.ToMessageBody();
            try
            {
                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) =>
                    {
                        Console.WriteLine("Email server SSL callback.");
                        return true;
                    };

                    // Connect model
                    client.Connect(
                        this.smtpEmailSenderConfiguration.Host,
                        this.smtpEmailSenderConfiguration.Port,
                        this.smtpEmailSenderConfiguration.EnableSsl);

                    // Connect authorization
                    client.Authenticate(
                        this.smtpEmailSenderConfiguration.UserName,
                        this.smtpEmailSenderConfiguration.Password);

                    client.Send(message);

                    client.Disconnect(true);
                }
            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.ToString());
                throw eee;
            }
        }

        protected MailboxAddress GetFrom(EmailTask mail)
        {
            if (
                mail != null &&
                mail.From != null &&
                !string.IsNullOrEmpty(mail.From.EmailAddress)
                )
            {
                var address = mail.From.EmailAddress;
                var name = mail.From.FullName;

                return new MailboxAddress(name, address);
            }
            else
            {
                string defaultAddress = smtpEmailSenderConfiguration.DefaultFromAddress;
                string defaultDisplayName = smtpEmailSenderConfiguration.DefaultFromDisplayName;

                return new MailboxAddress(defaultDisplayName, defaultAddress);
            }
        }

        protected List<MailboxAddress> GetTo(EmailTask mail)
        {
            if (
                mail != null &&
                mail.To != null &&
                mail.To.Count > 0
                )
            {
                List<MailboxAddress> to = new List<MailboxAddress>();
                foreach (var item in mail.To)
                {
                    if (!string.IsNullOrEmpty(item.EmailAddress))
                    {
                        to.Add(new MailboxAddress(item.FullName, item.EmailAddress));
                    }
                }
                return to;
            }
            else
            {
                throw new ArgumentNullException("EmailTask.To");
            }
        }

        protected List<MailboxAddress> GetCc(EmailTask mail)
        {
            if (
                mail != null &&
                mail.Cc != null &&
                mail.Cc.Count > 0
                )
            {
                List<MailboxAddress> cc = new List<MailboxAddress>();
                foreach (var item in mail.Cc)
                {
                    if (!string.IsNullOrEmpty(item.EmailAddress))
                    {
                        cc.Add(new MailboxAddress(item.FullName, item.EmailAddress));
                    }
                }
                return cc;
            }
            else
            {
                return null;
            }
        }


        // KB: https://www.cnblogs.com/pengze0902/p/6562447.html
        // KB: https://blog.csdn.net/starfd/article/details/80706227

        protected List<MimePart> GetAttachments(EmailTask mail)
        {
            if (
                mail != null &&
                mail.Attachments != null &&
                mail.Attachments.Count > 0
                )
            {
                List<MimePart> parts = new List<MimePart>();

                foreach (var doc in mail.Attachments)
                {
                    // If file is existed then add it.
                    if (File.Exists(doc.FilePath))
                    {
                        var attachment = new MimePart(doc.ContentType)
                        {
                            Content = new MimeContent(File.OpenRead(doc.FilePath)),
                            ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                            ContentTransferEncoding = ContentEncoding.Base64,   // ContentEncoding.Default
                            FileName = doc.FileName
                        };
                        parts.Add(attachment);
                    }
                }

                if (parts.Count > 0)
                {
                    return parts;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
    }
}
