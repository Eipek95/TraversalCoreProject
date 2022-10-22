using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IReportService
    {
        byte[] ExcelList<T>(List<T> t) where T : class;
    }
}
