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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public IResult Add(Announcement entity)
        {
            _announcementDal.Add(entity);
            return new SuccessResult(Messages.AnnouncementAdded);
        }

        public IResult Delete(Announcement entity)
        {
            _announcementDal.Delete(entity);
            return new Result(true, "Duyuru Başarıyla Silindi");
        }

        public IDataResult<Announcement> Get(int id)
        {
            return new SuccessDataResult<Announcement>(_announcementDal.Get(x => x.AmouncementID == id));
        }

        public IDataResult<List<Announcement>> GetAll(Expression<Func<Announcement, bool>> filter = null)
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll());
        }

        public IResult Update(Announcement entity)
        {
            _announcementDal.Update(entity);
            return new Result(true, "Duyuru Başarıyla Güncellendi");
        }
    }
}
