using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Joberguy.Service
{
   
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            string? smtpServer = _config["EmailSettings:SmtpServer"];
            string? smtpPortStr = _config["EmailSettings:SmtpPort"];
            string? smtpUser = _config["EmailSettings:SmtpUser"];
            string? smtpPass = _config["EmailSettings:SmtpPass"];
            string? fromEmail = _config["EmailSettings:FromEmail"];

            // Ensure required config values are not null
            if (string.IsNullOrWhiteSpace(smtpServer) ||
                string.IsNullOrWhiteSpace(smtpPortStr) ||
                string.IsNullOrWhiteSpace(smtpUser) ||
                string.IsNullOrWhiteSpace(smtpPass) ||
                string.IsNullOrWhiteSpace(fromEmail))
            {
                throw new InvalidOperationException("One or more email settings are missing in configuration.");
            }

            int smtpPort;
            if (!int.TryParse(smtpPortStr, out smtpPort))
            {
                throw new InvalidOperationException("Invalid SMTP port number in configuration.");
            }

            var message = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(toEmail));

            using (var smtp = new SmtpClient(smtpServer, smtpPort))
            {
                smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }

        public async Task SendJobApplicationEmailsAsync(string applicantEmail, string applicantName, string jobTitle)
        {
            string? adminEmail = _config["EmailSettings:AdminEmail"];
            if (string.IsNullOrWhiteSpace(adminEmail))
            {

                throw new InvalidOperationException("Enter Admin Email in Appsetting");
            }

            // ✅ Email to Applicant
            string applicantSubject = "Job Application Received";
            string applicantBody = $@"
            <h3>Hello {applicantName},</h3>
            <p>Your application for <strong>{jobTitle}</strong> has been received.</p>
            <p>We will review your application and get back to you soon.</p>
            <p>Best regards,<br>Job Application Team</p>";

            await SendEmailAsync(applicantEmail, applicantSubject, applicantBody);

            // ✅ Email to Admin
            string adminSubject = "New Job Application Submitted";
            string adminBody = $@"
            <h3>New Job Application Submitted</h3>
            <p><strong>Applicant Name:</strong> {applicantName}</p>
            <p><strong>Applied for:</strong> {jobTitle}</p>
            <p>Please review the application in the system.</p>";

            await SendEmailAsync(adminEmail, adminSubject, adminBody);
        }
    }

}

