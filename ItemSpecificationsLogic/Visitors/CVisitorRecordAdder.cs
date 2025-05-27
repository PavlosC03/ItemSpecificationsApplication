using ItemSpecifications.Logic.Entities;
using Lib.Logic;
using System.Collections;

namespace ItemSpecifications.Logic.Visitors
{
    public class CVisitorRecordAdder : IVisitorToModel
    {

        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemCategory> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemSpec> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CMeasurementUnit> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSpecType> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion

    }
}
