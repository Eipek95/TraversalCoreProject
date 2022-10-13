using Core;

namespace EntityLayer.Dtos
{
    public class ExampleDto : IDto
    {//birkaç tablonun birkaç sütunun ortak kullanıldığı yerdir.Db ile doğrudan ilişkisi yoktur

        public int ThisTableColumnID { get; set; }
        public string ThisTableColumnName { get; set; }
        public string AnotherTableInColumnName { get; set; }
    }
}


//ilgili dataacess içindeki abstract ve concrete içine yazılır.business içinede yazmayı unutma 
