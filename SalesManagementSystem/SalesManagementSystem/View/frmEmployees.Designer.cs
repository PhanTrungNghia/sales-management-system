namespace SalesManagementSystem.View
{
    partial class frmEmployees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSexEmployees = new System.Windows.Forms.ComboBox();
            this.dtpYearEmployees = new System.Windows.Forms.DateTimePicker();
            this.lbHotlineEmployees = new System.Windows.Forms.Label();
            this.lbYearOfBirthEmployees = new System.Windows.Forms.Label();
            this.txtHotlineEmployees = new System.Windows.Forms.TextBox();
            this.txtAddressEmployees = new System.Windows.Forms.TextBox();
            this.lbAddressEmployees = new System.Windows.Forms.Label();
            this.txtNameEmployees = new System.Windows.Forms.TextBox();
            this.lbNameEmployees = new System.Windows.Forms.Label();
            this.lbSexEmployees = new System.Windows.Forms.Label();
            this.txtIdEmployees = new System.Windows.Forms.TextBox();
            this.lbIDEmployees = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListEmployees = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbSexEmployees);
            this.groupBox1.Controls.Add(this.dtpYearEmployees);
            this.groupBox1.Controls.Add(this.lbHotlineEmployees);
            this.groupBox1.Controls.Add(this.lbYearOfBirthEmployees);
            this.groupBox1.Controls.Add(this.txtHotlineEmployees);
            this.groupBox1.Controls.Add(this.txtAddressEmployees);
            this.groupBox1.Controls.Add(this.lbAddressEmployees);
            this.groupBox1.Controls.Add(this.txtNameEmployees);
            this.groupBox1.Controls.Add(this.lbNameEmployees);
            this.groupBox1.Controls.Add(this.lbSexEmployees);
            this.groupBox1.Controls.Add(this.txtIdEmployees);
            this.groupBox1.Controls.Add(this.lbIDEmployees);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1218, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Employees";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbSexEmployees
            // 
            this.cbbSexEmployees.Enabled = false;
            this.cbbSexEmployees.FormattingEnabled = true;
            this.cbbSexEmployees.Location = new System.Drawing.Point(184, 114);
            this.cbbSexEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSexEmployees.Name = "cbbSexEmployees";
            this.cbbSexEmployees.Size = new System.Drawing.Size(223, 27);
            this.cbbSexEmployees.TabIndex = 3;
            // 
            // dtpYearEmployees
            // 
            this.dtpYearEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpYearEmployees.Enabled = false;
            this.dtpYearEmployees.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearEmployees.Location = new System.Drawing.Point(965, 37);
            this.dtpYearEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dtpYearEmployees.Name = "dtpYearEmployees";
            this.dtpYearEmployees.Size = new System.Drawing.Size(223, 26);
            this.dtpYearEmployees.TabIndex = 2;
            // 
            // lbHotlineEmployees
            // 
            this.lbHotlineEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHotlineEmployees.AutoSize = true;
            this.lbHotlineEmployees.Location = new System.Drawing.Point(821, 120);
            this.lbHotlineEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHotlineEmployees.Name = "lbHotlineEmployees";
            this.lbHotlineEmployees.Size = new System.Drawing.Size(55, 19);
            this.lbHotlineEmployees.TabIndex = 0;
            this.lbHotlineEmployees.Text = "Hotline:";
            this.lbHotlineEmployees.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbYearOfBirthEmployees
            // 
            this.lbYearOfBirthEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYearOfBirthEmployees.AutoSize = true;
            this.lbYearOfBirthEmployees.Location = new System.Drawing.Point(821, 42);
            this.lbYearOfBirthEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYearOfBirthEmployees.Name = "lbYearOfBirthEmployees";
            this.lbYearOfBirthEmployees.Size = new System.Drawing.Size(93, 19);
            this.lbYearOfBirthEmployees.TabIndex = 0;
            this.lbYearOfBirthEmployees.Text = "Year Of Birth:";
            this.lbYearOfBirthEmployees.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtHotlineEmployees
            // 
            this.txtHotlineEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotlineEmployees.Enabled = false;
            this.txtHotlineEmployees.Location = new System.Drawing.Point(965, 114);
            this.txtHotlineEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotlineEmployees.Name = "txtHotlineEmployees";
            this.txtHotlineEmployees.Size = new System.Drawing.Size(223, 26);
            this.txtHotlineEmployees.TabIndex = 1;
            this.txtHotlineEmployees.TextChanged += new System.EventHandler(this.txtHotlineEmployees_TextChanged);
            this.txtHotlineEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotlineEmployees_KeyPress);
            // 
            // txtAddressEmployees
            // 
            this.txtAddressEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressEmployees.Enabled = false;
            this.txtAddressEmployees.Location = new System.Drawing.Point(596, 114);
            this.txtAddressEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressEmployees.Name = "txtAddressEmployees";
            this.txtAddressEmployees.Size = new System.Drawing.Size(214, 26);
            this.txtAddressEmployees.TabIndex = 1;
            // 
            // lbAddressEmployees
            // 
            this.lbAddressEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddressEmployees.AutoSize = true;
            this.lbAddressEmployees.Location = new System.Drawing.Point(418, 120);
            this.lbAddressEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddressEmployees.Name = "lbAddressEmployees";
            this.lbAddressEmployees.Size = new System.Drawing.Size(63, 19);
            this.lbAddressEmployees.TabIndex = 0;
            this.lbAddressEmployees.Text = "Address:";
            this.lbAddressEmployees.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNameEmployees
            // 
            this.txtNameEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEmployees.Enabled = false;
            this.txtNameEmployees.Location = new System.Drawing.Point(596, 37);
            this.txtNameEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameEmployees.Name = "txtNameEmployees";
            this.txtNameEmployees.Size = new System.Drawing.Size(214, 26);
            this.txtNameEmployees.TabIndex = 1;
            // 
            // lbNameEmployees
            // 
            this.lbNameEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameEmployees.AutoSize = true;
            this.lbNameEmployees.Location = new System.Drawing.Point(418, 42);
            this.lbNameEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameEmployees.Name = "lbNameEmployees";
            this.lbNameEmployees.Size = new System.Drawing.Size(119, 19);
            this.lbNameEmployees.TabIndex = 0;
            this.lbNameEmployees.Text = "Name Employees:";
            this.lbNameEmployees.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSexEmployees
            // 
            this.lbSexEmployees.AutoSize = true;
            this.lbSexEmployees.Location = new System.Drawing.Point(38, 120);
            this.lbSexEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexEmployees.Name = "lbSexEmployees";
            this.lbSexEmployees.Size = new System.Drawing.Size(35, 19);
            this.lbSexEmployees.TabIndex = 0;
            this.lbSexEmployees.Text = "Sex:";
            this.lbSexEmployees.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdEmployees
            // 
            this.txtIdEmployees.Enabled = false;
            this.txtIdEmployees.Location = new System.Drawing.Point(184, 37);
            this.txtIdEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmployees.Name = "txtIdEmployees";
            this.txtIdEmployees.Size = new System.Drawing.Size(223, 26);
            this.txtIdEmployees.TabIndex = 1;
            // 
            // lbIDEmployees
            // 
            this.lbIDEmployees.AutoSize = true;
            this.lbIDEmployees.Location = new System.Drawing.Point(38, 42);
            this.lbIDEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDEmployees.Name = "lbIDEmployees";
            this.lbIDEmployees.Size = new System.Drawing.Size(95, 19);
            this.lbIDEmployees.TabIndex = 0;
            this.lbIDEmployees.Text = "Id Employees:";
            this.lbIDEmployees.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListEmployees);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1223, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Employees";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListEmployees.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployees.Location = new System.Drawing.Point(4, 29);
            this.dgvListEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.Size = new System.Drawing.Size(1214, 260);
            this.dgvListEmployees.TabIndex = 0;
            this.dgvListEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmployees_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(136, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 124);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(309, 210);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 124);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Cyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(482, 210);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 124);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(656, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 124);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(829, 210);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 124);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(995, 211);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 124);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Import";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 684);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbYearOfBirthEmployees;
        private System.Windows.Forms.TextBox txtNameEmployees;
        private System.Windows.Forms.Label lbNameEmployees;
        private System.Windows.Forms.TextBox txtIdEmployees;
        private System.Windows.Forms.Label lbIDEmployees;
        private System.Windows.Forms.DataGridView dgvListEmployees;
        private System.Windows.Forms.DateTimePicker dtpYearEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbSexEmployees;
        private System.Windows.Forms.Label lbHotlineEmployees;
        private System.Windows.Forms.TextBox txtHotlineEmployees;
        private System.Windows.Forms.TextBox txtAddressEmployees;
        private System.Windows.Forms.Label lbAddressEmployees;
        private System.Windows.Forms.Label lbSexEmployees;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnExport;
    }
}