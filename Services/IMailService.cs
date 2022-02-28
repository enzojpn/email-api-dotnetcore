using EmailAPI.Models;

namespace EmailAPI.Services
{
    public interface IMailService
    {
      Task SendEmailAsync(MailRequest mailRequest)  ;
    } 
}