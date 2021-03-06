﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Mail.Configuration;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Mail
{
    /// <summary>
    /// Represents the mail provider that sends emails using local Microsoft IIS.
    /// </summary>
    public class DaIisMailProvider : DaMailProviderBase
    {
        /// <summary>
        /// Creates an instance of the <see cref="DaIisMailProvider"/> class.
        /// </summary>
        public DaIisMailProvider() : base()
        { }

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="message">The mail message object.</param>
        public override void Send(MailMessage mail)
        {
            var smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
            smtpClient.Send(mail);
        }

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="to">The recipient of the mail.</param>
        /// <param name="from">The sender of the mail.</param>
        /// <param name="subject">The subject of the mail</param>
        /// <param name="body">The body of the mail message.</param>
        public override void Send(string to, string from, string subject, string body)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(from),
                Subject = subject,
                Body = body
            };

            Send(message);
        }

        /// <summary>
        /// Asynchronously sends a mail.
        /// </summary>
        /// <param name="message">The mail message object.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public override Task SendAsync(MailMessage message)
        {
            if(message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            if(message.To == null)
            {
                throw new InvalidOperationException("Must have the email address to whom the email needs to be sent.");
            }

            if (message.From == null)
            {
                var config = DaMailConfigurationManager.GetConfiguration();
                message.From = new MailAddress(config.DefaultSenderEmail);
            }

            var smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
            return smtpClient.SendMailAsync(message);
        }

        /// <summary>
        /// Asynchronously sends a mail.
        /// </summary>
        /// <param name="to">The recipient of the mail.</param>
        /// <param name="from">The sender of the mail.</param>
        /// <param name="subject">The subject of the mail</param>
        /// <param name="body">The body of the mail message.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public override Task SendAsync(string to, string from, string subject, string body)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(from),
                Subject = subject,
                Body = body
            };

            return SendAsync(message);
        }
    }
}
