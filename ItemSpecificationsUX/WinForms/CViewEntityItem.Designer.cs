namespace ItemSpecifications.UX.WinForms
{
    partial class CViewEntityItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleteDetail = new Button();
            btnNewDetail = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblMeasurementUnit = new Label();
            cboMeasurementUnit = new ComboBox();
            dgvDetails = new DataGridView();
            lblCode = new Label();
            txtCode = new TextBox();
            lblItemCategory = new Label();
            cboItemCategory = new ComboBox();
            lblPrice = new Label();
            lblIsCompanyProduced = new Label();
            txtPrice = new TextBox();
            cbxIsCompanyProduced = new CheckBox();
            lblDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteDetail
            // 
            btnDeleteDetail.Location = new Point(656, 109);
            btnDeleteDetail.Name = "btnDeleteDetail";
            btnDeleteDetail.Size = new Size(32, 32);
            btnDeleteDetail.TabIndex = 24;
            btnDeleteDetail.Text = "-";
            btnDeleteDetail.UseVisualStyleBackColor = true;
            btnDeleteDetail.Click += DoOnAnyCommand;
            // 
            // btnNewDetail
            //   
            btnNewDetail.Location = new Point(618, 109);
            btnNewDetail.Name = "btnNewDetail";
            btnNewDetail.Size = new Size(32, 32);
            btnNewDetail.TabIndex = 23;
            btnNewDetail.Text = "+";
            btnNewDetail.UseVisualStyleBackColor = true;
            btnNewDetail.Click += DoOnAnyCommand;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 17;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 13;
            // 
            // lblMeasurementUnit
            // 
            lblMeasurementUnit.AutoSize = true;
            lblMeasurementUnit.Location = new Point(320, 15);
            lblMeasurementUnit.Name = "lblMeasurementUnit";
            lblMeasurementUnit.Size = new Size(108, 15);
            lblMeasurementUnit.TabIndex = 18;
            lblMeasurementUnit.Text = "Measurement Unit:";
            // 
            // cboMeasurementUnit
            // 
            cboMeasurementUnit.FormattingEnabled = true;
            cboMeasurementUnit.Location = new Point(434, 11);
            cboMeasurementUnit.Name = "cboMeasurementUnit";
            cboMeasurementUnit.Size = new Size(240, 23);
            cboMeasurementUnit.TabIndex = 16;
            // 
            // dgvDetails
            // 
            dgvDetails.Location = new Point(118, 147);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowTemplate.Height = 25;
            dgvDetails.Size = new Size(570, 344);
            dgvDetails.TabIndex = 21;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(12, 43);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(38, 15);
            lblCode.TabIndex = 25;
            lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(82, 40);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(203, 23);
            txtCode.TabIndex = 26;
            // 
            // lblItemCategory
            // 
            lblItemCategory.AutoSize = true;
            lblItemCategory.Location = new Point(320, 46);
            lblItemCategory.Name = "lblItemCategory";
            lblItemCategory.Size = new Size(85, 15);
            lblItemCategory.TabIndex = 27;
            lblItemCategory.Text = "Item Category:";
            // 
            // cboItemCategory
            // 
            cboItemCategory.FormattingEnabled = true;
            cboItemCategory.Location = new Point(434, 43);
            cboItemCategory.Name = "cboItemCategory";
            cboItemCategory.Size = new Size(240, 23);
            cboItemCategory.TabIndex = 28;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "Price:";
            // 
            // lblIsCompanyProduced
            // 
            lblIsCompanyProduced.AutoSize = true;
            lblIsCompanyProduced.Location = new Point(326, 88);
            lblIsCompanyProduced.Name = "lblIsCompanyProduced";
            lblIsCompanyProduced.Size = new Size(118, 15);
            lblIsCompanyProduced.TabIndex = 30;
            lblIsCompanyProduced.Text = "Company Produced?";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(82, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 31;
            // 
            // cbxIsCompanyProduced
            // 
            cbxIsCompanyProduced.AutoSize = true;
            cbxIsCompanyProduced.Location = new Point(450, 89);
            cbxIsCompanyProduced.Name = "cbxIsCompanyProduced";
            cbxIsCompanyProduced.Size = new Size(15, 14);
            cbxIsCompanyProduced.TabIndex = 32;
            cbxIsCompanyProduced.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(58, 147);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(45, 15);
            lblDetails.TabIndex = 33;
            lblDetails.Text = "Details:";
            // 
            // CViewEntityItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 513);
            Controls.Add(lblDetails);
            Controls.Add(cbxIsCompanyProduced);
            Controls.Add(txtPrice);
            Controls.Add(lblIsCompanyProduced);
            Controls.Add(lblPrice);
            Controls.Add(cboItemCategory);
            Controls.Add(lblItemCategory);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            Controls.Add(btnDeleteDetail);
            Controls.Add(btnNewDetail);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMeasurementUnit);
            Controls.Add(cboMeasurementUnit);
            Controls.Add(dgvDetails);
            Name = "CViewEntityItem";
            Text = "CViewEntityAppUser";
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteDetail;
        private Button btnNewDetail;
        private Label lblName;
        private TextBox txtName;
        private Label lblMeasurementUnit;
        private ComboBox cboMeasurementUnit;
        private DataGridView dgvDetails;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblItemCategory;
        private ComboBox cboItemCategory;
        private Label lblPrice;
        private Label lblIsCompanyProduced;
        private TextBox txtPrice;
        private CheckBox cbxIsCompanyProduced;
        private Label lblDetails;
    }
}