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
            throw new NotImplementedException();
        }

        public IResult Delete(Destination entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
