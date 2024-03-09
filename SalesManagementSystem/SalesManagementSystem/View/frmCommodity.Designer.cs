namespace SalesManagementSystem.View
{
    partial class frmCommodity
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListCommodity = new System.Windows.Forms.DataGridView();
            this.btnAddCommodity = new System.Windows.Forms.Button();
            this.btnUpdCommodity = new System.Windows.Forms.Button();
            this.btnDelCommodity = new System.Windows.Forms.Button();
            this.btnSaveCommodity = new System.Windows.Forms.Button();
            this.txtNameCommodity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancelCommodity = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantityCommodity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIdCommodity = new System.Windows.Forms.Label();
            this.txtCostCommodity = new System.Windows.Forms.TextBox();
            this.txtIdCommodity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeCommodity = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdVendor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btnExportVendor = new System.Windows.Forms.Button();
            this.btnCancelVendor = new System.Windows.Forms.Button();
            this.btnDelVendor = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.btnUpdVendor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodeVendor = new System.Windows.Forms.TextBox();
            this.txtNameVendor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commodity Name:";
            // 
            // dgvListCommodity
            // 
            this.dgvListCommodity.AllowUserToAddRows = false;
            this.dgvListCommodity.AllowUserToDeleteRows = false;
            this.dgvListCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCommodity.Location = new System.Drawing.Point(3, 22);
            this.dgvListCommodity.Name = "dgvListCommodity";
            this.dgvListCommodity.ReadOnly = true;
            this.dgvListCommodity.Size = new System.Drawing.Size(583, 191);
            this.dgvListCommodity.TabIndex = 6;
            // 
            // btnAddCommodity
            // 
            this.btnAddCommodity.BackColor = System.Drawing.Color.Aqua;
            this.btnAddCommodity.Location = new System.Drawing.Point(18, 34);
            this.btnAddCommodity.Name = "btnAddCommodity";
            this.btnAddCommodity.Size = new System.Drawing.Size(75, 52);
            this.btnAddCommodity.TabIndex = 2;
            this.btnAddCommodity.Text = "Add";
            this.btnAddCommodity.UseVisualStyleBackColor = false;
            this.btnAddCommodity.Click += new System.EventHandler(this.btnAddCommodity_Click);
            // 
            // btnUpdCommodity
            // 
            this.btnUpdCommodity.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdCommodity.Location = new System.Drawing.Point(110, 34);
            this.btnUpdCommodity.Name = "btnUpdCommodity";
            this.btnUpdCommodity.Size = new System.Drawing.Size(75, 52);
            this.btnUpdCommodity.TabIndex = 3;
            this.btnUpdCommodity.Text = "Update";
            this.btnUpdCommodity.UseVisualStyleBackColor = false;
            this.btnUpdCommodity.Click += new System.EventHandler(this.btnUpdCommodity_Click);
            // 
            // btnDelCommodity
            // 
            this.btnDelCommodity.BackColor = System.Drawing.Color.Aqua;
            this.btnDelCommodity.Location = new System.Drawing.Point(203, 34);
            this.btnDelCommodity.Name = "btnDelCommodity";
            this.btnDelCommodity.Size = new System.Drawing.Size(75, 52);
            this.btnDelCommodity.TabIndex = 4;
            this.btnDelCommodity.Text = "Delete";
            this.btnDelCommodity.UseVisualStyleBackColor = false;
            this.btnDelCommodity.Click += new System.EventHandler(this.btnDelCommodity_Click);
            // 
            // btnSaveCommodity
            // 
            this.btnSaveCommodity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveCommodity.Location = new System.Drawing.Point(294, 34);
            this.btnSaveCommodity.Name = "btnSaveCommodity";
            this.btnSaveCommodity.Size = new System.Drawing.Size(75, 52);
            this.btnSaveCommodity.TabIndex = 5;
            this.btnSaveCommodity.Text = "Save";
            this.btnSaveCommodity.UseVisualStyleBackColor = false;
            this.btnSaveCommodity.Click += new System.EventHandler(this.btnCancelCommodity_Click);
            // 
            // txtNameCommodity
            // 
            this.txtNameCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameCommodity.Location = new System.Drawing.Point(155, 17);
            this.txtNameCommodity.Name = "txtNameCommodity";
            this.txtNameCommodity.Size = new System.Drawing.Size(146, 26);
            this.txtNameCommodity.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnCancelCommodity);
            this.groupBox1.Controls.Add(this.btnDelCommodity);
            this.groupBox1.Controls.Add(this.btnAddCommodity);
            this.groupBox1.Controls.Add(this.btnSaveCommodity);
            this.groupBox1.Controls.Add(this.btnUpdCommodity);
            this.groupBox1.Location = new System.Drawing.Point(21, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExport.Location = new System.Drawing.Point(480, 34);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 52);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Import";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancelCommodity
            // 
            this.btnCancelCommodity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelCommodity.Location = new System.Drawing.Point(386, 34);
            this.btnCancelCommodity.Name = "btnCancelCommodity";
            this.btnCancelCommodity.Size = new System.Drawing.Size(75, 52);
            this.btnCancelCommodity.TabIndex = 6;
            this.btnCancelCommodity.Text = "Cancel";
            this.btnCancelCommodity.UseVisualStyleBackColor = false;
            this.btnCancelCommodity.Click += new System.EventHandler(this.btnCancelCommodity_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListCommodity);
            this.groupBox2.Location = new System.Drawing.Point(18, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commodity List";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQuantityCommodity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbIdCommodity);
            this.groupBox3.Controls.Add(this.txtCostCommodity);
            this.groupBox3.Controls.Add(this.txtIdCommodity);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtCodeCommodity);
            this.groupBox3.Controls.Add(this.txtNameCommodity);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 538);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Commodity Quantity";
            // 
            // txtQuantityCommodity
            // 
            this.txtQuantityCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityCommodity.Location = new System.Drawing.Point(155, 123);
            this.txtQuantityCommodity.Name = "txtQuantityCommodity";
            this.txtQuantityCommodity.Size = new System.Drawing.Size(146, 26);
            this.txtQuantityCommodity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Commodity Cost";
            // 
            // lbIdCommodity
            // 
            this.lbIdCommodity.AutoSize = true;
            this.lbIdCommodity.Location = new System.Drawing.Point(338, 21);
            this.lbIdCommodity.Name = "lbIdCommodity";
            this.lbIdCommodity.Size = new System.Drawing.Size(97, 19);
            this.lbIdCommodity.TabIndex = 9;
            this.lbIdCommodity.Text = "Commodity Id";
            // 
            // txtCostCommodity
            // 
            this.txtCostCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostCommodity.Location = new System.Drawing.Point(457, 66);
            this.txtCostCommodity.Name = "txtCostCommodity";
            this.txtCostCommodity.Size = new System.Drawing.Size(149, 26);
            this.txtCostCommodity.TabIndex = 10;
            // 
            // txtIdCommodity
            // 
            this.txtIdCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCommodity.Location = new System.Drawing.Point(457, 17);
            this.txtIdCommodity.Name = "txtIdCommodity";
            this.txtIdCommodity.Size = new System.Drawing.Size(149, 26);
            this.txtIdCommodity.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Commodity Code:";
            // 
            // txtCodeCommodity
            // 
            this.txtCodeCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeCommodity.Location = new System.Drawing.Point(155, 66);
            this.txtCodeCommodity.Name = "txtCodeCommodity";
            this.txtCodeCommodity.Size = new System.Drawing.Size(146, 26);
            this.txtCodeCommodity.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtIdVendor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.gbFunction);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtCodeVendor);
            this.groupBox4.Controls.Add(this.txtNameVendor);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(661, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 538);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vendor Id";
            // 
            // txtIdVendor
            // 
            this.txtIdVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdVendor.Location = new System.Drawing.Point(378, 32);
            this.txtIdVendor.Name = "txtIdVendor";
            this.txtIdVendor.Size = new System.Drawing.Size(171, 26);
            this.txtIdVendor.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vendor Code:";
            // 
            // gbFunction
            // 
            this.gbFunction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFunction.Controls.Add(this.btnExportVendor);
            this.gbFunction.Controls.Add(this.btnCancelVendor);
            this.gbFunction.Controls.Add(this.btnDelVendor);
            this.gbFunction.Controls.Add(this.btnAddVendor);
            this.gbFunction.Controls.Add(this.btnSaveVendor);
            this.gbFunction.Controls.Add(this.btnUpdVendor);
            this.gbFunction.Location = new System.Drawing.Point(18, 404);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(539, 116);
            this.gbFunction.TabIndex = 7;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Function";
            // 
            // btnExportVendor
            // 
            this.btnExportVendor.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExportVendor.Location = new System.Drawing.Point(441, 34);
            this.btnExportVendor.Name = "btnExportVendor";
            this.btnExportVendor.Size = new System.Drawing.Size(75, 52);
            this.btnExportVendor.TabIndex = 7;
            this.btnExportVendor.Text = "Import";
            this.btnExportVendor.UseVisualStyleBackColor = false;
            this.btnExportVendor.Click += new System.EventHandler(this.btnExportVendor_Click);
            // 
            // btnCancelVendor
            // 
            this.btnCancelVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelVendor.Location = new System.Drawing.Point(360, 34);
            this.btnCancelVendor.Name = "btnCancelVendor";
            this.btnCancelVendor.Size = new System.Drawing.Size(75, 52);
            this.btnCancelVendor.TabIndex = 6;
            this.btnCancelVendor.Text = "Cancel";
            this.btnCancelVendor.UseVisualStyleBackColor = false;
            this.btnCancelVendor.Click += new System.EventHandler(this.btnCancelVendor_Click);
            // 
            // btnDelVendor
            // 
            this.btnDelVendor.BackColor = System.Drawing.Color.Aqua;
            this.btnDelVendor.Location = new System.Drawing.Point(182, 34);
            this.btnDelVendor.Name = "btnDelVendor";
            this.btnDelVendor.Size = new System.Drawing.Size(75, 52);
            this.btnDelVendor.TabIndex = 4;
            this.btnDelVendor.Text = "Delete";
            this.btnDelVendor.UseVisualStyleBackColor = false;
            this.btnDelVendor.Click += new System.EventHandler(this.btnDelVendor_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.BackColor = System.Drawing.Color.Aqua;
            this.btnAddVendor.Location = new System.Drawing.Point(13, 34);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(75, 52);
            this.btnAddVendor.TabIndex = 2;
            this.btnAddVendor.Text = "Add";
            this.btnAddVendor.UseVisualStyleBackColor = false;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveVendor.Location = new System.Drawing.Point(267, 34);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(75, 52);
            this.btnSaveVendor.TabIndex = 5;
            this.btnSaveVendor.Text = "Save";
            this.btnSaveVendor.UseVisualStyleBackColor = false;
            this.btnSaveVendor.Click += new System.EventHandler(this.btnSaveVendor_Click);
            // 
            // btnUpdVendor
            // 
            this.btnUpdVendor.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdVendor.Location = new System.Drawing.Point(99, 34);
            this.btnUpdVendor.Name = "btnUpdVendor";
            this.btnUpdVendor.Size = new System.Drawing.Size(75, 52);
            this.btnUpdVendor.TabIndex = 3;
            this.btnUpdVendor.Text = "Update";
            this.btnUpdVendor.UseVisualStyleBackColor = false;
            this.btnUpdVendor.Click += new System.EventHandler(this.btnUpdVendor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vendor Name:";
            // 
            // txtCodeVendor
            // 
            this.txtCodeVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeVendor.Location = new System.Drawing.Point(117, 80);
            this.txtCodeVendor.Name = "txtCodeVendor";
            this.txtCodeVendor.Size = new System.Drawing.Size(158, 26);
            this.txtCodeVendor.TabIndex = 13;
            // 
            // txtNameVendor
            // 
            this.txtNameVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameVendor.Location = new System.Drawing.Point(117, 32);
            this.txtNameVendor.Name = "txtNameVendor";
            this.txtNameVendor.Size = new System.Drawing.Size(158, 26);
            this.txtNameVendor.TabIndex = 14;
            this.txtNameVendor.TextChanged += new System.EventHandler(this.txtNameVendor_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgvVendor);
            this.groupBox5.Location = new System.Drawing.Point(18, 167);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(531, 216);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vendor List";
            // 
            // dgvVendor
            // 
            this.dgvVendor.AllowUserToAddRows = false;
            this.dgvVendor.AllowUserToDeleteRows = false;
            this.dgvVendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendor.Location = new System.Drawing.Point(3, 22);
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.ReadOnly = true;
            this.dgvVendor.Size = new System.Drawing.Size(525, 191);
            this.dgvVendor.TabIndex = 6;
            this.dgvVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendor_CellContentClick);
            // 
            // frmCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1248, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCommodity";
            this.Text = "frmCommonity&Vendor";
            this.Load += new System.EventHandler(this.frmCommonity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbFunction.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListCommodity;
        private System.Windows.Forms.Button btnAddCommodity;
        private System.Windows.Forms.Button btnUpdCommodity;
        private System.Windows.Forms.Button btnDelCommodity;
        private System.Windows.Forms.Button btnSaveCommodity;
        private System.Windows.Forms.TextBox txtNameCommodity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvVendor;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.Button btnDelVendor;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.Button btnUpdVendor;
        private System.Windows.Forms.Button btnCancelCommodity;
        private System.Windows.Forms.Button btnCancelVendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIdCommodity;
        private System.Windows.Forms.TextBox txtCostCommodity;
        private System.Windows.Forms.TextBox txtIdCommodity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeCommodity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodeVendor;
        private System.Windows.Forms.TextBox txtNameVendor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantityCommodity;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExportVendor;
    }
}