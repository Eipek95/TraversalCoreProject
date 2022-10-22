using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfGuideDal : EfEntityRepositoryBase<Guide, Context>, IGuideDal
    {
        public void ChangeToGuideStatus(int id)
        {
            using (var c = new Context())
            {
                var getData = c.Guides.Find(id);
                if (getData.Status == false)
                {
                    getData.Status = true;
                }
                else
                {
                    getData.Status = false;
                }
                c.SaveChanges();
            }
        }
    }
}
