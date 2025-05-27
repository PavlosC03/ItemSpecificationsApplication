using ItemSpecifications.Logic.DataModules;
using ItemSpecifications.Logic.Entities;
using Lib.UX.DataForms;
using Lib.UX.DataGrid;
using System.Data;

namespace ItemSpecifications.UX.WinForms
{
    public partial class CViewEntityItem : Form, IEntityViewForm
    {
        protected CDMItem module { get; set; }
        protected CEditableGridDecorator detailsGrid;
        protected DataGridViewComboBoxColumn? cbcItem = null;

        // --------------------------------------------------------------------------------------

        public CViewEntityItem()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        public void SetParent(Form p_oForm)
        {
            CFormTemplateMaster oMasterForm = (CFormTemplateMaster)p_oForm;

            this.detailsGrid = new CEditableGridDecorator(this.dgvDetails, oMasterForm.FormContext);
            oMasterForm.DetailGrids.Add(this.detailsGrid);

            this.module = (CDMItem)oMasterForm.Module;
        }
        // --------------------------------------------------------------------------------------
        public void WriteMasterToUI()
        {
            CItem oCurrentItem = this.module.ItemModel.Master;

            // Set Name and Code fields
            this.txtName.Text = oCurrentItem.Name;
            this.txtCode.Text = oCurrentItem.Code;

            // Display the ItemCategory in the ComboBox
            this.displayItemCategoryLookup(oCurrentItem);

            // Display the MeasurementUnit in the ComboBox
            this.displayMeasurementUnitLookup(oCurrentItem);

            // Set Price field, handle null or invalid values
            this.txtPrice.Text = oCurrentItem.Price.ToString("F2");

            // Set IsCompanyProduced checkbox
            this.cbxIsCompanyProduced.Checked = oCurrentItem.IsCompanyProduced;
        }

        // --------------------------------------------------------------------------------------
        public void ReadMasterFromUI()
        {
            CItem oCurrentItem = this.module.ItemModel.Master;

            // Read the Name and Code fields
            oCurrentItem.Name = this.txtName.Text;
            oCurrentItem.Code = this.txtCode.Text;

            // Parse the Price field
            if (decimal.TryParse(this.txtPrice.Text, out decimal parsedPrice))
            {
                oCurrentItem.Price = parsedPrice;
            }
            else
            {
                // Handle invalid input, e.g., show an error message or set a default value
                MessageBox.Show("Invalid price entered. Please enter a valid numeric value.", "Input Error");
                oCurrentItem.Price = 0; // Set a default value if necessary
            }

            // Set IsCompanyProduced based on the checkbox value
            oCurrentItem.IsCompanyProduced = this.cbxIsCompanyProduced.Checked;

            // Set ItemCategoryId based on the selected ItemCategory
            if (this.cboItemCategory.SelectedItem != null)
            {
                CItemCategory selectedCategory = (CItemCategory)this.cboItemCategory.SelectedItem;
                oCurrentItem.ItemCategoryId = selectedCategory.CodeId;
            }

            // Set MeasurementUnitId based on the selected MeasurementUnit
            if (this.cboMeasurementUnit.SelectedItem != null)
            {
                CMeasurementUnit selectedUnit = (CMeasurementUnit)this.cboMeasurementUnit.SelectedItem;
                oCurrentItem.MeasurementUnitID = selectedUnit.CodeId;
            }
        }

        // --------------------------------------------------------------------------------------
        public void WriteDetailListToUI()
        {

            // [PATTERNS] Proxy
            this.detailsGrid.Populate<CItemSpec>(this.module.ItemModel.Details);

            this.addLookupComboBoxOnDetailList();
        }
        // --------------------------------------------------------------------------------------


