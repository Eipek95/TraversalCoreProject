using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestmonialService
    {
        ITestmonialDal _testmonialDal;

        public TestimonialManager(ITestmonialDal testmonialDal)
        {
            _testmonialDal = testmonialDal;
        }

        public IResult Add(Testmonial entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Testmonial entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Testmonial> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Testmonial>> GetAll(Expression<Func<Testmonial, bool>> filter = null)
        {
            if (DateTime.Now.Year == 2025)
            {
                return new ErrorDataResult<List<Testmonial>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Testmonial>>(_testmonialDal.GetAll(), "Listelendi");
        }

        public IResult Update(Testmonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
