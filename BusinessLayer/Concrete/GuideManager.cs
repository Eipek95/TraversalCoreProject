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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public IResult Add(Guide entity)
        {
            _guideDal.Add(entity);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult ChangeToGuideStatus(int id)
        {
            _guideDal.ChangeToGuideStatus(id);
            return new Result(true, "Durum Güncellendi");
        }

        public IResult Delete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Guide> Get(int id)
        {
            return new SuccessDataResult<Guide>(_guideDal.Get(x => x.GuideID == id));
        }

        public IDataResult<List<Guide>> GetAll(Expression<Func<Guide, bool>> filter = null)
        {
            return new SuccessDataResult<List<Guide>>(_guideDal.GetAll());
        }

        public IResult Update(Guide entity)
        {
            _guideDal.Update(entity);
            return new SuccessResult();
        }
    }
}
