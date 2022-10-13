using BusinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetAll(Expression<Func<Feature, bool>> filter = null)
        {
            return _featureDal.GetAll(filter);
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }

        //aşagısı generice eklenince değişecek sadece deneme amaçlı yapılıyor
        IResult IFeatureService.Add(Feature entity)
        {
            if (entity.Description.Length < 2)
            {
                return new ErrorResult("Feature ismi en az iki karekter olmalı");
            }
            _featureDal.Add(entity);
            return new Result(true, "feature eklendi");
        }
    }
}
