using Core;

namespace EntityLayer.Dtos
{
    public class CityDto : IDto
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
    }
}
