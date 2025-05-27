namespace Lib.Data.Structures
{
    public interface IItemIterator<T>
    {
        public bool EndOf { get; }
        public void Reset();
        public T? Next();
    }
}
