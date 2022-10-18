using Core.DataAccess;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
    }
}
