namespace SalesManagementSystem.View
{
    partial class frmGoods
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
            this.dgvListGoods = new System.Windows.Forms.DataGridView();
            this.btnCancelGoods = new System.Windows.Forms.Button();
            this.btnSaveGoods = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.btnUpdateGoods = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbVenderGoods = new System.Windows.Forms.ComboBox();
            this.cbbCommodityGoods = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeGoods = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtQuantityGoods = new System.Windows.Forms.TextBox();
            this.lbVNĐGoods = new System.Windows.Forms.Label();
            this.txtCostGoods = new System.Windows.Forms.TextBox();
            this.lbAddressGoods = new System.Windows.Forms.Label();
            this.txtNameGoods = new System.Windows.Forms.TextBox();
            this.lbNameGoods = new System.Windows.Forms.Label();
            this.lbSexGoods = new System.Windows.Forms.Label();
            this.txtIdGoods = new System.Windows.Forms.TextBox();
            this.lbIDGoods = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListGoods);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1227, 297);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Goods";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvListGoods
            // 
            this.dgvListGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGoods.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGoods.Location = new System.Drawing.Point(4, 29);
            this.dgvListGoods.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListGoods.Name = "dgvListGoods";
            this.dgvListGoods.Size = new System.Drawing.Size(1218, 312);
            this.dgvListGoods.TabIndex = 0;
            // 
            // btnCancelGoods
            // 
            this.btnCancelGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelGoods.Enabled = false;
            this.btnCancelGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGoods.Location = new System.Drawing.Point(810, 205);
            this.btnCancelGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelGoods.Name = "btnCancelGoods";
            this.btnCancelGoods.Size = new System.Drawing.Size(120, 124);
            this.btnCancelGoods.TabIndex = 12;
            this.btnCancelGoods.Text = "Cancel";
            this.btnCancelGoods.UseVisualStyleBackColor = false;
            this.btnCancelGoods.Click += new System.EventHandler(this.btnCancelGoods_Click);
            // 
            // btnSaveGoods
            // 
            this.btnSaveGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveGoods.Enabled = false;
            this.btnSaveGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGoods.Location = new System.Drawing.Point(641, 206);
            this.btnSaveGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveGoods.Name = "btnSaveGoods";
            this.btnSaveGoods.Size = new System.Drawing.Size(118, 124);
            this.btnSaveGoods.TabIndex = 13;
            this.btnSaveGoods.Text = "Save";
            this.btnSaveGoods.UseVisualStyleBackColor = false;
            this.btnSaveGoods.Click += new System.EventHandler(this.btnSaveGoods_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteGoods.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGoods.Location = new System.Drawing.Point(467, 206);
            this.btnDeleteGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(129, 124);
            this.btnDeleteGoods.TabIndex = 14;
            this.btnDeleteGoods.Text = "Delete";
            this.btnDeleteGoods.UseVisualStyleBackColor = false;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // btnUpdateGoods
            // 
            this.btnUpdateGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateGoods.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGoods.Location = new System.Drawing.Point(294, 206);
            this.btnUpdateGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGoods.Name = "btnUpdateGoods";
            this.btnUpdateGoods.Size = new System.Drawing.Size(132, 124);
            this.btnUpdateGoods.TabIndex = 15;
            this.btnUpdateGoods.Text = "Update";
            this.btnUpdateGoods.UseVisualStyleBackColor = false;
            this.btnUpdateGoods.Click += new System.EventHandler(this.btnUpdateGoods_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddGoods.BackColor = System.Drawing.Color.Aqua;
            this.btnAddGoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddGoods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoods.Location = new System.Drawing.Point(121, 206);
            this.btnAddGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(126, 124);
            this.btnAddGoods.TabIndex = 16;
            this.btnAddGoods.Text = "Add";
            this.btnAddGoods.UseVisualStyleBackColor = false;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbVenderGoods);
            this.groupBox1.Controls.Add(this.cbbCommodityGoods);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodeGoods);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtQuantityGoods);
            this.groupBox1.Controls.Add(this.lbVNĐGoods);
            this.groupBox1.Controls.Add(this.txtCostGoods);
            this.groupBox1.Controls.Add(this.lbAddressGoods);
            this.groupBox1.Controls.Add(this.txtNameGoods);
            this.groupBox1.Controls.Add(this.lbNameGoods);
            this.groupBox1.Controls.Add(this.lbSexGoods);
            this.groupBox1.Controls.Add(this.txtIdGoods);
            this.groupBox1.Controls.Add(this.lbIDGoods);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1222, 184);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Goods";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbVenderGoods
            // 
            this.cbbVenderGoods.FormattingEnabled = true;
            this.cbbVenderGoods.Location = new System.Drawing.Point(900, 114);
            this.cbbVenderGoods.Name = "cbbVenderGoods";
            this.cbbVenderGoods.Size = new System.Drawing.Size(145, 27);
            this.cbbVenderGoods.TabIndex = 13;
            // 
            // cbbCommodityGoods
            // 
            this.cbbCommodityGoods.FormattingEnabled = true;
            this.cbbCommodityGoods.Location = new System.Drawing.Point(900, 64);
            this.cbbCommodityGoods.Name = "cbbCommodityGoods";
            this.cbbCommodityGoods.Size = new System.Drawing.Size(145, 27);
            this.cbbCommodityGoods.TabIndex = 12;
            this.cbbCommodityGoods.SelectedIndexChanged += new System.EventHandler(this.cbbCommodityGoods_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Commodity";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vendor";
            // 
            // txtCodeGoods
            // 
            this.txtCodeGoods.Enabled = false;
            this.txtCodeGoods.Location = new System.Drawing.Point(899, 16);
            this.txtCodeGoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeGoods.Name = "txtCodeGoods";
            this.txtCodeGoods.Size = new System.Drawing.Size(146, 26);
            this.txtCodeGoods.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 29);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtQuantityGoods
            // 
            this.txtQuantityGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantityGoods.Enabled = false;
            this.txtQuantityGoods.Location = new System.Drawing.Point(233, 92);
            this.txtQuantityGoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityGoods.Name = "txtQuantityGoods";
            this.txtQuantityGoods.Size = new System.Drawing.Size(146, 26);
            this.txtQuantityGoods.TabIndex = 5;
            // 
            // lbVNĐGoods
            // 
            this.lbVNĐGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVNĐGoods.AutoSize = true;
            this.lbVNĐGoods.Location = new System.Drawing.Point(712, 92);
            this.lbVNĐGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVNĐGoods.Name = "lbVNĐGoods";
            this.lbVNĐGoods.Size = new System.Drawing.Size(53, 19);
            this.lbVNĐGoods.TabIndex = 4;
            this.lbVNĐGoods.Text = "(VNĐ)";
            this.lbVNĐGoods.Click += new System.EventHandler(this.lbVNĐ_Click);
            // 
            // txtCostGoods
            // 
            this.txtCostGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostGoods.Enabled = false;
            this.txtCostGoods.Location = new System.Drawing.Point(504, 88);
            this.txtCostGoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostGoods.Name = "txtCostGoods";
            this.txtCostGoods.Size = new System.Drawing.Size(200, 26);
            this.txtCostGoods.TabIndex = 1;
            // 
            // lbAddressGoods
            // 
            this.lbAddressGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAddressGoods.AutoSize = true;
            this.lbAddressGoods.Location = new System.Drawing.Point(408, 92);
            this.lbAddressGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddressGoods.Name = "lbAddressGoods";
            this.lbAddressGoods.Size = new System.Drawing.Size(41, 19);
            this.lbAddressGoods.TabIndex = 0;
            this.lbAddressGoods.Text = "Cost:";
            // 
            // txtNameGoods
            // 
            this.txtNameGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameGoods.Enabled = false;
            this.txtNameGoods.Location = new System.Drawing.Point(504, 19);
            this.txtNameGoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameGoods.Name = "txtNameGoods";
            this.txtNameGoods.Size = new System.Drawing.Size(261, 26);
            this.txtNameGoods.TabIndex = 1;
            this.txtNameGoods.TextChanged += new System.EventHandler(this.txtNameGoods_TextChanged);
            // 
            // lbNameGoods
            // 
            this.lbNameGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameGoods.AutoSize = true;
            this.lbNameGoods.Location = new System.Drawing.Point(408, 23);
            this.lbNameGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameGoods.Name = "lbNameGoods";
            this.lbNameGoods.Size = new System.Drawing.Size(88, 19);
            this.lbNameGoods.TabIndex = 0;
            this.lbNameGoods.Text = "Name Good:";
            // 
            // lbSexGoods
            // 
            this.lbSexGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSexGoods.AutoSize = true;
            this.lbSexGoods.Location = new System.Drawing.Point(161, 92);
            this.lbSexGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexGoods.Name = "lbSexGoods";
            this.lbSexGoods.Size = new System.Drawing.Size(63, 19);
            this.lbSexGoods.TabIndex = 0;
            this.lbSexGoods.Text = "Quantity:";
            // 
            // txtIdGoods
            // 
            this.txtIdGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdGoods.Enabled = false;
            this.txtIdGoods.Location = new System.Drawing.Point(233, 19);
            this.txtIdGoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdGoods.Name = "txtIdGoods";
            this.txtIdGoods.Size = new System.Drawing.Size(146, 26);
            this.txtIdGoods.TabIndex = 1;
            // 
            // lbIDGoods
            // 
            this.lbIDGoods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDGoods.AutoSize = true;
            this.lbIDGoods.Location = new System.Drawing.Point(161, 23);
            this.lbIDGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDGoods.Name = "lbIDGoods";
            this.lbIDGoods.Size = new System.Drawing.Size(64, 19);
            this.lbIDGoods.TabIndex = 0;
            this.lbIDGoods.Text = "Id Good:";
            this.lbIDGoods.Click += new System.EventHandler(this.lbIDGoods_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(981, 206);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 124);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Import";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelGoods);
            this.Controls.Add(this.btnSaveGoods);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnUpdateGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGoods";
            this.Text = "frmGoods";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListGoods;
        private System.Windows.Forms.Button btnCancelGoods;
        private System.Windows.Forms.Button btnSaveGoods;
        private System.Windows.Forms.Button btnDeleteGoods;
        private System.Windows.Forms.Button btnUpdateGoods;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbVNĐGoods;
        private System.Windows.Forms.TextBox txtCostGoods;
        private System.Windows.Forms.Label lbAddressGoods;
        private System.Windows.Forms.TextBox txtNameGoods;
        private System.Windows.Forms.Label lbNameGoods;
        private System.Windows.Forms.Label lbSexGoods;
        private System.Windows.Forms.TextBox txtIdGoods;
        private System.Windows.Forms.Label lbIDGoods;
        private System.Windows.Forms.TextBox txtQuantityGoods;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeGoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCommodityGoods;
        private System.Windows.Forms.ComboBox cbbVenderGoods;
        private System.Windows.Forms.Button btnExport;
    }
}