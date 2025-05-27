using ItemSpecifications.Logic.Entities;
using ItemSpecifications.Logic.Visitors;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.Models
{
    public class CItemCategoryListModel : List<CItemCategory>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("ITEM_CATEGORY");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CItemCategoryListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CItemCategory() { CodeId = -1, CategoryName = "" });  //Lookup entry for null key value
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
