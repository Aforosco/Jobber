using System;
namespace Joberguy.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
        Task SendJobApplicationEmailsAsync(string applicantEmail, string applicantName, string jobTitle);
    }
}

