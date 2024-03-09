using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagementSystem.Controller;

namespace SalesManagementSystem.View
{

    public partial class frmLogin : Form
    {
        LoginController loginController = new LoginController();
        private bool isFormClosing = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        // Method for handling behavior when we click button x above right corner bar of application 
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = loginController.GetData();
            bool found = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtUserName.Text.Equals(dt.Rows[i][0].ToString())
                && txtPassword.Text.Equals(dt.Rows[i][1].ToString()))
                {
                    this.Hide();
                    frmMain form4 = new frmMain();
                    form4.ShowDialog();
                    form4 = null;
                    this.Show();
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    Login.SayHello = dt.Rows[i][0].ToString();
                    break;
                }

                if (isFormClosing)
                {
                    return; // Thoát khỏi vòng lặp nếu form đang đóng
                }
            }

            if (!found)
            {
                MessageBox.Show("Incorrect User Name and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Empty Method
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
