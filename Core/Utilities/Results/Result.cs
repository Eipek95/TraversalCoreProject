namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //iki parametreli olarak gönderirsen success kısmınıda  çaılştır
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }//readonly normalde set edilemez ama ctor içinde set edilebilir
    }
}
