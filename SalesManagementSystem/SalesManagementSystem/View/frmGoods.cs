using SalesManagementSystem.Controller;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.View
{
    public partial class frmGoods : Form
    {

        GoodsController goodsController = new GoodsController();
        int flag = 0;

        public frmGoods()
        {

            InitializeComponent();

        }

        private void frmGoods_Load(object sender, EventArgs e)
        {

            DataTable dtGoods = new DataTable();
            dtGoods = goodsController.GetData();
            dgvListGoods.DataSource = dtGoods;
            bindDing();
            display_enable(false);

        }

        void display_enable(bool e)
        {

            txtIdGoods.Enabled = e;
            txtNameGoods.Enabled = e;
            txtCostGoods.Enabled = e;
            txtQuantityGoods.Enabled = false;
            txtCodeGoods.Enabled = e;
            cbbCommodityGoods.Enabled = e;
            cbbVenderGoods.Enabled = e;

            btnSaveGoods.Enabled = e;
            btnCancelGoods.Enabled = e;
            btnAddGoods.Enabled = !e;
            btnUpdateGoods.Enabled = !e;
            btnDeleteGoods.Enabled = !e;
            btnSubmit.Enabled = e;

        }


        void loadController()
        {

            txtNameGoods.Text = "";
            txtIdGoods.Text = "";
            txtCostGoods.Text = "";
            txtQuantityGoods.Text = "";

        }

        // Adđ without QuantityGoods value
        void addDataOne(Goods goods)
        {
            goods.IdGoods = txtIdGoods.Text.Trim();
            goods.NameGoods = txtNameGoods.Text.Trim();
            goods.CostGoods = int.Parse(txtCostGoods.Text.Trim());
        }

        // Adđ with QuantityGoods value
        void addDataTwo(Goods goods)
        {
            goods.IdGoods = txtIdGoods.Text.Trim();
            goods.NameGoods = txtNameGoods.Text.Trim();
            goods.CostGoods = int.Parse(txtCostGoods.Text.Trim());
            goods.CodeGoods = txtCodeGoods.Text.Trim();
            goods.QuantityGoods = int.Parse(txtQuantityGoods.Text.Trim());
            try
            {
                goods.Commodity_id = int.Parse(cbbCommodityGoods.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Commodity Id must be number", "Request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            goods.Vender_id = int.Parse(cbbVenderGoods.Text.Trim());
        }


        // bindDing method for Interactive between DataGridView and Components 
        void bindDing()
        {
            txtIdGoods.DataBindings.Clear();
            txtIdGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "idGoods");

            txtNameGoods.DataBindings.Clear();
            txtNameGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "nameGoods");

            txtCostGoods.DataBindings.Clear();
            txtCostGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "costGoods");

            txtQuantityGoods.DataBindings.Clear();
            txtQuantityGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "quantityGoods");

            cbbCommodityGoods.DataBindings.Clear();
            cbbCommodityGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "commodity_id");

            cbbVenderGoods.DataBindings.Clear();
            cbbVenderGoods.DataBindings.Add("Text", dgvListGoods.DataSource, "vender_id");
        }

        void loadCBBCommodityGoods()
        {
            CommodityController commodityController = new CommodityController();
            cbbCommodityGoods.DataSource = commodityController.GetData();
            // Input value from tb_employees
            cbbCommodityGoods.DisplayMember = "idCommodity";
            // Value of columns idEmployees
            cbbCommodityGoods.ValueMember = "idCommodity";
        }

        void loadCBBVenderGoods()
        {
            VendorController vendorController = new VendorController();
            cbbVenderGoods.DataSource = vendorController.GetData();
            // Input value from tb_employees
            cbbVenderGoods.DisplayMember = "idVender";
            // Value of columns idEmployees
            cbbVenderGoods.ValueMember = "idVendor";
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {

            flag = 0;
            // Call method for enable and disable behavior of button
            display_enable(true);
            txtQuantityGoods.Enabled = true;
            loadController();
            loadCBBCommodityGoods();
            loadCBBVenderGoods();
  
        }

        private void btnUpdateGoods_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable(true);
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (goodsController.DelData(txtIdGoods.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete invoiceDetail's Goods first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            frmGoods_Load(sender, e);
        }

        private void btnSaveGoods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            if (flag == 0)
            {
                //Add
                addDataTwo(goods);
                if (goodsController.AddData(goods))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmGoods_Load(sender, e);
                display_enable(false);
            }
            else if (flag == 1)
            {
                addDataTwo(goods);
                //Update
                if (goodsController.UpdData(goods))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (flag == 2)
            {
                addDataTwo(goods);
                //Submit
                if (goodsController.UpdData(goods))
                {
                    MessageBox.Show("Submit Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Submit Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmGoods_Load(sender, e);
        }

        private void btnCancelGoods_Click(object sender, EventArgs e)
        {
            frmGoods_Load(sender, e);
            display_enable(false);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            flag = 2;

            btnSaveGoods.Enabled = true;
            btnCancelGoods.Enabled = true;
            btnAddGoods.Enabled = false;
            btnUpdateGoods.Enabled = false;
            btnDeleteGoods.Enabled = false;

            txtQuantityGoods.Enabled = true;
        }

        private void lbVNĐ_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbIDGoods_Click(object sender, EventArgs e)
        {

        }

        private void txtNameGoods_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbCommodityGoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataGoods importGoods = new importDataGoods();
            importGoods.ShowDialog();
            importGoods = null;
            this.Show();
        }
    }
}
