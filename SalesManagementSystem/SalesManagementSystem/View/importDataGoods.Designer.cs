namespace SalesManagementSystem.View
{
    partial class importDataGoods
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
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
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
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeGoodsDataGridViewTextBoxColumn,
            this.commodityidDataGridViewTextBoxColumn,
            this.venderidDataGridViewTextBoxColumn,
            this.idGoodsDataGridViewTextBoxColumn,
            this.nameGoodsDataGridViewTextBoxColumn,
            this.costGoodsDataGridViewTextBoxColumn,
            this.quantityGoodsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 326);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeGoodsDataGridViewTextBoxColumn
            // 
            this.codeGoodsDataGridViewTextBoxColumn.DataPropertyName = "CodeGoods";
            this.codeGoodsDataGridViewTextBoxColumn.HeaderText = "CodeGoods";
            this.codeGoodsDataGridViewTextBoxColumn.Name = "codeGoodsDataGridViewTextBoxColumn";
            // 
            // commodityidDataGridViewTextBoxColumn
            // 
            this.commodityidDataGridViewTextBoxColumn.DataPropertyName = "Commodity_id";
            this.commodityidDataGridViewTextBoxColumn.HeaderText = "Commodity_id";
            this.commodityidDataGridViewTextBoxColumn.Name = "commodityidDataGridViewTextBoxColumn";
            // 
            // venderidDataGridViewTextBoxColumn
            // 
            this.venderidDataGridViewTextBoxColumn.DataPropertyName = "Vender_id";
            this.venderidDataGridViewTextBoxColumn.HeaderText = "Vender_id";
            this.venderidDataGridViewTextBoxColumn.Name = "venderidDataGridViewTextBoxColumn";
            // 
            // idGoodsDataGridViewTextBoxColumn
            // 
            this.idGoodsDataGridViewTextBoxColumn.DataPropertyName = "IdGoods";
            this.idGoodsDataGridViewTextBoxColumn.HeaderText = "IdGoods";
            this.idGoodsDataGridViewTextBoxColumn.Name = "idGoodsDataGridViewTextBoxColumn";
            // 
            // nameGoodsDataGridViewTextBoxColumn
            // 
            this.nameGoodsDataGridViewTextBoxColumn.DataPropertyName = "NameGoods";
            this.nameGoodsDataGridViewTextBoxColumn.HeaderText = "NameGoods";
            this.nameGoodsDataGridViewTextBoxColumn.Name = "nameGoodsDataGridViewTextBoxColumn";
            // 
            // costGoodsDataGridViewTextBoxColumn
            // 
            this.costGoodsDataGridViewTextBoxColumn.DataPropertyName = "CostGoods";
            this.costGoodsDataGridViewTextBoxColumn.HeaderText = "CostGoods";
            this.costGoodsDataGridViewTextBoxColumn.Name = "costGoodsDataGridViewTextBoxColumn";
            // 
            // quantityGoodsDataGridViewTextBoxColumn
            // 
            this.quantityGoodsDataGridViewTextBoxColumn.DataPropertyName = "QuantityGoods";
            this.quantityGoodsDataGridViewTextBoxColumn.HeaderText = "QuantityGoods";
            this.quantityGoodsDataGridViewTextBoxColumn.Name = "quantityGoodsDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(SalesManagementSystem.Object.Goods);
            // 
            // importDataGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(922, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cbbSheet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Name = "importDataGoods";
            this.Text = "importDataGoods";
            this.Load += new System.EventHandler(this.importDataGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
    }
}