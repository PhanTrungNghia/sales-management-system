namespace SalesManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComVenManagement = new System.Windows.Forms.Button();
            this.btnGoodsManagement = new System.Windows.Forms.Button();
            this.btnStatisticsManagement = new System.Windows.Forms.Button();
            this.btnBillManagement = new System.Windows.Forms.Button();
            this.btnEmployeesManagement = new System.Windows.Forms.Button();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHello = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSayHello = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnComVenManagement);
            this.groupBox1.Controls.Add(this.btnGoodsManagement);
            this.groupBox1.Controls.Add(this.btnStatisticsManagement);
            this.groupBox1.Controls.Add(this.btnBillManagement);
            this.groupBox1.Controls.Add(this.btnEmployeesManagement);
            this.groupBox1.Controls.Add(this.btnClientManagement);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 650);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Magenta;
            this.button1.Location = new System.Drawing.Point(16, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Forwarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComVenManagement
            // 
            this.btnComVenManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnComVenManagement.Location = new System.Drawing.Point(16, 303);
            this.btnComVenManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnComVenManagement.Name = "btnComVenManagement";
            this.btnComVenManagement.Size = new System.Drawing.Size(227, 66);
            this.btnComVenManagement.TabIndex = 8;
            this.btnComVenManagement.Text = "Commodity - Vendor";
            this.btnComVenManagement.UseVisualStyleBackColor = true;
            this.btnComVenManagement.Click += new System.EventHandler(this.btnComVenManagement_Click);
            // 
            // btnGoodsManagement
            // 
            this.btnGoodsManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnGoodsManagement.Location = new System.Drawing.Point(16, 211);
            this.btnGoodsManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoodsManagement.Name = "btnGoodsManagement";
            this.btnGoodsManagement.Size = new System.Drawing.Size(227, 66);
            this.btnGoodsManagement.TabIndex = 7;
            this.btnGoodsManagement.Text = "Goods";
            this.btnGoodsManagement.UseVisualStyleBackColor = true;
            this.btnGoodsManagement.Click += new System.EventHandler(this.btnGoodsManagement_Click);
            // 
            // btnStatisticsManagement
            // 
            this.btnStatisticsManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnStatisticsManagement.Location = new System.Drawing.Point(16, 562);
            this.btnStatisticsManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatisticsManagement.Name = "btnStatisticsManagement";
            this.btnStatisticsManagement.Size = new System.Drawing.Size(227, 66);
            this.btnStatisticsManagement.TabIndex = 6;
            this.btnStatisticsManagement.Text = "Statistics";
            this.btnStatisticsManagement.UseVisualStyleBackColor = true;
            this.btnStatisticsManagement.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBillManagement
            // 
            this.btnBillManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnBillManagement.Location = new System.Drawing.Point(16, 394);
            this.btnBillManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.Size = new System.Drawing.Size(227, 66);
            this.btnBillManagement.TabIndex = 5;
            this.btnBillManagement.Text = "Bill";
            this.btnBillManagement.UseVisualStyleBackColor = true;
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click);
            // 
            // btnEmployeesManagement
            // 
            this.btnEmployeesManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnEmployeesManagement.Location = new System.Drawing.Point(16, 26);
            this.btnEmployeesManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesManagement.Name = "btnEmployeesManagement";
            this.btnEmployeesManagement.Size = new System.Drawing.Size(227, 66);
            this.btnEmployeesManagement.TabIndex = 3;
            this.btnEmployeesManagement.Text = "Employees";
            this.btnEmployeesManagement.UseVisualStyleBackColor = true;
            this.btnEmployeesManagement.Click += new System.EventHandler(this.btnEmployeesManagement_Click);
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.ForeColor = System.Drawing.Color.Magenta;
            this.btnClientManagement.Location = new System.Drawing.Point(16, 117);
            this.btnClientManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(227, 66);
            this.btnClientManagement.TabIndex = 4;
            this.btnClientManagement.Text = "Client";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            this.btnClientManagement.Click += new System.EventHandler(this.btnClientManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHello.Location = new System.Drawing.Point(346, 56);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(64, 27);
            this.txtHello.TabIndex = 3;
            this.txtHello.Text = "Hello";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 4;
            // 
            // lbSayHello
            // 
            this.lbSayHello.AutoSize = true;
            this.lbSayHello.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSayHello.Location = new System.Drawing.Point(429, 56);
            this.lbSayHello.Name = "lbSayHello";
            this.lbSayHello.Size = new System.Drawing.Size(30, 27);
            this.lbSayHello.TabIndex = 5;
            this.lbSayHello.Text = "...";
            this.lbSayHello.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(991, 674);
            this.Controls.Add(this.lbSayHello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Sales Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBillManagement;
        private System.Windows.Forms.Button btnEmployeesManagement;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSayHello;
        private System.Windows.Forms.Button btnStatisticsManagement;
        private System.Windows.Forms.Button btnComVenManagement;
        private System.Windows.Forms.Button btnGoodsManagement;
        private System.Windows.Forms.Button button1;
    }
}

