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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment entity)
        {
            if (DateTime.Now.Year == 2022)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {
                _commentDal.Add(entity);
                return new SuccessResult("Yorumunuz eklendi");
            }
        }

        public IResult Delete(Comment entity)
        {
            _commentDal.Delete(entity);
            return new SuccessResult("Yorum Başarıyla silindi");
        }

        public IDataResult<Comment> Get(int id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(x => x.CommentID == id));
        }

        public IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<List<Comment>> GetAll(int destinationID)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(x => x.DestinationID == destinationID));
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public IResult Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
