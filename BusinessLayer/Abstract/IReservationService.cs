using Core.Utilities.Results.DataInResult;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        IDataResult<List<Reservation>> GetListApprovalReservation(int userId, string statusApproval);

        IDataResult<List<Reservation>> GetListWithReservationByWaitApproval(int id);

        IDataResult<List<ReservationDetailsDto>> reservationDetailsDtos(int id);
    }
}
