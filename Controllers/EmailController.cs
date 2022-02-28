using EmailAPI.Models;
using EmailAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController :ControllerBase
    { 
        private readonly IMailService mailService;

        public EmailController(IMailService mailService)

        {
            this.mailService = mailService; 
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }catch (Exception ex)
            {
                throw;
            }
        }
 

    }
}