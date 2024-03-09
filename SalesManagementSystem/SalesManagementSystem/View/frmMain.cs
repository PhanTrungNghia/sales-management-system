using SalesManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagementSystem.Controller;
using SalesManagementSystem.Object;

namespace SalesManagementSystem
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbSayHello.Text = Login.SayHello;
        }

        private void btnEmployeesManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees form1 = new frmEmployees();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient form2 = new frmClient();
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }

        private void btnBillManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBill form3 = new frmBill();
            form3.ShowDialog();
            form3 = null;
            this.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStatistics frmStatistics = new frmStatistics();
            frmStatistics.ShowDialog();
            frmStatistics = null;
            this.Show();
        }

        private void btnGoodsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGoods frmGoodsManagement = new frmGoods();
            frmGoodsManagement.ShowDialog();
            frmGoodsManagement = null;
            this.Show();
        }


        private void btnComVenManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCommodity frmCommonityManagement = new frmCommodity();
            frmCommonityManagement.ShowDialog();
            frmCommonityManagement = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForwarder frmForwarderManagement = new frmForwarder();
            frmForwarderManagement.ShowDialog();
            frmForwarderManagement = null;
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
