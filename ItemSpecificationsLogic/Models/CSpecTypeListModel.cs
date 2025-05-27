using ItemSpecifications.Logic.Entities;
using ItemSpecifications.Logic.Visitors;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.Models
{
    public class CSpecTypeListModel : List<CSpecType>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("SPEC_TYPE");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CSpecTypeListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CSpecType() { Id = -1, SpecificationName = "" });  //Lookup entry for null key value
            p_oEntityLoader.Visit(this.Table.RecordSet, this);

        }
        // --------------------------------------------------------------------------------------
        // Synchronizes the table records with the entries in the model, by adding any 
        // missing records to the list Records.
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.Table.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
    }

}
