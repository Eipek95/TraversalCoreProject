using Core;

namespace EntityLayer.Dtos
{
    public class MailRequestDto : IDto
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string RecieverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
