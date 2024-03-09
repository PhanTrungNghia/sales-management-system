namespace SalesManagementSystem.View
{
    partial class frmBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCashierBill = new System.Windows.Forms.ComboBox();
            this.cbbCustomerBill = new System.Windows.Forms.ComboBox();
            this.btnThreeDotBill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceDateBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceIdBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbForwarder = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveInvoiceDetails = new System.Windows.Forms.Button();
            this.btnAddInvoiceDetails = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantityInvoiceDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPriceInvoiceDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbProductInvoiceDetails = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListGoodsBill = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.dgvListGoodsBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbCashierBill);
            this.groupBox1.Controls.Add(this.cbbCustomerBill);
            this.groupBox1.Controls.Add(this.btnThreeDotBill);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInvoiceDateBill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInvoiceIdBill);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Bill";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbCashierBill
            // 
            this.cbbCashierBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbCashierBill.FormattingEnabled = true;
            this.cbbCashierBill.Location = new System.Drawing.Point(588, 44);
            this.cbbCashierBill.Name = "cbbCashierBill";
            this.cbbCashierBill.Size = new System.Drawing.Size(160, 27);
            this.cbbCashierBill.TabIndex = 6;
            this.cbbCashierBill.SelectedIndexChanged += new System.EventHandler(this.cbbBillersBill_SelectedIndexChanged);
            this.cbbCashierBill.TextChanged += new System.EventHandler(this.cbbBillersBill_TextChanged);
            // 
            // cbbCustomerBill
            // 
            this.cbbCustomerBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbCustomerBill.FormattingEnabled = true;
            this.cbbCustomerBill.Location = new System.Drawing.Point(588, 92);
            this.cbbCustomerBill.Name = "cbbCustomerBill";
            this.cbbCustomerBill.Size = new System.Drawing.Size(160, 27);
            this.cbbCustomerBill.TabIndex = 5;
            this.cbbCustomerBill.SelectedIndexChanged += new System.EventHandler(this.cbbClientBill_SelectedIndexChanged);
            // 
            // btnThreeDotBill
            // 
            this.btnThreeDotBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThreeDotBill.Location = new System.Drawing.Point(413, 92);
            this.btnThreeDotBill.Name = "btnThreeDotBill";
            this.btnThreeDotBill.Size = new System.Drawing.Size(34, 26);
            this.btnThreeDotBill.TabIndex = 3;
            this.btnThreeDotBill.Text = "...";
            this.btnThreeDotBill.UseVisualStyleBackColor = true;
            this.btnThreeDotBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cashier Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInvoiceDateBill
            // 
            this.txtInvoiceDateBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInvoiceDateBill.Enabled = false;
            this.txtInvoiceDateBill.Location = new System.Drawing.Point(254, 92);
            this.txtInvoiceDateBill.Name = "txtInvoiceDateBill";
            this.txtInvoiceDateBill.Size = new System.Drawing.Size(153, 26);
            this.txtInvoiceDateBill.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Date";
            // 
            // txtInvoiceIdBill
            // 
            this.txtInvoiceIdBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInvoiceIdBill.Location = new System.Drawing.Point(254, 43);
            this.txtInvoiceIdBill.Name = "txtInvoiceIdBill";
            this.txtInvoiceIdBill.Size = new System.Drawing.Size(153, 26);
            this.txtInvoiceIdBill.TabIndex = 1;
            this.txtInvoiceIdBill.TextChanged += new System.EventHandler(this.txtIdBill_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Id ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvListBill
            // 
            this.dgvListBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBill.Location = new System.Drawing.Point(3, 22);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.Size = new System.Drawing.Size(876, 459);
            this.dgvListBill.TabIndex = 1;
            this.dgvListBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBill_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListBill);
            this.groupBox2.Location = new System.Drawing.Point(22, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 484);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Bill";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBill.BackColor = System.Drawing.Color.Aqua;
            this.btnAddBill.Location = new System.Drawing.Point(25, 170);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(101, 86);
            this.btnAddBill.TabIndex = 3;
            this.btnAddBill.Text = "Add ";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBill.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteBill.Location = new System.Drawing.Point(145, 170);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(101, 86);
            this.btnDeleteBill.TabIndex = 3;
            this.btnDeleteBill.Text = "Delete";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrintBill.BackColor = System.Drawing.Color.Aqua;
            this.btnPrintBill.Location = new System.Drawing.Point(264, 170);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(101, 86);
            this.btnPrintBill.TabIndex = 3;
            this.btnPrintBill.Text = "Print ";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbbForwarder);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnRemoveInvoiceDetails);
            this.groupBox3.Controls.Add(this.btnAddInvoiceDetails);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQuantityInvoiceDetails);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPriceInvoiceDetails);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbbProductInvoiceDetails);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dgvListGoodsBill);
            this.groupBox3.Location = new System.Drawing.Point(910, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 737);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "InvoiveDetails";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbbForwarder
            // 
            this.cbbForwarder.FormattingEnabled = true;
            this.cbbForwarder.Location = new System.Drawing.Point(339, 130);
            this.cbbForwarder.Name = "cbbForwarder";
            this.cbbForwarder.Size = new System.Drawing.Size(98, 27);
            this.cbbForwarder.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Forwarder";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.Blue;
            this.lbTotal.Location = new System.Drawing.Point(89, 133);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(17, 19);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "0";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total";
            // 
            // btnRemoveInvoiceDetails
            // 
            this.btnRemoveInvoiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveInvoiceDetails.BackColor = System.Drawing.Color.Aqua;
            this.btnRemoveInvoiceDetails.Location = new System.Drawing.Point(238, 169);
            this.btnRemoveInvoiceDetails.Name = "btnRemoveInvoiceDetails";
            this.btnRemoveInvoiceDetails.Size = new System.Drawing.Size(101, 86);
            this.btnRemoveInvoiceDetails.TabIndex = 15;
            this.btnRemoveInvoiceDetails.Text = "Remove";
            this.btnRemoveInvoiceDetails.UseVisualStyleBackColor = false;
            this.btnRemoveInvoiceDetails.Click += new System.EventHandler(this.btnRemoveInvoiceDetails_Click);
            // 
            // btnAddInvoiceDetails
            // 
            this.btnAddInvoiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddInvoiceDetails.BackColor = System.Drawing.Color.Aqua;
            this.btnAddInvoiceDetails.Location = new System.Drawing.Point(128, 169);
            this.btnAddInvoiceDetails.Name = "btnAddInvoiceDetails";
            this.btnAddInvoiceDetails.Size = new System.Drawing.Size(101, 86);
            this.btnAddInvoiceDetails.TabIndex = 14;
            this.btnAddInvoiceDetails.Text = "Add";
            this.btnAddInvoiceDetails.UseVisualStyleBackColor = false;
            this.btnAddInvoiceDetails.Click += new System.EventHandler(this.btnAddInvoiceDetails_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "(VNĐ)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtQuantityInvoiceDetails
            // 
            this.txtQuantityInvoiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityInvoiceDetails.Location = new System.Drawing.Point(339, 85);
            this.txtQuantityInvoiceDetails.Name = "txtQuantityInvoiceDetails";
            this.txtQuantityInvoiceDetails.Size = new System.Drawing.Size(98, 26);
            this.txtQuantityInvoiceDetails.TabIndex = 11;
            this.txtQuantityInvoiceDetails.TextChanged += new System.EventHandler(this.txtQuantityInvoiceDetails_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantity";
            // 
            // txtPriceInvoiceDetails
            // 
            this.txtPriceInvoiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPriceInvoiceDetails.Location = new System.Drawing.Point(93, 84);
            this.txtPriceInvoiceDetails.Name = "txtPriceInvoiceDetails";
            this.txtPriceInvoiceDetails.Size = new System.Drawing.Size(101, 26);
            this.txtPriceInvoiceDetails.TabIndex = 9;
            this.txtPriceInvoiceDetails.TextChanged += new System.EventHandler(this.txtPriceInvoiceDetails_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbProductInvoiceDetails
            // 
            this.cbbProductInvoiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbProductInvoiceDetails.FormattingEnabled = true;
            this.cbbProductInvoiceDetails.Location = new System.Drawing.Point(93, 44);
            this.cbbProductInvoiceDetails.Name = "cbbProductInvoiceDetails";
            this.cbbProductInvoiceDetails.Size = new System.Drawing.Size(344, 27);
            this.cbbProductInvoiceDetails.TabIndex = 7;
            this.cbbProductInvoiceDetails.SelectedIndexChanged += new System.EventHandler(this.cbbGoodsInvoiceDetails_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Product";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvListGoodsBill
            // 
            this.dgvListGoodsBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListGoodsBill.Controls.Add(this.dataGridView1);
            this.dgvListGoodsBill.Location = new System.Drawing.Point(13, 256);
            this.dgvListGoodsBill.Name = "dgvListGoodsBill";
            this.dgvListGoodsBill.Size = new System.Drawing.Size(443, 481);
            this.dgvListGoodsBill.TabIndex = 0;
            this.dgvListGoodsBill.TabStop = false;
            this.dgvListGoodsBill.Text = "List Goods";
            this.dgvListGoodsBill.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 456);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveBill.Location = new System.Drawing.Point(386, 170);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(101, 86);
            this.btnSaveBill.TabIndex = 5;
            this.btnSaveBill.Text = "Save";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelBill.Location = new System.Drawing.Point(514, 170);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(101, 86);
            this.btnCancelBill.TabIndex = 6;
            this.btnCancelBill.Text = "Cancel";
            this.btnCancelBill.UseVisualStyleBackColor = false;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExport.Location = new System.Drawing.Point(759, 170);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 86);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Import";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(SalesManagementSystem.Object.Bill);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(640, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCancelBill);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.dgvListGoodsBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceDateBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceIdBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThreeDotBill;
        private System.Windows.Forms.ComboBox cbbCustomerBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox dgvListGoodsBill;
        private System.Windows.Forms.TextBox txtQuantityInvoiceDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPriceInvoiceDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbProductInvoiceDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveInvoiceDetails;
        private System.Windows.Forms.Button btnAddInvoiceDetails;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.ComboBox cbbCashierBill;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbForwarder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.Button button1;
    }
}