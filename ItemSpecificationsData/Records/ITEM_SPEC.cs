using Lib.Data.DB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Data.Records
{
    public class ITEM_SPEC : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Item ID")]
        public int ITEM_ID { get; set; }

        [DisplayName("Specification Type ID")]
        public int? SPEC_TYPE_CID { get; set; }
        public string TITLE { get; set; }
        public int VALUE { get; set; }

    }
}

