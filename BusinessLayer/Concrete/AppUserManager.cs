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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public IResult Add(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AppUser entity)
        {
            _appUserDal.Delete(entity);
            return new SuccessResult("Başarıyla Silindi");
        }

        public IDataResult<AppUser> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AppUser>> GetAll(Expression<Func<AppUser, bool>> filter = null)
        {
            return new SuccessDataResult<List<AppUser>>(_appUserDal.GetAll());
        }

        public IResult Update(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
