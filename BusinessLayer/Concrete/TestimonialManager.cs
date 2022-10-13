using BusinessLayer.Abstract;
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

        public void Add(Testmonial entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testmonial entity)
        {
            throw new NotImplementedException();
        }

        public Testmonial Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testmonial> GetAll(Expression<Func<Testmonial, bool>> filter = null)
        {
            return _testmonialDal.GetAll();
        }

        public void Update(Testmonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
