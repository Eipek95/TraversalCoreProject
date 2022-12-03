using System;

namespace DTOLayer.DTOs.AnnouncementDTOs
{
    public class AnnoucementUpdateDto
    {
        public int AmouncementID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
