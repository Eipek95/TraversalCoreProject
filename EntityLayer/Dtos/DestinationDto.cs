using Core;

namespace EntityLayer.Dtos
{
    public class DestinationDto : IDto
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
