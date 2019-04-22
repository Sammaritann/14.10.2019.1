namespace PseudoEnumerable
{
    public interface IPredicate<T>
    {
        bool IsMatching(T item);
    }
}