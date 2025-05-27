using ItemSpecifications.Data.Records;
using Lib.Logic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Logic.Entities
{
    public class CItem : CEntity<ITEM>
    {
        [Key]
        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        public string Code
        {
            get { return this.Record.CODE; }
            set { this.Record.CODE = value; }
        }

        public string Name
        {
            get { return this.Record.NAME; }
            set { this.Record.NAME = value; }
        }

        public int? MeasurementUnitID
        {
            get { return this.Record.MEASUREMENT_UNIT_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.MEASUREMENT_UNIT_CID = null;
                else
                    this.Record.MEASUREMENT_UNIT_CID = value;
                InvokePropertyChanged(nameof(MeasurementUnitID));
            }
        }

        public void LookupMeasurementUnit(List<CMeasurementUnit> p_oMeasurementUnit)
        {
            var oFound = p_oMeasurementUnit.Where(x => x.CodeId == this.MeasurementUnitID).ToList();
            if (oFound.Count > 0)
                this.MeasurementUnit = oFound[0];
            else
                this.MeasurementUnit = null;
        }

        [Browsable(false)]
        public CMeasurementUnit? MeasurementUnit { get; set; } = null;

        public decimal Quantity
        {
            get { return this.Record.QUANTITY; }
            set { this.Record.QUANTITY = value; }
        }

        public int? ItemCategoryId
        {
            get { return this.Record.ITEM_CATEGORY_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.ITEM_CATEGORY_CID = null;
                else
                    this.Record.ITEM_CATEGORY_CID = value;
                InvokePropertyChanged(nameof(ItemCategoryId));
            }
        }

        public void LookupCategoryID(List<CItemCategory> p_oItemCateogry)
        {
            var oFound = p_oItemCateogry.Where(x => x.CodeId == this.ItemCategoryId).ToList();
            if (oFound.Count > 0)
                this.ItemCategory = oFound[0];
            else
                this.ItemCategory = null;
        }

        [Browsable(false)]
        public CItemCategory? ItemCategory { get; set; } = null;

        public decimal Price
        {
            get { return this.Record.PRICE; }
            set { this.Record.PRICE = value; }
        }

        public bool IsCompanyProduced
        {
            get { return this.Record.ISCOMPANYPRODUCED; }
            set { this.Record.ISCOMPANYPRODUCED = value; }
        }
    }
}
