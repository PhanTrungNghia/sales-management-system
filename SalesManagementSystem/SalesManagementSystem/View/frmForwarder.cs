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
    public partial class frmForwarder : Form
    {
        int flag = 0;
        ForwarderController forwarderController = new  ForwarderController();

        public frmForwarder()
        {
            InitializeComponent();
        }

        void display_enable_forwarder(bool e)
        {
            txtNameForwarder.Enabled = e;
            txtIdForwarder.Enabled = e;
            txtCodeForwarder.Enabled = e;

            btnSaveForwarder.Enabled = e;
            btnCancelForwarder.Enabled = e;
            btnAddForwarder.Enabled = !e;
            btnDelForwarder.Enabled = !e;
            btnUpdForwarder.Enabled = !e;
        }

        void loadControllerForwarder()
        {
            txtNameForwarder.Text = "";
            txtIdForwarder.Text = "";
            txtCodeForwarder.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddForwarder_Click(object sender, EventArgs e)
        {
            flag = 0;
            display_enable_forwarder(true);
            loadControllerForwarder();
        }

        private void btnUpdForwarder_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable_forwarder(true);
        }

        private void btnDelForwarder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (forwarderController.DelData(txtIdForwarder.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete invoiceDetail's Forwarder first. Come to Management Bill and remove invoiceDetail's Forwarder", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
            frmForwarder_Load(sender, e);
        }

        void bindDingForwarder()
        {
            txtIdForwarder.DataBindings.Clear();
            txtIdForwarder.DataBindings.Add("Text", dgvListForwarder.DataSource, "idForwarder");

            txtNameForwarder.DataBindings.Clear();
            txtNameForwarder.DataBindings.Add("Text", dgvListForwarder.DataSource, "nameForwarder");

            txtCodeForwarder.DataBindings.Clear();
            txtCodeForwarder.DataBindings.Add("Text", dgvListForwarder.DataSource, "codeForwarder");
        }

        private void frmForwarder_Load(object sender, EventArgs e)
        {
            DataTable dtForwarder = new DataTable();
            dtForwarder = forwarderController.GetData();
            dgvListForwarder.DataSource = dtForwarder;

            bindDingForwarder();
            display_enable_forwarder(false);
            
        }

        void addDataForwarder(Forwarder forwarder)
        {
            forwarder.IdForwarder = int.Parse(txtIdForwarder.Text.Trim());
            forwarder.NameForwarder = txtNameForwarder.Text.Trim();
            forwarder.CodeForwarder = txtCodeForwarder.Text.Trim();
        }

        private void btnSaveForwarder_Click(object sender, EventArgs e)
        {
            Forwarder forwarder = new Forwarder();
            addDataForwarder(forwarder);
            if (flag == 0)
            {
                //Add
                if (forwarderController.AddData(forwarder))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmForwarder_Load(sender, e);
                display_enable_forwarder(false);
            }
            else if (flag == 1)
            {
                //Update
                if (forwarderController.UpdData(forwarder))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmForwarder_Load(sender, e);
        }

        private void btnCancelForwarder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Cancellation confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmForwarder_Load(sender, e);
            else
                return;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataForwarder importForwarder = new importDataForwarder();
            importForwarder.ShowDialog();
            importForwarder = null;
            this.Show();
        }
    }
}
