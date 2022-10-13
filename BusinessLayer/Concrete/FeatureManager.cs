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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public IResult Add(Feature entity)
        {
            if (entity.Description.Length < 2)
            {
                return new ErrorResult("Feature ismi en az iki karekter olmalı");
            }
            _featureDal.Add(entity);
            return new SuccessResult(Messages.FeatureAdded);
        }

        public IResult Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Feature> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Feature>> GetAll(Expression<Func<Feature, bool>> filter = null)
        {
            return new DataResult<List<Feature>>(_featureDal.GetAll(), true, Messages.FeatureListed);
        }

        public IResult Update(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
