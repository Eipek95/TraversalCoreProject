using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService : IGenericService<ContactUs>
    {
        IDataResult<List<ContactUs>> GetListContactUsByTrue();
        IDataResult<List<ContactUs>> GetListContactUsByFalse();
        SuccessResult ContactUsStatusChangeToFalse(int id);
    }
}
