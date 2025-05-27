using ItemSpecifications.Logic.Entities;
using ItemSpecifications.Logic.Models;
using Lib.Common.Interfaces;
using Lib.Logic;
using System.ComponentModel;
using System.Diagnostics;

namespace ItemSpecifications.Logic.DataModules
{
    public class CDMItem : CDataModule, IDataModule
    {
        // ....................................................................
        public IMasterDetailModel Model { get { return (IMasterDetailModel)this.model; } }
        // ....................................................................
        public CItemModel ItemModel { get { return (CItemModel)this.model; } }
        // ....................................................................
        public CItemBrowserModel BrowserModel;
        // ....................................................................

        public CMeasurementUnitListModel _MeasurementUnitLookup;
        public CMeasurementUnitListModel MeasurementUnitLookup { get { return this._MeasurementUnitLookup; } }
        // ....................................................................

        public CItemCategoryListModel _ItemCategoryLookup;
        public CItemCategoryListModel ItemCategoryLookup { get { return this._ItemCategoryLookup; } }

        // ....................................................................
        private CSpecTypeListModel _SpecTypeLookup;
        public CSpecTypeListModel SpecTypeLookup { get { return this._SpecTypeLookup; } }


        // --------------------------------------------------------------------------------------
        public CDMItem() : base()
        {
            this.model = new CItemModel();
            this.BrowserModel = new CItemBrowserModel();
            this._MeasurementUnitLookup = new CMeasurementUnitListModel(true);
            this._ItemCategoryLookup = new CItemCategoryListModel(true);
            this._SpecTypeLookup = new CSpecTypeListModel(true);
        }
        // --------------------------------------------------------------------------------------

        #region // IDataModule \\
        // ....................................................................
        public int MasterKeyValue { get; set; }
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public void ModuleOnAnyEntityChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender != null)
            {
                Debug.WriteLine($"Property {e.PropertyName} has changed on a :{sender.GetType().Name} entity.");

                if (sender is CItem)
                {
                    ((CItem)sender).LookupMeasurementUnit(this._MeasurementUnitLookup);
                    ((CItem)sender).LookupCategoryID(this._ItemCategoryLookup);
                }
                else if (sender is CItemSpec)
                    ((CItemSpec)sender).LookupSpecType(this._SpecTypeLookup);
            }
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleLoadBrowser()
        {
            bool bResult = false;
            try
            {
                BrowserModel.View.LoadTable(null);
                BrowserModel.AcceptVisitAfterLoad(this.entityLoader);
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
        public bool ModuleLoadLookups()
        {
            bool bResult = false;
            try
            {
                _MeasurementUnitLookup.Table.LoadTable(null);
                _MeasurementUnitLookup.AcceptVisitAfterLoad(this.entityLoader);

                _ItemCategoryLookup.Table.LoadTable(null);
                _ItemCategoryLookup.AcceptVisitAfterLoad(this.entityLoader);

                _SpecTypeLookup.Table.LoadTable(null);
                _SpecTypeLookup.AcceptVisitAfterLoad(this.entityLoader);

                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleNew()
        {
            IEntity iEntity = Model.NewMasterDetail();
            iEntity.OnPropertyChange += ModuleOnAnyEntityChange;
            return true;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleLoad()
        {
            bool bResult = false;
            try
            {
                Model.LoadMasterDetail(this.MasterKeyValue);
                this.entityLoader.EntityChangeHandler = ModuleOnAnyEntityChange;
                ItemModel.AcceptVisitAfterLoad(this.entityLoader);
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
                ItemModel.AcceptVisitBeforeSave(this.recordAdder); // Custom code for CItemModel
                this.MasterKeyValue = Model.SaveMasterDetail();
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleDelete()
        {
            bool bResult = false;
            try
            {
                Model.DeleteMasterDetail();
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
