using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IEntityRepository<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        List<ReservationDetailsDto> reservationDetailsDtos(Expression<Func<ReservationDetailsDto, bool>> filter = null);
    }
}
