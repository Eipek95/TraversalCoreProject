using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactUsDal : EfEntityRepositoryBase<ContactUs, Context>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == false).ToList();
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == true).ToList();
            }
        }
    }
}
