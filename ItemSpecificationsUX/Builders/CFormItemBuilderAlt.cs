using ItemSpecifications.Logic.DataModules;
using ItemSpecifications.Logic.Entities;
using ItemSpecifications.UX.WinForms;
using Lib.UX.DataForms;

namespace ItemSpecifications.UX.Builders
{
    public class CFormItemBuilderAlt : CMasterFormBuilder
    {
        protected CDMItem module;
        protected IBrowserViewForm browserView;
        protected Form entityView;

        // --------------------------------------------------------------------------------
        public override void BuildDataModule()
        {
            this.module = new CDMItem();
        }
        // --------------------------------------------------------------------------------
        public override void BuildBrowserView()
        {
            this.browserView = new CViewBrowserDefault<CItem>(this.module.BrowserModel);
        }
        // --------------------------------------------------------------------------------
        public override void BuildEntityView()
        {
            this.entityView = new CViewEntityItem();
        }
        // --------------------------------------------------------------------------------
        public override void BuildForm()
        {
            this.Product = new CFormTemplateMaster(module, browserView, entityView);
        }
        // --------------------------------------------------------------------------------
    }
}
