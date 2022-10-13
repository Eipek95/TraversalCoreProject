using Core.Utilities.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IFeatureService : IGenericService<Feature>
    {
        //daha sonra generic kısma taşı
        IResult Add(Feature entity);
    }
}
