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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(About entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<About> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<About>> GetAll(Expression<Func<About, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
