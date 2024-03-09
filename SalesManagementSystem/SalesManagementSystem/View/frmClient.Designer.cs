namespace SalesManagementSystem.View
{
    partial class frmClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListClient = new System.Windows.Forms.DataGridView();
            this.btnCancelClient = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbScoreClient = new System.Windows.Forms.Label();
            this.txtScoreClient = new System.Windows.Forms.TextBox();
            this.lbEmailClient = new System.Windows.Forms.Label();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.cbbSexClient = new System.Windows.Forms.ComboBox();
            this.dtpYearClient = new System.Windows.Forms.DateTimePicker();
            this.lbHotlineClient = new System.Windows.Forms.Label();
            this.lbYearOfBirthClient = new System.Windows.Forms.Label();
            this.txtHotlineClient = new System.Windows.Forms.TextBox();
            this.txtAddressClient = new System.Windows.Forms.TextBox();
            this.lbAddressClient = new System.Windows.Forms.Label();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.lbNameClient = new System.Windows.Forms.Label();
            this.lbSexClient = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.btnExportClient = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListClient);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1227, 297);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Client";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvListClient
            // 
            this.dgvListClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClient.Location = new System.Drawing.Point(4, 29);
            this.dgvListClient.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListClient.Name = "dgvListClient";
            this.dgvListClient.Size = new System.Drawing.Size(1218, 312);
            this.dgvListClient.TabIndex = 0;
            this.dgvListClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmployees_CellContentClick);
            // 
            // btnCancelClient
            // 
            this.btnCancelClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelClient.Enabled = false;
            this.btnCancelClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClient.Location = new System.Drawing.Point(845, 193);
            this.btnCancelClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelClient.Name = "btnCancelClient";
            this.btnCancelClient.Size = new System.Drawing.Size(120, 124);
            this.btnCancelClient.TabIndex = 5;
            this.btnCancelClient.Text = "Cancel";
            this.btnCancelClient.UseVisualStyleBackColor = false;
            this.btnCancelClient.Click += new System.EventHandler(this.btnCancelClient_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveClient.Enabled = false;
            this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(670, 193);
            this.btnSaveClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(118, 124);
            this.btnSaveClient.TabIndex = 6;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteClient.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(488, 193);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(129, 124);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateClient.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(315, 193);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(132, 124);
            this.btnUpdateClient.TabIndex = 8;
            this.btnUpdateClient.Text = "Update";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddClient.BackColor = System.Drawing.Color.Aqua;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(142, 193);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(126, 124);
            this.btnAddClient.TabIndex = 9;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbScoreClient);
            this.groupBox1.Controls.Add(this.txtScoreClient);
            this.groupBox1.Controls.Add(this.lbEmailClient);
            this.groupBox1.Controls.Add(this.txtEmailClient);
            this.groupBox1.Controls.Add(this.cbbSexClient);
            this.groupBox1.Controls.Add(this.dtpYearClient);
            this.groupBox1.Controls.Add(this.lbHotlineClient);
            this.groupBox1.Controls.Add(this.lbYearOfBirthClient);
            this.groupBox1.Controls.Add(this.txtHotlineClient);
            this.groupBox1.Controls.Add(this.txtAddressClient);
            this.groupBox1.Controls.Add(this.lbAddressClient);
            this.groupBox1.Controls.Add(this.txtNameClient);
            this.groupBox1.Controls.Add(this.lbNameClient);
            this.groupBox1.Controls.Add(this.lbSexClient);
            this.groupBox1.Controls.Add(this.txtIdClient);
            this.groupBox1.Controls.Add(this.lbIDClient);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1222, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Client";
            // 
            // lbScoreClient
            // 
            this.lbScoreClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScoreClient.AutoSize = true;
            this.lbScoreClient.Location = new System.Drawing.Point(907, 120);
            this.lbScoreClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScoreClient.Name = "lbScoreClient";
            this.lbScoreClient.Size = new System.Drawing.Size(48, 19);
            this.lbScoreClient.TabIndex = 6;
            this.lbScoreClient.Text = "Score:";
            this.lbScoreClient.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtScoreClient
            // 
            this.txtScoreClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScoreClient.Enabled = false;
            this.txtScoreClient.Location = new System.Drawing.Point(1007, 113);
            this.txtScoreClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreClient.MaxLength = 11;
            this.txtScoreClient.Name = "txtScoreClient";
            this.txtScoreClient.Size = new System.Drawing.Size(189, 26);
            this.txtScoreClient.TabIndex = 7;
            this.txtScoreClient.TextChanged += new System.EventHandler(this.txtScoreClient_TextChanged);
            this.txtScoreClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScoreClient_KeyPress);
            // 
            // lbEmailClient
            // 
            this.lbEmailClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmailClient.AutoSize = true;
            this.lbEmailClient.Location = new System.Drawing.Point(907, 43);
            this.lbEmailClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailClient.Name = "lbEmailClient";
            this.lbEmailClient.Size = new System.Drawing.Size(45, 19);
            this.lbEmailClient.TabIndex = 4;
            this.lbEmailClient.Text = "Email:";
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailClient.Enabled = false;
            this.txtEmailClient.Location = new System.Drawing.Point(1007, 39);
            this.txtEmailClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailClient.MaxLength = 30;
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(189, 26);
            this.txtEmailClient.TabIndex = 5;
            // 
            // cbbSexClient
            // 
            this.cbbSexClient.Enabled = false;
            this.cbbSexClient.FormattingEnabled = true;
            this.cbbSexClient.Location = new System.Drawing.Point(81, 112);
            this.cbbSexClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSexClient.Name = "cbbSexClient";
            this.cbbSexClient.Size = new System.Drawing.Size(146, 27);
            this.cbbSexClient.TabIndex = 3;
            // 
            // dtpYearClient
            // 
            this.dtpYearClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpYearClient.Enabled = false;
            this.dtpYearClient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearClient.Location = new System.Drawing.Point(682, 39);
            this.dtpYearClient.Margin = new System.Windows.Forms.Padding(4);
            this.dtpYearClient.Name = "dtpYearClient";
            this.dtpYearClient.Size = new System.Drawing.Size(189, 26);
            this.dtpYearClient.TabIndex = 2;
            this.dtpYearClient.ValueChanged += new System.EventHandler(this.dtpYearEmployees_ValueChanged);
            // 
            // lbHotlineClient
            // 
            this.lbHotlineClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHotlineClient.AutoSize = true;
            this.lbHotlineClient.Location = new System.Drawing.Point(581, 120);
            this.lbHotlineClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHotlineClient.Name = "lbHotlineClient";
            this.lbHotlineClient.Size = new System.Drawing.Size(55, 19);
            this.lbHotlineClient.TabIndex = 0;
            this.lbHotlineClient.Text = "Hotline:";
            this.lbHotlineClient.Click += new System.EventHandler(this.lbHotlineEmployees_Click);
            // 
            // lbYearOfBirthClient
            // 
            this.lbYearOfBirthClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYearOfBirthClient.AutoSize = true;
            this.lbYearOfBirthClient.Location = new System.Drawing.Point(581, 43);
            this.lbYearOfBirthClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYearOfBirthClient.Name = "lbYearOfBirthClient";
            this.lbYearOfBirthClient.Size = new System.Drawing.Size(93, 19);
            this.lbYearOfBirthClient.TabIndex = 0;
            this.lbYearOfBirthClient.Text = "Year Of Birth:";
            // 
            // txtHotlineClient
            // 
            this.txtHotlineClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotlineClient.Enabled = false;
            this.txtHotlineClient.Location = new System.Drawing.Point(682, 113);
            this.txtHotlineClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotlineClient.MaxLength = 11;
            this.txtHotlineClient.Name = "txtHotlineClient";
            this.txtHotlineClient.Size = new System.Drawing.Size(189, 26);
            this.txtHotlineClient.TabIndex = 1;
            this.txtHotlineClient.TextChanged += new System.EventHandler(this.txtHotlineClient_TextChanged);
            this.txtHotlineClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotlineClient_KeyPress);
            // 
            // txtAddressClient
            // 
            this.txtAddressClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressClient.Enabled = false;
            this.txtAddressClient.Location = new System.Drawing.Point(352, 113);
            this.txtAddressClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressClient.Name = "txtAddressClient";
            this.txtAddressClient.Size = new System.Drawing.Size(200, 26);
            this.txtAddressClient.TabIndex = 1;
            // 
            // lbAddressClient
            // 
            this.lbAddressClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddressClient.AutoSize = true;
            this.lbAddressClient.Location = new System.Drawing.Point(256, 120);
            this.lbAddressClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddressClient.Name = "lbAddressClient";
            this.lbAddressClient.Size = new System.Drawing.Size(63, 19);
            this.lbAddressClient.TabIndex = 0;
            this.lbAddressClient.Text = "Address:";
            // 
            // txtNameClient
            // 
            this.txtNameClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameClient.Enabled = false;
            this.txtNameClient.Location = new System.Drawing.Point(352, 39);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(200, 26);
            this.txtNameClient.TabIndex = 1;
            // 
            // lbNameClient
            // 
            this.lbNameClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.Location = new System.Drawing.Point(256, 43);
            this.lbNameClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(88, 19);
            this.lbNameClient.TabIndex = 0;
            this.lbNameClient.Text = "Name Client:";
            this.lbNameClient.Click += new System.EventHandler(this.lbNameEmployees_Click);
            // 
            // lbSexClient
            // 
            this.lbSexClient.AutoSize = true;
            this.lbSexClient.Location = new System.Drawing.Point(9, 120);
            this.lbSexClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexClient.Name = "lbSexClient";
            this.lbSexClient.Size = new System.Drawing.Size(35, 19);
            this.lbSexClient.TabIndex = 0;
            this.lbSexClient.Text = "Sex:";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Enabled = false;
            this.txtIdClient.Location = new System.Drawing.Point(81, 39);
            this.txtIdClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(146, 26);
            this.txtIdClient.TabIndex = 1;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(9, 43);
            this.lbIDClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(64, 19);
            this.lbIDClient.TabIndex = 0;
            this.lbIDClient.Text = "Id Client:";
            // 
            // btnExportClient
            // 
            this.btnExportClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportClient.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExportClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportClient.Location = new System.Drawing.Point(1020, 194);
            this.btnExportClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportClient.Name = "btnExportClient";
            this.btnExportClient.Size = new System.Drawing.Size(120, 124);
            this.btnExportClient.TabIndex = 10;
            this.btnExportClient.Text = "Import";
            this.btnExportClient.UseVisualStyleBackColor = false;
            this.btnExportClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.btnExportClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelClient);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListClient;
        private System.Windows.Forms.Button btnCancelClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbSexClient;
        private System.Windows.Forms.DateTimePicker dtpYearClient;
        private System.Windows.Forms.Label lbHotlineClient;
        private System.Windows.Forms.Label lbYearOfBirthClient;
        private System.Windows.Forms.TextBox txtHotlineClient;
        private System.Windows.Forms.TextBox txtAddressClient;
        private System.Windows.Forms.Label lbAddressClient;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.Label lbSexClient;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label lbIDClient;
        private System.Windows.Forms.Label lbScoreClient;
        private System.Windows.Forms.TextBox txtScoreClient;
        private System.Windows.Forms.Label lbEmailClient;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.Button btnExportClient;
    }
}