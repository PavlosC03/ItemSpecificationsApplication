using Lib.Data.DB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Data.Records
{
    public class ITEM_CATEGORY : CDBRecord
    {
        [Key]
        public int CID { get; set; }

        [DisplayName("Category Name")]
        public string CATEGORY_NAME { get; set; }
        public int? PARENT_CATEGORY_CID { get; set; }
    }
}
