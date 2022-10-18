using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, Context>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }
    }
}
