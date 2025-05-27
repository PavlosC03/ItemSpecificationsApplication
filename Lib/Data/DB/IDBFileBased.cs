namespace Lib.Data.DB
{
    public interface IDBFileBased : IDatabase
    {
        public string DBPath { get; set; }
        public string DBFileName { get; }
    }
}
