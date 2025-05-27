using ItemSpecifications.Data.Records;
using ItemSpecifications.Logic.Entities;
using System.Collections;
using System.ComponentModel;


namespace ItemSpecifications.Logic.Visitors
{
    public class CVisitorEntityLoader : IVisitorToModel
    {
        public PropertyChangedEventHandler? EntityChangeHandler { get; set; } = null;

        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList)
        {
            foreach (ITEM oRecord in p_oRecordSet)
            {
                CItem oEntity = new CItem();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemCategory> p_oEntityList)
        {
            foreach (ITEM_CATEGORY oRecord in p_oRecordSet)
            {
                CItemCategory oEntity = new CItemCategory();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                oEntity.CodeId = oEntity.CodeId; // Trigger the event to get the category name
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemSpec> p_oEntityList)
        {
            foreach (ITEM_SPEC oRecord in p_oRecordSet)
            {
                CItemSpec oEntity = new CItemSpec();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CMeasurementUnit> p_oEntityList)
        {
            foreach (MEASUREMENT_UNIT oRecord in p_oRecordSet)
            {
                CMeasurementUnit oEntity = new CMeasurementUnit();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSpecType> p_oEntityList)
        {
            foreach (SPEC_TYPE oRecord in p_oRecordSet)
            {
                CSpecType oEntity = new CSpecType();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
