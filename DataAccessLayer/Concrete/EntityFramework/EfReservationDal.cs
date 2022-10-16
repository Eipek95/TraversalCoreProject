using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfReservationDal : EfEntityRepositoryBase<Reservation, Context>, IReservationDal
    {
        public List<ReservationDetailsDto> reservationDetailsDtos(Expression<Func<ReservationDetailsDto, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from r in context.Reservations
                             join d in context.Destinations
                             on r.DestinationID equals d.DestinationID
                             select new ReservationDetailsDto
                             {
                                 id = r.ReservationID,
                                 AppUserID = r.AppUserID,
                                 PersonCount = Convert.ToInt16(r.PersonCount),
                                 ReservationDate = r.ReservationDate,
                                 Status = r.Status,
                                 Destination = new Destination()
                                 {
                                     City = d.City
                                 }
                             };
                return filter == null
                   ? result.ToList()
                   : result.Where(filter).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include
                    (x => x.Destination)
                    .Where(
                    x => x.Status == "onay bekliyor" &&
                    x.AppUserID == id)
                    .ToList();
            }
        }
    }
}
