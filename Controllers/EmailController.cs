using EmailAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController
    {
        private static List<Email> emails = new List<Email>();

        [HttpPost]
        public void AddEmail([FromBody] Email email)
        {
            emails.Add(email);
            Console.WriteLine(email.To + " recebemos - "+  email.Message);
        }

        [HttpGet]
        public void GetEmails()
        {
            Console.WriteLine( " recebemos - ");
        }

    }
}