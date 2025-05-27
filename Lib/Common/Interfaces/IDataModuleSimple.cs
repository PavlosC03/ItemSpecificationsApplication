namespace Lib.Common.Interfaces
{
    public interface IDataModuleSimple
    {
        public string LastError { get; set; }
        public bool IsLoaded { get; set; }
        public bool ModuleLoad();
        public bool ModuleSave();
    }
}
