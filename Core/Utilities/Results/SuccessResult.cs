namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //base:Result in ctor ---->paramters
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
