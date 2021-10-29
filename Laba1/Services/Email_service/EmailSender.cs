﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Services.Email_service
{
    public class EmailSender:IEmailSender
    {
        public async Task SendMessage(string emailTo, string messageBody, string messageSubject)
        {
            var apiKey = Environment.GetEnvironmentVariable("SendGrid");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("lera.poltavska@gmail.com", "Valeria");
            var subject = messageSubject;
            var to = new EmailAddress(emailTo, "Name");
            var plainTextContent = $"Email-розсилка";
            var htmlContent = $"{messageBody} With love";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
