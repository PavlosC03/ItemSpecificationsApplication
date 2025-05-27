using ItemSpecifications.Data.Records;
using Lib.Common.Attribs;
using Lib.Logic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Logic.Entities
{
    public class CMeasurementUnit : CEntity<MEASUREMENT_UNIT>
    {
        [Key]
        [ColumnWidth(30)]
        public int CodeId
        {
            get { return this.Record.CID; }
            set { this.Record.CID = value; }
        }

        [DisplayName("Unit Name")]
        public string? UnitName
        {
            get { return this.Record.UNIT_NAME; }
            set
            {
                if (value == null)
                    throw new Exception("The item should have a unit name");
                else
                    this.Record.UNIT_NAME = value;
            }
        }

        public CMeasurementUnit() : base()
        {
        }
    }
}
