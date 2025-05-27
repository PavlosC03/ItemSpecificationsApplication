using ItemSpecifications.Data.Records;
using Lib.Logic;

namespace ItemSpecifications.Logic.Entities
{
    public class CItemSpec : CEntity<ITEM_SPEC>
    {
        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        public int ItemId
        {
            get { return this.Record.ITEM_ID; }
            set { this.Record.ITEM_ID = value; }
        }

        public int? SpecTypeId
        {
            get { return this.Record.SPEC_TYPE_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.SPEC_TYPE_CID = null;
                else
                    this.Record.SPEC_TYPE_CID = value;
                InvokePropertyChanged(nameof(SpecTypeId));
            }
        }

        public void LookupSpecType(List<CSpecType> p_oItemSpec)
        {
            var oFound = p_oItemSpec.FirstOrDefault(x => x.Id == this.SpecTypeId); //may need to change firstordefault
            if (oFound != null)
                this.SpecTypeId = oFound.Id;
            else
                this.SpecTypeId = null;
        }

        public string Title
        {
            get { return this.Record.TITLE; }
            set { this.Record.TITLE = value; }
        }

        public int Value
        {
            get { return this.Record.VALUE; }
            set { this.Record.VALUE = value; }
        }
    }
}
