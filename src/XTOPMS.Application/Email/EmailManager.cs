//
//  EmailManager.cs
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
using Abp.BackgroundJobs;
using Abp.Domain.Services;
using Abp.Net.Mail.Smtp;
using MailKit.Net.Smtp;
using MimeKit;
using XTOPMS.Users.Dto;

namespace XTOPMS.Email
{
    public interface IEmailManager
        : IDomainService
    {
        void SendMail(EmailTask mail);
        void SendMail(string to, string subject, string body, bool isBodyHtml);
        void SendMail(string from, List<string> to, string subject, string body, bool isBodyHtml);
        void SendMail(UserDto from, List<UserDto> to, string subject, string body, bool isBodyHtml);
        void SendMail(List<UserDto> to, string subject, string body, bool isBodyHtml);
        void SendMail(string subject, string body, bool isBodyHtml);
        void SendMail<TModel>(UserDto from, List<UserDto> to, long templateId, TModel model);
    }

    public class EmailManager
        : DomainService
        , IEmailManager
    {
        ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration;
        IBackgroundJobManager backgroundJobManager;

        public EmailManager(
            ISmtpEmailSenderConfiguration _smtpEmailSenderConfiguration,
            IBackgroundJobManager _backgroundJobManager
            )
        {
            smtpEmailSenderConfiguration = _smtpEmailSenderConfiguration;
            backgroundJobManager = _backgroundJobManager;
        }

        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="subject">Subject.</param>
        /// <param name="body">Body.</param>
        /// <param name="isBodyHtml">If set to <c>true</c> is body html.</param>
        public void SendMail(string from, List<string> to, string subject, string body, bool isBodyHtml)
        {
            UserDto mailFrom = new UserDto { EmailAddress = from };
            List<UserDto> mailTo = new List<UserDto>();
            foreach (var address in to)
            {
                UserDto u = new UserDto { EmailAddress = address };
                mailTo.Add(u);
            }
            SendMail(mailFrom, mailTo, subject, body, isBodyHtml);
        }

        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="mail">Mail.</param>
        public void SendMail(EmailTask mail)
        {
            backgroundJobManager.Enqueue<EmailSenderJob, EmailTask>(mail);
        }

        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="subject">Subject.</param>
        /// <param name="body">Body.</param>
        /// <param name="isBodyHtml">If set to <c>true</c> is body html.</param>
        public void SendMail(UserDto from, List<UserDto> to, string subject, string body, bool isBodyHtml)
        {
            EmailTask mail = new EmailTask();

            mail.From.EmailAddress = from.EmailAddress;
            mail.To.AddRange(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = isBodyHtml;

            SendMail(mail);
        }

        public void SendMail(string to, string subject, string body, bool isBodyHtml)
        {
            string from = smtpEmailSenderConfiguration.DefaultFromAddress;
            List<string> mailTo = new List<string>();
            mailTo.Add(to);
            SendMail(from, mailTo, subject, body, isBodyHtml);
        }



        /// <summary>
        /// Sends the mail by template.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="templateId">Template identifier.</param>
        /// <param name="model">Model.</param>
        /// <typeparam name="TModel">The 1st type parameter.</typeparam>
        public void SendMail<TModel>(UserDto from, List<UserDto> to, long templateId, TModel model)
        {
            EmailTask mail = new EmailTask();
            mail.From = from;
            mail.To.AddRange(to);

            // TODO: need to realize mail template engin.

            // Get mail template from database.

            // Transform subject

            // Transform body

            throw new NotImplementedException();
        }

        public void SendMail(List<UserDto> to, string subject, string body, bool isBodyHtml)
        {
            UserDto mailFrom = new UserDto
            {
                EmailAddress = smtpEmailSenderConfiguration.DefaultFromAddress,
                FullName = smtpEmailSenderConfiguration.DefaultFromDisplayName
            };

            EmailTask mail = new EmailTask();

            mail.From = mailFrom;
            mail.To.AddRange(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = isBodyHtml;

            SendMail(mail);
        }

        public void SendMail(string subject, string body, bool isBodyHtml)
        {
            UserDto defaultUser = new UserDto
            {
                EmailAddress = smtpEmailSenderConfiguration.DefaultFromAddress,
                FullName = smtpEmailSenderConfiguration.DefaultFromDisplayName
            };

            List<UserDto> mailTo = new List<UserDto>();
            mailTo.Add(defaultUser);

            SendMail(mailTo, subject, body, isBodyHtml);
        }
    }
}
