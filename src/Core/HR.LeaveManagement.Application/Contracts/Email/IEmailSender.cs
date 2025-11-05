using HR.LeaveManagement.Application.Models.Email;

namespace HR.LeaveManagement.Application.Contracts.Persistence.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage mail);
}