using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Abstract
{
    public interface IGenericCoreService<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
