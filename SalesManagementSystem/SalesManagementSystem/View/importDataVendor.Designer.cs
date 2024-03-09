namespace SalesManagementSystem.View
{
    partial class importDataVendor
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
            this.components = new System.ComponentModel.Container();
            this.btnImport = new System.Windows.Forms.Button();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvImportData = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.idVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(235, 378);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(49, 20);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(77, 377);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(143, 21);
            this.cbbSheet.TabIndex = 12;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(786, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sheet:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvImportData
            // 
            this.dgvImportData.AutoGenerateColumns = false;
            this.dgvImportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendorDataGridViewTextBoxColumn,
            this.nameVendorDataGridViewTextBoxColumn,
            this.codeVendorDataGridViewTextBoxColumn});
            this.dgvImportData.DataSource = this.vendorBindingSource;
            this.dgvImportData.Location = new System.Drawing.Point(12, 12);
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.Size = new System.Drawing.Size(898, 313);
            this.dgvImportData.TabIndex = 8;
            this.dgvImportData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportData_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(869, 344);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(41, 20);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // idVendorDataGridViewTextBoxColumn
            // 
            this.idVendorDataGridViewTextBoxColumn.DataPropertyName = "IdVendor";
            this.idVendorDataGridViewTextBoxColumn.HeaderText = "IdVendor";
            this.idVendorDataGridViewTextBoxColumn.Name = "idVendorDataGridViewTextBoxColumn";
            // 
            // nameVendorDataGridViewTextBoxColumn
            // 
            this.nameVendorDataGridViewTextBoxColumn.DataPropertyName = "NameVendor";
            this.nameVendorDataGridViewTextBoxColumn.HeaderText = "NameVendor";
            this.nameVendorDataGridViewTextBoxColumn.Name = "nameVendorDataGridViewTextBoxColumn";
            // 
            // codeVendorDataGridViewTextBoxColumn
            // 
            this.codeVendorDataGridViewTextBoxColumn.DataPropertyName = "CodeVendor";
            this.codeVendorDataGridViewTextBoxColumn.HeaderText = "CodeVendor";
            this.codeVendorDataGridViewTextBoxColumn.Name = "codeVendorDataGridViewTextBoxColumn";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(SalesManagementSystem.Object.Vendor);
            // 
            // importDataVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 428);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cbbSheet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvImportData);
            this.Controls.Add(this.btnExport);
            this.Name = "importDataVendor";
            this.Text = "importDataVendor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvImportData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendorBindingSource;
    }
}