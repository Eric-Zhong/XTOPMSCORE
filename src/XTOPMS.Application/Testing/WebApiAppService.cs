//
//  WebApiAppService.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
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
using Abp.Application.Services;
using Abp.Authorization;
using Abp.BackgroundJobs;
using Abp.MailKit;
using Abp.Net.Mail.Smtp;
using MailKit.Net.Smtp;
using MimeKit;
using XTOPMS.Authorization;
using XTOPMS.Email;

namespace XTOPMS.Testing
{
    public interface IWebApiAppService : IApplicationService
    {
        int Add(int a, int b);
        bool SendEmail();
        bool SendEmail2();
        bool SendEmail3();
    }

    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class WebApiAppService: XTOPMSAppServiceBase, IWebApiAppService
    {
        ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration;
        IAbpMailKitConfiguration abpMailKitConfiguration;
        IEmailManager emailManager;
        IBackgroundJobManager backgroundJobManager;

        public WebApiAppService(
            ISmtpEmailSenderConfiguration _smtpEmailSenderConfiguration,
            IAbpMailKitConfiguration _abpMailKitConfiguration,
            IEmailManager _emailManager,
            IBackgroundJobManager _backgroundJobManage
            )
        {
            smtpEmailSenderConfiguration = _smtpEmailSenderConfiguration;
            abpMailKitConfiguration = _abpMailKitConfiguration;
            emailManager = _emailManager;
            backgroundJobManager = _backgroundJobManage;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool SendEmail()
        {
            //emailManager.SendMailToAdmin("title", "Hello");
            //return true;

            var emailSender = new SmtpEmailSender(
                smtpEmailSenderConfiguration);
            string body = "<h1>This is HTML</h1>";
            emailSender.Send("zhong.xu@biztalkgroup.com", "xu.zhong@hotmail.com", "This is a test", body, true);
            return true;
        }

        public bool SendEmail2()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey Tribbiani", "zhong.xu@biztalkgroup.com"));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "zhong.xu@biztalkgroup.com"));
            message.Subject = "星期天去哪里玩？";
            message.Body = new TextPart("plain") { Text = "我想去故宫玩，如何" };
            try
            {
                using (var client = new SmtpClient())
                {
                    client.CheckCertificateRevocation = false;
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) =>
                    {
                        Console.WriteLine("SMTP server ssl callback.");
                        return true;
                    };
                    client.Connect("smtp.exmail.qq.com", 465, true);
                    // Note: since we don't have an OAuth2 token, disable
                    // the XOAUTH2 authentication mechanism.
                    // client.AuthenticationMechanisms.Remove("XOAUTH2");
                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("zhong.xu@biztalkgroup.com", "w3vjyCuxmA4i4GS8");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch(Exception eee)
            {
                Console.WriteLine(eee.ToString());

            }
            return true;
        }

        public bool SendEmail3()
        {
            EmailTask task = new EmailTask();

            task.Subject = "Test";
            task.Body = "Body";
            task.To.Add(new Users.Dto.UserDto()
            {
                FullName = "Eric Xu",
                EmailAddress = "zhong.xu@biztalkgroup.com"
            });

            backgroundJobManager.Enqueue<EmailSenderJob, EmailTask>(task);

            return true;
        }
    }
}
