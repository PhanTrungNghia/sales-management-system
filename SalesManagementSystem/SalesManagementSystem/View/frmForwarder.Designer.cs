namespace SalesManagementSystem.View
{
    partial class frmForwarder
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIdCommodity = new System.Windows.Forms.Label();
            this.txtIdForwarder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListForwarder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancelForwarder = new System.Windows.Forms.Button();
            this.btnDelForwarder = new System.Windows.Forms.Button();
            this.btnAddForwarder = new System.Windows.Forms.Button();
            this.btnSaveForwarder = new System.Windows.Forms.Button();
            this.btnUpdForwarder = new System.Windows.Forms.Button();
            this.txtCodeForwarder = new System.Windows.Forms.TextBox();
            this.txtNameForwarder = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListForwarder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.lbIdCommodity);
            this.groupBox3.Controls.Add(this.txtIdForwarder);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtCodeForwarder);
            this.groupBox3.Controls.Add(this.txtNameForwarder);
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 542);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbIdCommodity
            // 
            this.lbIdCommodity.AutoSize = true;
            this.lbIdCommodity.Location = new System.Drawing.Point(341, 53);
            this.lbIdCommodity.Name = "lbIdCommodity";
            this.lbIdCommodity.Size = new System.Drawing.Size(97, 19);
            this.lbIdCommodity.TabIndex = 9;
            this.lbIdCommodity.Text = "Commodity Id";
            // 
            // txtIdForwarder
            // 
            this.txtIdForwarder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdForwarder.Location = new System.Drawing.Point(460, 49);
            this.txtIdForwarder.Name = "txtIdForwarder";
            this.txtIdForwarder.Size = new System.Drawing.Size(149, 26);
            this.txtIdForwarder.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListForwarder);
            this.groupBox2.Location = new System.Drawing.Point(18, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forwarder List";
            // 
            // dgvListForwarder
            // 
            this.dgvListForwarder.AllowUserToAddRows = false;
            this.dgvListForwarder.AllowUserToDeleteRows = false;
            this.dgvListForwarder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListForwarder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListForwarder.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvListForwarder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListForwarder.Location = new System.Drawing.Point(3, 22);
            this.dgvListForwarder.Name = "dgvListForwarder";
            this.dgvListForwarder.ReadOnly = true;
            this.dgvListForwarder.Size = new System.Drawing.Size(583, 191);
            this.dgvListForwarder.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Forwarder Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forwarder Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnCancelForwarder);
            this.groupBox1.Controls.Add(this.btnDelForwarder);
            this.groupBox1.Controls.Add(this.btnAddForwarder);
            this.groupBox1.Controls.Add(this.btnSaveForwarder);
            this.groupBox1.Controls.Add(this.btnUpdForwarder);
            this.groupBox1.Location = new System.Drawing.Point(21, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExport.Location = new System.Drawing.Point(473, 34);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 52);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Import";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancelForwarder
            // 
            this.btnCancelForwarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelForwarder.Location = new System.Drawing.Point(375, 34);
            this.btnCancelForwarder.Name = "btnCancelForwarder";
            this.btnCancelForwarder.Size = new System.Drawing.Size(75, 52);
            this.btnCancelForwarder.TabIndex = 6;
            this.btnCancelForwarder.Text = "Cancel";
            this.btnCancelForwarder.UseVisualStyleBackColor = false;
            this.btnCancelForwarder.Click += new System.EventHandler(this.btnCancelForwarder_Click);
            // 
            // btnDelForwarder
            // 
            this.btnDelForwarder.BackColor = System.Drawing.Color.Aqua;
            this.btnDelForwarder.Location = new System.Drawing.Point(203, 34);
            this.btnDelForwarder.Name = "btnDelForwarder";
            this.btnDelForwarder.Size = new System.Drawing.Size(75, 52);
            this.btnDelForwarder.TabIndex = 4;
            this.btnDelForwarder.Text = "Delete";
            this.btnDelForwarder.UseVisualStyleBackColor = false;
            this.btnDelForwarder.Click += new System.EventHandler(this.btnDelForwarder_Click);
            // 
            // btnAddForwarder
            // 
            this.btnAddForwarder.BackColor = System.Drawing.Color.Aqua;
            this.btnAddForwarder.Location = new System.Drawing.Point(18, 34);
            this.btnAddForwarder.Name = "btnAddForwarder";
            this.btnAddForwarder.Size = new System.Drawing.Size(75, 52);
            this.btnAddForwarder.TabIndex = 2;
            this.btnAddForwarder.Text = "Add";
            this.btnAddForwarder.UseVisualStyleBackColor = false;
            this.btnAddForwarder.Click += new System.EventHandler(this.btnAddForwarder_Click);
            // 
            // btnSaveForwarder
            // 
            this.btnSaveForwarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveForwarder.Location = new System.Drawing.Point(294, 34);
            this.btnSaveForwarder.Name = "btnSaveForwarder";
            this.btnSaveForwarder.Size = new System.Drawing.Size(75, 52);
            this.btnSaveForwarder.TabIndex = 5;
            this.btnSaveForwarder.Text = "Save";
            this.btnSaveForwarder.UseVisualStyleBackColor = false;
            this.btnSaveForwarder.Click += new System.EventHandler(this.btnSaveForwarder_Click);
            // 
            // btnUpdForwarder
            // 
            this.btnUpdForwarder.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdForwarder.Location = new System.Drawing.Point(110, 34);
            this.btnUpdForwarder.Name = "btnUpdForwarder";
            this.btnUpdForwarder.Size = new System.Drawing.Size(75, 52);
            this.btnUpdForwarder.TabIndex = 3;
            this.btnUpdForwarder.Text = "Update";
            this.btnUpdForwarder.UseVisualStyleBackColor = false;
            this.btnUpdForwarder.Click += new System.EventHandler(this.btnUpdForwarder_Click);
            // 
            // txtCodeForwarder
            // 
            this.txtCodeForwarder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeForwarder.Location = new System.Drawing.Point(175, 98);
            this.txtCodeForwarder.Name = "txtCodeForwarder";
            this.txtCodeForwarder.Size = new System.Drawing.Size(146, 26);
            this.txtCodeForwarder.TabIndex = 1;
            // 
            // txtNameForwarder
            // 
            this.txtNameForwarder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameForwarder.Location = new System.Drawing.Point(175, 53);
            this.txtNameForwarder.Name = "txtNameForwarder";
            this.txtNameForwarder.Size = new System.Drawing.Size(146, 26);
            this.txtNameForwarder.TabIndex = 1;
            // 
            // frmForwarder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(644, 573);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmForwarder";
            this.Text = "frmForwarder";
            this.Load += new System.EventHandler(this.frmForwarder_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListForwarder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbIdCommodity;
        private System.Windows.Forms.TextBox txtIdForwarder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListForwarder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelForwarder;
        private System.Windows.Forms.Button btnDelForwarder;
        private System.Windows.Forms.Button btnAddForwarder;
        private System.Windows.Forms.Button btnSaveForwarder;
        private System.Windows.Forms.Button btnUpdForwarder;
        private System.Windows.Forms.TextBox txtCodeForwarder;
        private System.Windows.Forms.TextBox txtNameForwarder;
        private System.Windows.Forms.Button btnExport;
    }
}