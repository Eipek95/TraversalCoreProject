using Core.DataAccess;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IEntityRepository<Reservation>
    {
    }
}
