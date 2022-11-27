using Core.DataAccess;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal : IEntityRepository<Announcement>
    {
    }
}
