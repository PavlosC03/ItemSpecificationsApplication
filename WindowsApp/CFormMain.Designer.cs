namespace WindowsApp
{
    partial class CFormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuMasterDetail = new ToolStripMenuItem();
            mnuItems = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            mnuItemCategory = new ToolStripMenuItem();
            mnuMeasurementUnit = new ToolStripMenuItem();
            mnuSpecType = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuMasterDetail, tablesToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 24);
            mnuMain.TabIndex = 3;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuMasterDetail
            // 
            mnuMasterDetail.DropDownItems.AddRange(new ToolStripItem[] { mnuItems });
            mnuMasterDetail.Name = "mnuMasterDetail";
            mnuMasterDetail.Size = new Size(55, 20);
            mnuMasterDetail.Text = "Master";
            // 
            // mnuItems
            // 
            mnuItems.Name = "mnuItems";
            mnuItems.Size = new Size(230, 22);
            mnuItems.Text = "Items and Specifications";
            mnuItems.Click += DoOnAnyCommand;
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuItemCategory, mnuMeasurementUnit, mnuSpecType });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(51, 20);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // mnuItemCategory
            // 
            mnuItemCategory.Name = "mnuItemCategory";
            mnuItemCategory.Size = new Size(171, 22);
            mnuItemCategory.Text = "Item Category";
            mnuItemCategory.Click += DoOnAnyCommand;
            // 
            // mnuMeasurementUnit
            // 
            mnuMeasurementUnit.Name = "mnuMeasurementUnit";
            mnuMeasurementUnit.Size = new Size(171, 22);
            mnuMeasurementUnit.Text = "Measurement Unit";
            mnuMeasurementUnit.Click += DoOnAnyCommand;
            // 
            // mnuSpecType
            // 
            mnuSpecType.Name = "mnuSpecType";
            mnuSpecType.Size = new Size(171, 22);
            mnuSpecType.Text = "Specification Type";
            mnuSpecType.Click += DoOnAnyCommand;
            // 
            // CFormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Name = "CFormMain";
            Text = "Item Specifications";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuMasterDetail;
        private ToolStripMenuItem mnuItems;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem mnuItemCategory;
        private ToolStripMenuItem mnuMeasurementUnit;
        private ToolStripMenuItem mnuSpecType;
    }
}
