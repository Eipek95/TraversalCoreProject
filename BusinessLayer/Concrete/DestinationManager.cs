using BusinessLayer.Abstract;
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

        public void Add(Destination entity)
        {
            _destinationDal.Add(entity);
        }

        public void Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public Destination Get(int id)
        {
            return _destinationDal.Get(x => x.DestinationID == id);
        }

        public List<Destination> GetAll(Expression<Func<Destination, bool>> filter = null)
        {
            return _destinationDal.GetAll();
        }

        public void Update(Destination entity)
        {
            _destinationDal.Update(entity);
        }
    }
}
