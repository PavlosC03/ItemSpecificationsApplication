using ItemSpecifications.Logic.Models;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.DataModules
{
    public class CDMSpecTypeList : CDataModule, IDataModuleSimple
    {
        // ....................................................................
        public CSpecTypeListModel Model { get { return (CSpecTypeListModel)this.model; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMSpecTypeList() : base()
        {
            this.model = new CSpecTypeListModel(false);
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
