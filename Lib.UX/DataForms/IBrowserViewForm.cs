using Lib.Logic;

namespace Lib.UX.DataForms
{
    public interface IBrowserViewForm
    {
        public void SetParent(Form p_oForm);

        public void Dock(Control p_oContainer);

        public void WriteBrowserListToTheUI();

        public bool HasSelectedInBrowser { get; }
        public IEntity SelectedEntity { get; }
    }
}
