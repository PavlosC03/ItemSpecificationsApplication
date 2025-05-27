using ItemSpecifications.Logic.DataModules;
using ItemSpecifications.Logic.Entities;


namespace ItemSpecifications.UX.WinForms
{
    // [C#] Example of a form that can be design that inherits a form
    public partial class CFormTableItemCategory : CFormTemplateTable
    {
        protected CDMItemCategoryList module;

        // --------------------------------------------------------------------------------------
        public CFormTableItemCategory() : base()
        {
            InitializeComponent();
            this.module = new CDMItemCategoryList();
        }
        // --------------------------------------------------------------------------------------
        protected override void DisplayModelEntitiesOnGrid()
        {
            editableGridRecords.Populate<CItemCategory>(this.module.Model);
        }
        // --------------------------------------------------------------------------------------
        protected override bool IsModuleLoaded()
        {
            return this.module.IsLoaded;
        }
        // --------------------------------------------------------------------------------------
        protected override bool LoadModule()
        {
            return this.module.ModuleLoad();
        }
        // --------------------------------------------------------------------------------------
        protected override bool SaveModule()
        {
            return this.module.ModuleSave();
        }
        // --------------------------------------------------------------------------------------
        protected override string LastErrorMessage()
        {
            return this.module.LastError;
        }
        // --------------------------------------------------------------------------------------
    }
}
