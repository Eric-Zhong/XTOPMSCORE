//
//  XTOPMSMailKitSmtpBuilder.cs
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
using Abp.MailKit;
using Abp.Net.Mail.Smtp;
using MailKit.Net.Smtp;

namespace XTOPMS.Email
{
    public class XTOPMSMailKitSmtpBuilder 
        : DefaultMailKitSmtpBuilder, IMailKitSmtpBuilder
    {
        public XTOPMSMailKitSmtpBuilder(
            ISmtpEmailSenderConfiguration smtpEmailSenderConfiguration, 
            IAbpMailKitConfiguration abpMailKitConfiguration
            ) : base(smtpEmailSenderConfiguration, abpMailKitConfiguration)
        {
        }


        protected override void ConfigureClient(SmtpClient client)
        {
            client.CheckCertificateRevocation = false;
            client.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            // Note: since we don't have an OAuth2 token, disable
            // the XOAUTH2 authentication mechanism.
            // client.AuthenticationMechanisms.Remove("XOAUTH2");
            // Note: only needed if the SMTP server requires authentication

            base.ConfigureClient(client);
        }

        /*
        protected virtual void ConfigureClient(SmtpClient client)
        {
            client.Connect(
                _smtpEmailSenderConfiguration.Host,
                _smtpEmailSenderConfiguration.Port,
                GetSecureSocketOption()
            );

            if (_smtpEmailSenderConfiguration.UseDefaultCredentials)
            {
                return;
            }

            client.Authenticate(
                _smtpEmailSenderConfiguration.UserName,
                _smtpEmailSenderConfiguration.Password
            );
        }
        */
    }
}
