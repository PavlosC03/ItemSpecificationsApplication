using System.ComponentModel;


namespace Lib.Logic
{
    public interface IEntity
    {
        public EntityChangeType Change { get; set; }
        public event PropertyChangedEventHandler OnPropertyChange;
        public int PrimaryKeyValue { get; }
    }
}
