using System.ComponentModel.DataAnnotations;

namespace DTOLayer.DTOs.AnnouncementDTOs
{
    public class AnnouncementAddDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
