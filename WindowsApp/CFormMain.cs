using ItemSpecifications.UX.Builders;
using ItemSpecifications.UX.WinForms;

namespace WindowsApp
{
    public partial class CFormMain : Form
    {
        public CFormTableItemCategory? FormTableItemCategory = null;
        public CFormTableMeasurementUnit? FormTableMeasurementUnit = null;
        public CFormTableSpecType? FormTableSpecType = null;

        // --------------------------------------------------------------------------------------
        public CFormMain()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == mnuItems)
            {
                new CMasterFormDirector(new CFormItemBuilder()).ConstructUX(this).Show();
            }
            else if (sender == mnuItemCategory)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableItemCategory == null)
                    FormTableItemCategory = new CFormTableItemCategory();
                FormTableItemCategory?.ShowDialog();
            }
            else if (sender == mnuMeasurementUnit)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableMeasurementUnit == null)
                    FormTableMeasurementUnit = new CFormTableMeasurementUnit();
                FormTableMeasurementUnit?.ShowDialog();
            }
            else if (sender == mnuSpecType)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableSpecType == null)
                    FormTableSpecType = new CFormTableSpecType();
                FormTableSpecType?.ShowDialog();
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
