using ItemSpecifications.Data.Records;
using Lib.Logic;

namespace ItemSpecifications.Logic.Entities
{
    public class CSpecType : CEntity<SPEC_TYPE>
    {
        public int Id { get { return this.Record.CID; } set { this.Record.CID = value; } }
        public string? SpecificationName
        {
            get { return this.Record.SPECIFICATION_NAME; }
            set
            {
                if (value == null)
                    throw new Exception("The item should have a specification name");
                else
                    this.Record.SPECIFICATION_NAME = value;
            }
        }
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
    }
}
