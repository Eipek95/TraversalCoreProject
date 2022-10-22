using Core.Utilities.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        IResult ChangeToGuideStatus(int id);
    }
}
