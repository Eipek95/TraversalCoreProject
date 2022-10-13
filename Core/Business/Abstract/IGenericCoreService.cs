using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
    public interface IGenericCoreService<T>
    {
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IDataResult<T> Get(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
