namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //iki parametreli olarak gönderirsen success kısmınıda  çaılştır
        public Result(bool isSucess, string message) : this(isSucess)
        {
            Message = message;
        }
        public Result(bool isSucess)
        {
            IsSucess = isSucess;
        }


        public bool IsSucess { get; }

        public string Message { get; }//readonly normalde set edilemez ama ctor içinde set edilebilir
    }
}
