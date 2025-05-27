using ItemSpecifications.Logic.Entities;
using System.Collections;

namespace ItemSpecifications.Logic.Visitors
{
    public interface IVisitorToModel
    {
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CItemCategory> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CItemSpec> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CMeasurementUnit> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CSpecType> p_oEntityList);

    }
}
