using ItemSpecifications.Logic.Models;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.DataModules
{
    public class CDMMeasurementUnitList : CDataModule, IDataModuleSimple
    {
        // ....................................................................
        public CMeasurementUnitListModel Model { get { return (CMeasurementUnitListModel)this.model; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMMeasurementUnitList() : base()
        {
            this.model = new CMeasurementUnitListModel(false);
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
