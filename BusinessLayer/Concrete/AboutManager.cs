using BusinessLayer.Abstract;
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

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About Get(int id)
        {
            return _aboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetAll(Expression<Func<About, bool>> filter = null)
        {
            return _aboutDal.GetAll();
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
