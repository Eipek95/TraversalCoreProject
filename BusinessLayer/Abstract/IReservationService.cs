using Core.Utilities.Results.DataInResult;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        IDataResult<List<Reservation>> GetListWithReservationByWaitApproval(int id);
        IDataResult<List<Reservation>> GetListWithReservationByAccepted(int id);
        IDataResult<List<Reservation>> GetListWithReservationByPrevious(int id);
        IDataResult<List<ReservationDetailsDto>> reservationDetailsDtos(int id);
    }
}
