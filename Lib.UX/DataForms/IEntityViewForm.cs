namespace Lib.UX.DataForms
{
    public interface IEntityViewForm
    {
        public void SetParent(Form p_oForm);
        public void WriteMasterToUI();
        public void ReadMasterFromUI();
        public void WriteDetailListToUI();
    }
}
