using ItemSpecifications.Logic.Models;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.DataModules
{
    public class CDMItemSpecList : CDataModule, IDataModuleSimple
    {
        // ....................................................................
        public CItemSpecListModel Model { get { return (CItemSpecListModel)this.model; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMItemSpecList() : base()
        {
            this.model = new CItemSpecListModel(false);
        }
        // --------------------------------------------------------------------------------------

        #region // IDataModuleSimple \\
        public bool ModuleLoad()
        {
            bool bResult = false;
            try
            {
                Model?.Table.LoadTable(null);
                Model?.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleSave()
        {
            bool bResult = false;
            try
            {
                Model?.AcceptVisitBeforeSave(this.recordAdder);
                Model?.Table.SaveTable(null);
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        #endregion

    }
}
