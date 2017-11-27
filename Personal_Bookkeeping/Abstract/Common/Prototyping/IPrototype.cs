namespace Personal_Bookkeeping.Abstract.Common.Prototyping
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
