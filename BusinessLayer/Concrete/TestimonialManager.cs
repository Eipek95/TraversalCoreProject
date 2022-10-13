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
            throw new NotImplementedException();
        }

        public IResult Update(Testmonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
