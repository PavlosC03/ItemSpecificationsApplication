namespace Lib.Data
{
    public interface IRecordPaginator<T>
    {
        public List<T>? First();
        public List<T>? Next();
        public bool EndOfRecords { get; }
    }
}
