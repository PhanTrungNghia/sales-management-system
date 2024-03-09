using SalesManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagementSystem.Object;


namespace SalesManagementSystem.View
{
    public partial class frmClient : Form
    {
        ClientController clientController = new ClientController();
        int flag = 0;
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            DataTable dtEmployees = new DataTable();
            dtEmployees = clientController.GetData();
            dgvListClient.DataSource = dtEmployees;
            bindDing();
            display_enable(false);
        }

        // Enable and Disable behavior of buttons
        void display_enable(bool e)
        {

            txtIdClient.Enabled = e;
            txtNameClient.Enabled = e;
            txtAddressClient.Enabled = e;
            txtHotlineClient.Enabled = e;
            dtpYearClient.Enabled = e;
            cbbSexClient.Enabled = e;
            txtEmailClient.Enabled = e;
            txtScoreClient.Enabled = e;

            btnSaveClient.Enabled = e;
            btnCancelClient.Enabled = e;
            btnAddClient.Enabled = !e;
            btnUpdateClient.Enabled = !e;
            btnDeleteClient.Enabled = !e;

        }

        // Load data to Combobox Sex Client
        void loadCBB()
        {
            cbbSexClient.Items.Clear();
            cbbSexClient.Items.Add("Nam");
            cbbSexClient.Items.Add("Nữ");
            // Setup first value for cbbSexClient
            cbbSexClient.SelectedItem = 0;
        }

        // Define default value for input entries
        void loadController()
        {
            txtNameClient.Text = "";
            txtIdClient.Text = "";
            txtAddressClient.Text = "";
            txtHotlineClient.Text = "";
            txtEmailClient.Text = "";
            dtpYearClient.Value = DateTime.Now.Date;
        }

        void addData(Client client)
        {
            client.IdClient = txtIdClient.Text.Trim();
            client.NameClient = txtNameClient.Text.Trim();
            if (cbbSexClient.SelectedIndex == 0)
            {
                client.SexClient = "Nam";
            }
            else
            {
                client.SexClient = "Nữ";
            }
            //client.SexClient = cbbSexEmployees.Text.Trim();
            client.AddressClient = txtAddressClient.Text.Trim();
            client.HotlineClient = txtHotlineClient.Text.Trim();
            client.YearOfBirthClient = dgvListClient.Text;
            client.EmailClient = txtEmailClient.Text.Trim();
            client.ScoreClient = int.Parse(txtScoreClient.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            // Call method for enable and disable behavior of button
            display_enable(true);
            loadController();
            loadCBB();
            /*dgvListEmployees.Text = DateTime.Now.Date.ToShortDateString();*/
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable(true);
            loadCBB();
            //loadController();
            // Cannot update yearOfBirth from employees
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (clientController.DelData(txtIdClient.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete bill's Client first", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
            frmClient_Load(sender, e);
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            addData(client);
            if (flag == 0)
            {
                //Add
                if (clientController.AddData(client))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmClient_Load(sender, e);
                display_enable(false);
            }
            else if (flag == 1)
            {
                //Update
                if (clientController.UpdData(client))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmClient_Load(sender, e);
        }

        // Method for checking input 
        private void txtScoreClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHotlineClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // bindDing method for Interactive between DataGridView and Components 
        void bindDing()
        {
            txtIdClient.DataBindings.Clear();
            txtIdClient.DataBindings.Add("Text", dgvListClient.DataSource, "idClient");

            txtNameClient.DataBindings.Clear();
            txtNameClient.DataBindings.Add("Text", dgvListClient.DataSource, "nameClient");

            txtAddressClient.DataBindings.Clear();
            txtAddressClient.DataBindings.Add("Text", dgvListClient.DataSource, "addressClient");

            txtHotlineClient.DataBindings.Clear();
            txtHotlineClient.DataBindings.Add("Text", dgvListClient.DataSource, "hotlineClient");

            dtpYearClient.DataBindings.Clear();
            dtpYearClient.DataBindings.Add("Text", dgvListClient.DataSource, "yearOfBirthClient");

            cbbSexClient.DataBindings.Clear();
            cbbSexClient.DataBindings.Add("Text", dgvListClient.DataSource, "sexClient");

            txtEmailClient.DataBindings.Clear();
            txtEmailClient.DataBindings.Add("Text", dgvListClient.DataSource, "emailClient");

            txtScoreClient.DataBindings.Clear();
            txtScoreClient.DataBindings.Add("Text", dgvListClient.DataSource, "scoreClient");
        }


        private void txtHotlineClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Cancellation confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmClient_Load(sender, e);
            else
                return;
        }


        private void txtScoreClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbNameEmployees_Click(object sender, EventArgs e)
        {

        }

        private void lbHotlineEmployees_Click(object sender, EventArgs e)
        {

        }

        private void dtpYearEmployees_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataClient import = new importDataClient();
            import.ShowDialog();
            import = null;
            this.Show();
        }
    }
}
