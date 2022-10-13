namespace Core.Utilities.Results
{
    //Temel voidler 
    public interface IResult
    {
        bool IsSucess { get; }
        string Message { get; }
    }
}
