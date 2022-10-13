using BusinessLayer.Abstract;
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

        public void Add(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetAll(Expression<Func<SubAbout, bool>> filter = null)
        {
            return _subAboutDal.GetAll();
        }

        public void Update(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