        #region (( Custom Code for Lookups ))
        // --------------------------------------------------------------------------------------
        private void displayItemCategoryLookup(CItem p_oCurrentItem)
        {
            // Filter out null or empty items from the ItemCategoryLookup
            var filteredItemCategories = this.module.ItemCategoryLookup
                .Where(category => !string.IsNullOrEmpty(category.CategoryName))  // or any other valid field
                .ToList();

            // Load the filtered options into the ComboBox
            this.cboItemCategory.ValueMember = "CodeId";
            this.cboItemCategory.DisplayMember = "CategoryName";
            this.cboItemCategory.Items.Clear();

            foreach (var oItemCategory in filteredItemCategories)
            {
                this.cboItemCategory.Items.Add(oItemCategory);
            }

            // Lookup relation to get the foreign entity and its fields
            p_oCurrentItem.LookupCategoryID(filteredItemCategories);

            this.cboItemCategory.SelectedItem = p_oCurrentItem.ItemCategory;

            // Display a default or null-friendly value in case of missing Category
            this.cboItemCategory.Text = p_oCurrentItem.ItemCategory?.CategoryName ?? "No Category";
        }

        // --------------------------------------------------------------------------------------
        private void displayMeasurementUnitLookup(CItem p_oCurrentItem)
        {
            // Filter out null or empty items from the ItemCategoryLookup
            var filteredMeasurementUnits = this.module.MeasurementUnitLookup
                .Where(UnitName => !string.IsNullOrEmpty(UnitName.UnitName))  // or any other valid field
                .ToList();

            // Load the filtered options into the ComboBox
            this.cboMeasurementUnit.ValueMember = "CodeId";
            this.cboMeasurementUnit.DisplayMember = "UnitName";
            this.cboMeasurementUnit.Items.Clear();

            foreach (var oMeasurementUnit in filteredMeasurementUnits)
            {
                this.cboMeasurementUnit.Items.Add(oMeasurementUnit);
            }

            // Lookup relation to get the foreign entity and its fields
            p_oCurrentItem.LookupMeasurementUnit(filteredMeasurementUnits);

            this.cboMeasurementUnit.SelectedItem = p_oCurrentItem.ItemCategory;

            // Display a default or null-friendly value in case of missing Category
            this.cboMeasurementUnit.Text = p_oCurrentItem.MeasurementUnit?.UnitName ?? "No Measurement Unit";
        }
        // --------------------------------------------------------------------------------------


        protected void addLookupComboBoxOnDetailList()
        {
            // Check if the ComboBox column already exists by looking for the specific column name
            bool columnExists = this.dgvDetails.Columns
                .Cast<DataGridViewColumn>()
                .Any(col => col.HeaderText == "Specification Name");

            // If the ComboBox column doesn't exist, create and add it
            if (!columnExists)
            {
                this.cbcItem = new DataGridViewComboBoxColumn()
                {
                    HeaderText = "Specification Name",
                    Width = 200,
                    ValueMember = "Id",              // The key field of the lookup entity (Id)
                    DisplayMember = "SpecificationName",  // The field to display in the ComboBox
                    DataPropertyName = "UnitName",    // The foreign key field on the detail entity
                    FlatStyle = FlatStyle.Popup
                };

                // Insert the ComboBox column at the front (index 0)
                this.dgvDetails.Columns.Insert(0, this.cbcItem);

                // Bind the ComboBox to the data source (SpecTypeLookup)
                this.cbcItem.DataSource = this.module.SpecTypeLookup;  // Ensure SpecTypeLookup is a list of CSpecType objects
                this.cbcItem.DisplayMember = "SpecificationName";       // Field to display in the ComboBox
                this.cbcItem.ValueMember = "Id";                        // Field to use as the value of the ComboBox
            }
            else
            {
                // If the column already exists, just make sure it's visible
                var existingColumn = this.dgvDetails.Columns
                    .Cast<DataGridViewColumn>()
                    .FirstOrDefault(col => col.HeaderText == "Specification Name");

                if (existingColumn != null)
                {
                    existingColumn.Visible = true;
                }
            }
        }


        // --------------------------------------------------------------------------------------
        #endregion

        // --------------------------------------------------------------------------------------
        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == btnNewDetail)
                this.detailsGrid.CreateRow<CItemSpec>(new CItemSpec());
            else if (sender == btnDeleteDetail)
                this.detailsGrid.DeleteRow();
        }
        // --------------------------------------------------------------------------------------
    }
}
