using BusinessLayer.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public IResult Add(Reservation entity)
        {
            _reservationDal.Add(entity);
            return new SuccessResult("Rezervasyon Yapıldı");
        }

        public IResult Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ReservationDetailsDto>> reservationDetailsDtos(int id)
        {
            return new SuccessDataResult<List<ReservationDetailsDto>>(_reservationDal.reservationDetailsDtos(x => x.AppUserID == id && x.Status == "onay bekliyor"));
        }

        public IDataResult<Reservation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Reservation>> GetAll(Expression<Func<Reservation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public IResult Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
        public IDataResult<List<Reservation>> GetListWithReservationByWaitApproval(int id)
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetListWithReservationByWaitApproval(id));
        }

        public IDataResult<List<Reservation>> GetListWithReservationByAccepted(int id)
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetListWithReservationByAccepted(id));
        }

        public IDataResult<List<Reservation>> GetListWithReservationByPrevious(int id)
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetListWithReservationByPrevious(id));
        }
    }
}
