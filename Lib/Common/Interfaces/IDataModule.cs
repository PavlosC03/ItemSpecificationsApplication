using System.ComponentModel;

namespace Lib.Common.Interfaces
{
    public interface IDataModule : IDataModuleSimple
    {
        public int MasterKeyValue { get; set; }
        public void ModuleOnAnyEntityChange(object? sender, PropertyChangedEventArgs e);
        public bool ModuleLoadBrowser();
        public bool ModuleLoadLookups();
        public bool ModuleNew();
        public bool ModuleDelete();
    }
}
