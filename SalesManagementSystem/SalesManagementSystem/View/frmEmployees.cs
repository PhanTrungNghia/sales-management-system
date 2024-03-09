using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagementSystem.Controller;
using SalesManagementSystem.Object;

namespace SalesManagementSystem.View
{
    public partial class frmEmployees : Form
    {

        EmployeesController employeesController = new EmployeesController();
        int flag = 0;
        private string selectedFilePath;


        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            DataTable dtEmployees = new DataTable();
            dtEmployees = employeesController.GetData();
            dgvListEmployees.DataSource = dtEmployees;
            bindDing();
        }

        void display_enable(bool e)
        {
            txtIdEmployees.Enabled = e;
            txtNameEmployees.Enabled = e;
            txtAddressEmployees.Enabled = e;
            txtHotlineEmployees.Enabled = e;
            dtpYearEmployees.Enabled = e;
            cbbSexEmployees.Enabled = e;

            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnUpdate.Enabled = !e;
            btnDelete.Enabled = !e;

        }

        void loadCBB()
        {
            cbbSexEmployees.Items.Clear();
            cbbSexEmployees.Items.Add("Nam");
            cbbSexEmployees.Items.Add("Nữ");
            // Setup first value for cbbSexClient
            cbbSexEmployees.SelectedItem = 0;
        }

        void loadController()
        {
            txtNameEmployees.Text = "";
            txtIdEmployees.Text = "";
            txtAddressEmployees.Text = "";
            txtHotlineEmployees.Text = "";
            dtpYearEmployees.Value = DateTime.Now.Date;
        }

        void addData(Employees employees)
        {
            employees.IdEmployees = txtIdEmployees.Text.Trim();
            employees.NameEmployees = txtNameEmployees.Text.Trim();
            if (cbbSexEmployees.SelectedIndex == 0)
            {
                employees.SexEmployees = "Nam";
            }
            else
            {
                employees.SexEmployees = "Nữ";
            }
            //employees.SexEmployees = cbbSexEmployees.Text.Trim();
            employees.AddressEmployees = txtAddressEmployees.Text.Trim();
            employees.HotlineEmployees = txtHotlineEmployees.Text.Trim();
            employees.YearOfBirthEmployees = dgvListEmployees.Text.Trim();
            employees.PasswordEmployees = "";
        }

        void clearData()
        {
            txtIdEmployees.Text = "";
            txtNameEmployees.Text = "";
            dtpYearEmployees.Text = DateTime.Now.Date.ToShortDateString();
            loadController();
            txtAddressEmployees.Text = "";
            txtHotlineEmployees.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = 1;
            display_enable(true);
            loadCBB();
            // Cannot update yearOfBirth from employees
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            addData(employees);
            if (flag == 0)
            {
                //Add
                if (employeesController.AddData(employees))
                {
                    MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmEmployees_Load(sender, e);
                display_enable(false);
            }
            else if(flag == 1)
            {
                //Update
                if (employeesController.UpdData(employees))
                {
                    MessageBox.Show("Update Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmEmployees_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (employeesController.DelData(txtIdEmployees.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must delete bill's employees first", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                return;
            }
            frmEmployees_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            display_enable(false);
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Cancellation confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmEmployees_Load(sender, e);
            else
                return;
        }

        private void txtHotlineEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // bindDing method for Interactive between DataGridView and Components 
        void bindDing()
        {
            txtIdEmployees.DataBindings.Clear();
            txtIdEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "idEmployees");

            txtNameEmployees.DataBindings.Clear();
            txtNameEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "nameEmployees");

            txtAddressEmployees.DataBindings.Clear();
            txtAddressEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "addressEmployees");

            txtHotlineEmployees.DataBindings.Clear();
            txtHotlineEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "hotlineEmployees");

            dtpYearEmployees.DataBindings.Clear();
            dtpYearEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "yearOfBirthEmployees");

            cbbSexEmployees.DataBindings.Clear();
            cbbSexEmployees.DataBindings.Add("Text", dgvListEmployees.DataSource, "sexEmployees");
        }


        private void txtHotlineEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                // Lưu đường dẫn tới file Excel đã chọn vào đối tượng tùy chọn
                // Hoặc thực hiện xử lý khác với file đã chọn
            }
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(selectedFilePath);
          
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            importDataEmployees importEmployess = new importDataEmployees();
            importEmployess.ShowDialog();
            importEmployess = null;
            this.Show();
        }
    }
    }
