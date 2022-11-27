using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.DataInResult;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public IResult Add(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ContactUs> Get(int id)
        {
            return new SuccessDataResult<ContactUs>(_contactUsDal.Get(x => x.ContactUsID == id));
        }

        public IDataResult<List<ContactUs>> GetAll(Expression<Func<ContactUs, bool>> filter = null)
        {
            return new DataResult<List<ContactUs>>(_contactUsDal.GetAll(), true, Messages.ContactUsList);
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            throw new NotImplementedException();
        }

        public IResult Update(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        SuccessResult IContactUsService.ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ContactUs>> IContactUsService.GetListContactUsByFalse()
        {
            return new DataResult<List<ContactUs>>(_contactUsDal.GetListContactUsByFalse(), true, Messages.ContactUsFalseMessageList);
        }

        IDataResult<List<ContactUs>> IContactUsService.GetListContactUsByTrue()
        {
            return new DataResult<List<ContactUs>>(_contactUsDal.GetListContactUsByTrue(), true, Messages.ContactUsTrueMessageList);
        }
    }
}
