namespace ItemSpecifications.UX.Builders
{
    //[PATTERNS] Builder: The director has the code with the sequence of steps that builds the product-object
    public class CMasterFormDirector
    {
        protected CMasterFormBuilder builder;

        // --------------------------------------------------------------------------------
        public CMasterFormDirector(CMasterFormBuilder p_oBuilder)
        {
            this.builder = p_oBuilder;
        }
        // --------------------------------------------------------------------------------
        public Form ConstructUX(Form p_oMDIParent)
        {
            //[PATTERNS] BUILDER: The director instructs the builder to build the parts of the product 
            this.builder.BuildDataModule();
            this.builder.BuildBrowserView();
            this.builder.BuildEntityView();
            this.builder.BuildForm();

            // It returns the product form after making it an MDI child of the given form
            this.builder.Product.MdiParent = p_oMDIParent;
            return this.builder.Product;
        }
        // --------------------------------------------------------------------------------

    }
}
