namespace SalesManagementSystem.View
{
    partial class importDataEmployees
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
            this.idEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotlineEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sheet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Name:";
            // 
            // dgvImportData
            // 
            this.dgvImportData.AutoGenerateColumns = false;
            this.dgvImportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmployeesDataGridViewTextBoxColumn,
            this.nameEmployeesDataGridViewTextBoxColumn,
            this.sexEmployeesDataGridViewTextBoxColumn,
            this.addressEmployeesDataGridViewTextBoxColumn,
            this.hotlineEmployeesDataGridViewTextBoxColumn,
            this.passwordEmployeesDataGridViewTextBoxColumn,
            this.yearOfBirthEmployeesDataGridViewTextBoxColumn,
            this.salaryEmployeesDataGridViewTextBoxColumn,
            this.emailEmployeesDataGridViewTextBoxColumn});
            this.dgvImportData.DataSource = this.employeesBindingSource;
            this.dgvImportData.Location = new System.Drawing.Point(12, 12);
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.Size = new System.Drawing.Size(898, 313);
            this.dgvImportData.TabIndex = 8;
            // 
            // idEmployeesDataGridViewTextBoxColumn
            // 
            this.idEmployeesDataGridViewTextBoxColumn.DataPropertyName = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.HeaderText = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.Name = "idEmployeesDataGridViewTextBoxColumn";
            // 
            // nameEmployeesDataGridViewTextBoxColumn
            // 
            this.nameEmployeesDataGridViewTextBoxColumn.DataPropertyName = "NameEmployees";
            this.nameEmployeesDataGridViewTextBoxColumn.HeaderText = "NameEmployees";
            this.nameEmployeesDataGridViewTextBoxColumn.Name = "nameEmployeesDataGridViewTextBoxColumn";
            // 
            // sexEmployeesDataGridViewTextBoxColumn
            // 
            this.sexEmployeesDataGridViewTextBoxColumn.DataPropertyName = "SexEmployees";
            this.sexEmployeesDataGridViewTextBoxColumn.HeaderText = "SexEmployees";
            this.sexEmployeesDataGridViewTextBoxColumn.Name = "sexEmployeesDataGridViewTextBoxColumn";
            // 
            // addressEmployeesDataGridViewTextBoxColumn
            // 
            this.addressEmployeesDataGridViewTextBoxColumn.DataPropertyName = "AddressEmployees";
            this.addressEmployeesDataGridViewTextBoxColumn.HeaderText = "AddressEmployees";
            this.addressEmployeesDataGridViewTextBoxColumn.Name = "addressEmployeesDataGridViewTextBoxColumn";
            // 
            // hotlineEmployeesDataGridViewTextBoxColumn
            // 
            this.hotlineEmployeesDataGridViewTextBoxColumn.DataPropertyName = "HotlineEmployees";
            this.hotlineEmployeesDataGridViewTextBoxColumn.HeaderText = "HotlineEmployees";
            this.hotlineEmployeesDataGridViewTextBoxColumn.Name = "hotlineEmployeesDataGridViewTextBoxColumn";
            // 
            // passwordEmployeesDataGridViewTextBoxColumn
            // 
            this.passwordEmployeesDataGridViewTextBoxColumn.DataPropertyName = "PasswordEmployees";
            this.passwordEmployeesDataGridViewTextBoxColumn.HeaderText = "PasswordEmployees";
            this.passwordEmployeesDataGridViewTextBoxColumn.Name = "passwordEmployeesDataGridViewTextBoxColumn";
            // 
            // yearOfBirthEmployeesDataGridViewTextBoxColumn
            // 
            this.yearOfBirthEmployeesDataGridViewTextBoxColumn.DataPropertyName = "YearOfBirthEmployees";
            this.yearOfBirthEmployeesDataGridViewTextBoxColumn.HeaderText = "YearOfBirthEmployees";
            this.yearOfBirthEmployeesDataGridViewTextBoxColumn.Name = "yearOfBirthEmployeesDataGridViewTextBoxColumn";
            // 
            // salaryEmployeesDataGridViewTextBoxColumn
            // 
            this.salaryEmployeesDataGridViewTextBoxColumn.DataPropertyName = "SalaryEmployees";
            this.salaryEmployeesDataGridViewTextBoxColumn.HeaderText = "SalaryEmployees";
            this.salaryEmployeesDataGridViewTextBoxColumn.Name = "salaryEmployeesDataGridViewTextBoxColumn";
            // 
            // emailEmployeesDataGridViewTextBoxColumn
            // 
            this.emailEmployeesDataGridViewTextBoxColumn.DataPropertyName = "EmailEmployees";
            this.emailEmployeesDataGridViewTextBoxColumn.HeaderText = "EmailEmployees";
            this.emailEmployeesDataGridViewTextBoxColumn.Name = "emailEmployeesDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(SalesManagementSystem.Object.Employees);
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
            // importDataEmployees
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
            this.Name = "importDataEmployees";
            this.Text = "importDataEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotlineEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}