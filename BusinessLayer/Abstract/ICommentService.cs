using Core.Utilities.Results.DataInResult;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        IDataResult<List<Comment>> GetAll(int destinationID);//getall overriding ----->DestinationID
        List<Comment> GetListCommentWithDestination();
    }
}
