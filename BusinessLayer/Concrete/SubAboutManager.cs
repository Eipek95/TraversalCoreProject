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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public IResult Add(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SubAbout> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SubAbout>> GetAll(Expression<Func<SubAbout, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
