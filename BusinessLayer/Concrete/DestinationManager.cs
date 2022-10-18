using BusinessLayer.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public IResult Add(Destination entity)
        {
            _destinationDal.Add(entity);
            return new Result(true, "Rota Başarıyla Eklendi");
        }

        public IResult Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
            return new Result(true, "Rota Başarıyla Silindi");

        }

        public IDataResult<Destination> Get(int id)
        {
            return new SuccessDataResult<Destination>(_destinationDal.Get(x => x.DestinationID == id));
        }

        public IDataResult<List<Destination>> GetAll(Expression<Func<Destination, bool>> filter = null)
        {
            return new SuccessDataResult<List<Destination>>(_destinationDal.GetAll());
        }

        public IResult Update(Destination entity)
        {
            _destinationDal.Update(entity);
            return new Result(true, "Rota Başarıyla Güncellendi");
        }
    }
}
