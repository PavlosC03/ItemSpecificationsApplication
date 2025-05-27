using ItemSpecifications.Logic.Entities;
using ItemSpecifications.Logic.Visitors;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic.Models
{
    public class CItemBrowserModel : List<CItem>
    {
        // ....................................................................
        public IDBTable View = CDBTableFactory.Instance.CreateTable("ITEM");
        // ....................................................................
        private Dictionary<string, Object> _criteria = new Dictionary<string, object>();
        public Dictionary<string, object> Criteria { get { return _criteria; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            p_oEntityLoader.Visit(this.View.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------

    }
}
