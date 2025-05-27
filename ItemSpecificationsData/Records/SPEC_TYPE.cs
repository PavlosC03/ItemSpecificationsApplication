using Lib.Common.Attribs;
using Lib.Data.DB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Data.Records
{
    public class SPEC_TYPE : CDBRecord
    {
        [Key]
        [ColumnWidth(30)]
        public int CID { get; set; }

        [DisplayName("Item Specification")]
        public string? SPECIFICATION_NAME { get; set; }

        [DisplayName("Unit name")]
        public string? UNIT_NAME { get; set; }
    }
}
