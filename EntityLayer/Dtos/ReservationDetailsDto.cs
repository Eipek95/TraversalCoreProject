using Core;
using EntityLayer.Concrete;
using System;

namespace EntityLayer.Dtos
{
    public class ReservationDetailsDto : IDto
    {
        public int id { get; set; }
        public int AppUserID { get; set; }
        public int PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public Destination Destination { get; set; }
        public string Status { get; set; }
    }
}
