namespace SalesManagementSystem.View
{
    partial class importDataBill
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
            this.invoiceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(235, 378);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(49, 20);
            this.btnImport.TabIndex = 20;
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
            this.cbbSheet.TabIndex = 19;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(786, 20);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sheet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "File Name:";
            // 
            // dgvImportData
            // 
            this.dgvImportData.AutoGenerateColumns = false;
            this.dgvImportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceidDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.cashieridDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn});
            this.dgvImportData.DataSource = this.billBindingSource;
            this.dgvImportData.Location = new System.Drawing.Point(12, 12);
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.Size = new System.Drawing.Size(898, 313);
            this.dgvImportData.TabIndex = 15;
            // 
            // invoiceidDataGridViewTextBoxColumn
            // 
            this.invoiceidDataGridViewTextBoxColumn.DataPropertyName = "Invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.HeaderText = "Invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.Name = "invoiceidDataGridViewTextBoxColumn";
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            // 
            // cashieridDataGridViewTextBoxColumn
            // 
            this.cashieridDataGridViewTextBoxColumn.DataPropertyName = "Cashier_id";
            this.cashieridDataGridViewTextBoxColumn.HeaderText = "Cashier_id";
            this.cashieridDataGridViewTextBoxColumn.Name = "cashieridDataGridViewTextBoxColumn";
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(SalesManagementSystem.Object.Bill);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(869, 344);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(41, 20);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // importDataBill
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
            this.Name = "importDataBill";
            this.Text = "importDataBill";
            this.Load += new System.EventHandler(this.importDataBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billBindingSource;
    }
}