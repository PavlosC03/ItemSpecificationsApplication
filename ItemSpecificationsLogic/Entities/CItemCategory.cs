using ItemSpecifications.Data.Records;
using Lib.Common.Attribs;
using Lib.Logic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ItemSpecifications.Logic.Entities
{
    public class CItemCategory : CEntity<ITEM_CATEGORY>
    {
        [Key]
        [ColumnWidth(30)]
        public int CodeId
        {
            get { return this.Record.CID; }
            set { this.Record.CID = value; }
        }

        [DisplayName("Category Name")]
        public string? CategoryName
        {
            get { return this.Record.CATEGORY_NAME; }
            set
            {
                if (value == null)
                    throw new Exception("The item should have a unit name");
                else
                    this.Record.CATEGORY_NAME = value;
            }
        }

        public int? ParentCategoryCID
        {
            get { return this.Record.PARENT_CATEGORY_CID; }
            set { this.Record.PARENT_CATEGORY_CID = value; }
        }

        public CItemCategory() : base()
        {
        }
    }
}
