using EntityLayer.Dtos;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(MailRequestDto mailRequestDto)
        {

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "fenerli2142@gmail.com");
            mimeMessage.From.Add(mailboxAddress);//sender


            MailboxAddress mailboxAddress1 = new MailboxAddress("user", mailRequestDto.RecieverMail);//reciever
            mimeMessage.To.Add(mailboxAddress1);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequestDto.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();


            mimeMessage.Subject = mailRequestDto.Subject;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("fenerli2142@gmail.com", "zwdogbywdwbnbwqv");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }




        public IActionResult Compose()
        {
            return View();
        }
    }
}
