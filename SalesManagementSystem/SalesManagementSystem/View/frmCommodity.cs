using SalesManagementSystem.Controller;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.View
{
    public partial class frmCommodity : Form
    {
        int flag = 0;
        CommodityController commodityController = new CommodityController();
        VendorController vendorController = new VendorController(); 

        public frmCommodity()
        {
            InitializeComponent();
        }

        void display_enable_commodity(bool e)
        {
            txtNameCommodity.Enabled = e;
            txtIdCommodity.Enabled = e;
            txtCostCommodity.Enabled = e;
            txtCodeCommodity.Enabled = e;
            txtQuantityCommodity.Enabled = e;

            btnSaveCommodity.Enabled = e;
            btnCancelCommodity.Enabled = e;
            btnAddCommodity.Enabled = !e;
            btnDelCommodity.Enabled = !e;
            btnUpdCommodity.Enabled = !e;
        }

        void display_enable_vendor(bool e)
        {
            txtNameVendor.Enabled = e;
            txtIdVendor.Enabled = e;
            txtCodeVendor.Enabled = e;

            btnSaveVendor.Enabled = e;
            btnCancelVendor.Enabled = e;
            btnAddVendor.Enabled = !e;
            btnDelVendor.Enabled = !e;
            btnUpdVendor.Enabled = !e;
        }

        // Define default value for input entries
        void loadControllerCommodity()
        {
            txtNameCommodity.Text = "";
            txtIdCommodity.Text = "0";
            txtCostCommodity.Text = "0";
            txtCodeCommodity.Text = "";
            txtQuantityCommodity.Text = "0";
        }

        void loadControllerVendor()
        {
            txtNameVendor.Text = "";
            txtIdVendor.Text = "0";
            txtCodeVendor.Text = "";
        }

        private void btnAddCommodity_Click(object sender, EventArgs e)
        {
            flag = 0;
            display_enable_commodity(true);
            loadControllerCommodity();
        }

        private void btnUpdCommodity_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable_commodity(true);
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            flag = 0;
            display_enable_vendor(true);
            loadControllerVendor();
        }

        private void btnUpdVendor_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable_vendor(true);
        }

        void addDataCommodity(Commodity commodity)
        {
            commodity.IdCommodity = int.Parse(txtIdCommodity.Text.Trim());
            commodity.NameCommodity = txtNameCommodity.Text.Trim();
            commodity.CodeCommodity = txtCodeCommodity.Text.Trim();
            commodity.CostCommodity = int.Parse(txtCostCommodity.Text.Trim()); 
            commodity.QuantityCommodity = int.Parse(txtQuantityCommodity.Text.Trim());
        }

        void addDataVerndor(Vendor vendor)
        {
            vendor.IdVendor = int.Parse(txtIdVendor.Text.Trim());
            vendor.NameVendor = txtNameVendor.Text.Trim();
            vendor.CodeVendor = txtCodeVendor.Text.Trim();
        }

        private void btnCancelCommodity_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();
            addDataCommodity(commodity);
            if (flag == 0)
            {
                //Add
                if (commodityController.AddData(commodity))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmCommonity_Load(sender, e);
                display_enable_commodity(false);
            }
            else if (flag == 1)
            {
                //Update
                if (commodityController.UpdData(commodity))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmCommonity_Load(sender, e);
        }

        void bindDingCommodity()
        {
            txtIdCommodity.DataBindings.Clear();
            txtIdCommodity.DataBindings.Add("Text", dgvListCommodity.DataSource, "idCommodity");

            txtNameCommodity.DataBindings.Clear();
            txtNameCommodity.DataBindings.Add("Text", dgvListCommodity.DataSource, "nameCommodity");

            txtCodeCommodity.DataBindings.Clear();
            txtCodeCommodity.DataBindings.Add("Text", dgvListCommodity.DataSource, "codeCommodity");

            txtCostCommodity.DataBindings.Clear();
            txtCostCommodity.DataBindings.Add("Text", dgvListCommodity.DataSource, "costCommodity");

            txtQuantityCommodity.DataBindings.Clear();
            txtQuantityCommodity.DataBindings.Add("Text", dgvListCommodity.DataSource, "quantityCommodity");;
        }

        void bindDingVendor()
        {
            txtIdVendor.DataBindings.Clear();
            txtIdVendor.DataBindings.Add("Text", dgvVendor.DataSource, "idVendor");

            txtNameVendor.DataBindings.Clear();
            txtNameVendor.DataBindings.Add("Text", dgvVendor.DataSource, "nameVendor");

            txtCodeVendor.DataBindings.Clear();
            txtCodeVendor.DataBindings.Add("Text", dgvVendor.DataSource, "codeVendor");
        }

        private void frmCommonity_Load(object sender, EventArgs e)
        {
            DataTable dtCommodity = new DataTable();
            dtCommodity = commodityController.GetData();
            dgvListCommodity.DataSource = dtCommodity;

            DataTable dtVendor = new DataTable();
            dtVendor = vendorController.GetData();
            dgvVendor.DataSource = dtVendor;

            bindDingCommodity();
            display_enable_commodity(false);
            bindDingVendor();
            display_enable_vendor(false);
        }

        private void btnDelCommodity_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (commodityController.DelData(txtIdCommodity.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete Goods's Commodity first", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
            frmCommonity_Load(sender, e);
        }

        private void btnDelVendor_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (vendorController.DelData(txtIdVendor.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete Goods's Vendor first", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
            frmCommonity_Load(sender, e);
        }

        private void btnCancelCommodity_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Cancellation confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmCommonity_Load(sender, e);
            else
                return;
        }

        private void btnSaveVendor_Click(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            addDataVerndor(vendor);
            if (flag == 0)
            {
                //Add
                if (vendorController.AddData(vendor))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmCommonity_Load(sender, e);
                display_enable_vendor(false);
            }
            else if (flag == 1)
            {
                //Update
                if (vendorController.UpdData(vendor))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmCommonity_Load(sender, e);
        }

        private void btnCancelVendor_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Cancellation confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmCommonity_Load(sender, e);
            else
                return;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtNameVendor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataCommodity importCommodity = new importDataCommodity();
            importCommodity.ShowDialog();
            importCommodity = null;
            this.Show();
        }

        private void btnExportVendor_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataVendor importVendor = new importDataVendor();
            importVendor.ShowDialog();
            importVendor = null;
            this.Show();
        }
    }
}
