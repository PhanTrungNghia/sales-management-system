namespace SalesManagementSystem.View
{
    partial class importDataClient
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
            this.btnExport = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.dgvImportData = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotlineClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(869, 344);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(41, 20);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "ofdExcel";
            // 
            // dgvImportData
            // 
            this.dgvImportData.AutoGenerateColumns = false;
            this.dgvImportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn,
            this.sexClientDataGridViewTextBoxColumn,
            this.addressClientDataGridViewTextBoxColumn,
            this.hotlineClientDataGridViewTextBoxColumn,
            this.scoreClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.yearOfBirthClientDataGridViewTextBoxColumn});
            this.dgvImportData.DataSource = this.clientBindingSource;
            this.dgvImportData.Location = new System.Drawing.Point(12, 12);
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.Size = new System.Drawing.Size(898, 313);
            this.dgvImportData.TabIndex = 1;
            this.dgvImportData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportData_CellContentClick);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // nameClientDataGridViewTextBoxColumn
            // 
            this.nameClientDataGridViewTextBoxColumn.DataPropertyName = "NameClient";
            this.nameClientDataGridViewTextBoxColumn.HeaderText = "NameClient";
            this.nameClientDataGridViewTextBoxColumn.Name = "nameClientDataGridViewTextBoxColumn";
            // 
            // sexClientDataGridViewTextBoxColumn
            // 
            this.sexClientDataGridViewTextBoxColumn.DataPropertyName = "SexClient";
            this.sexClientDataGridViewTextBoxColumn.HeaderText = "SexClient";
            this.sexClientDataGridViewTextBoxColumn.Name = "sexClientDataGridViewTextBoxColumn";
            // 
            // addressClientDataGridViewTextBoxColumn
            // 
            this.addressClientDataGridViewTextBoxColumn.DataPropertyName = "AddressClient";
            this.addressClientDataGridViewTextBoxColumn.HeaderText = "AddressClient";
            this.addressClientDataGridViewTextBoxColumn.Name = "addressClientDataGridViewTextBoxColumn";
            // 
            // hotlineClientDataGridViewTextBoxColumn
            // 
            this.hotlineClientDataGridViewTextBoxColumn.DataPropertyName = "HotlineClient";
            this.hotlineClientDataGridViewTextBoxColumn.HeaderText = "HotlineClient";
            this.hotlineClientDataGridViewTextBoxColumn.Name = "hotlineClientDataGridViewTextBoxColumn";
            // 
            // scoreClientDataGridViewTextBoxColumn
            // 
            this.scoreClientDataGridViewTextBoxColumn.DataPropertyName = "ScoreClient";
            this.scoreClientDataGridViewTextBoxColumn.HeaderText = "ScoreClient";
            this.scoreClientDataGridViewTextBoxColumn.Name = "scoreClientDataGridViewTextBoxColumn";
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "EmailClient";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "EmailClient";
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            // 
            // yearOfBirthClientDataGridViewTextBoxColumn
            // 
            this.yearOfBirthClientDataGridViewTextBoxColumn.DataPropertyName = "YearOfBirthClient";
            this.yearOfBirthClientDataGridViewTextBoxColumn.HeaderText = "YearOfBirthClient";
            this.yearOfBirthClientDataGridViewTextBoxColumn.Name = "yearOfBirthClientDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(SalesManagementSystem.Object.Client);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sheet:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(786, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(77, 377);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(143, 21);
            this.cbbSheet.TabIndex = 5;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(235, 378);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(49, 20);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // importDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(922, 428);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cbbSheet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvImportData);
            this.Controls.Add(this.btnExport);
            this.Name = "importDataClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "importData";
            this.Load += new System.EventHandler(this.importDataClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.DataGridView dgvImportData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotlineClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthClientDataGridViewTextBoxColumn;
    }
}