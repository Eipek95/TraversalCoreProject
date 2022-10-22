using Core.DataAccess;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal : IEntityRepository<Guide>
    {
        void ChangeToGuideStatus(int id);
    }
}
