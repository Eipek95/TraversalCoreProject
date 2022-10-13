namespace Core.Utilities.Results
{
    //Temel voidler 
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
