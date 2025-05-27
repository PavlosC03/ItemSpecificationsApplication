using Lib.Data.DB;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Data.Records
{
    public class MEASUREMENT_UNIT : CDBRecord
    {
        [Key]
        public int CID { get; set; }

        [DisplayName("Unit Name")]
        public string? UNIT_NAME { get; set; }
    }
}
