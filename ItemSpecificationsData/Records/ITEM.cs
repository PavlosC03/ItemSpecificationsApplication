using Lib.Data.DB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Data.Records
{
    public class ITEM : CDBRecord
    {
        [Key]
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }

        [DisplayName("Measurement Unit ID")]
        public int? MEASUREMENT_UNIT_CID { get; set; }
        public decimal QUANTITY { get; set; }

        [DisplayName("Item Category ID")]
        public int? ITEM_CATEGORY_CID { get; set; }
        public decimal PRICE { get; set; }
        public bool ISCOMPANYPRODUCED { get; set; }
    }
}
