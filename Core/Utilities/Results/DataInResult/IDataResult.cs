namespace Core.Utilities.Results.DataInResult
{
    public interface IDataResult<T> : IResult
    {
        //döndürelecek data içerir.sonuç ve mesaj ise IResult içinden gelir
        T Data { get; }
    }
}
