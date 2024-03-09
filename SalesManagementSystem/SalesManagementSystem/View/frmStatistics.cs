using SalesManagementSystem.Controller;
using SalesManagementSystem.Model;
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
    public partial class frmStatistics : Form
    {
        StatisticsController statisticsController = new StatisticsController();

        public frmStatistics()
        {
            InitializeComponent();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGoodStatistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbManagement.SelectedItem != null)
            {
                string selectedValue = cbbManagement.SelectedItem.ToString().Trim();

                DataTable dataTable = new DataTable();

                switch (selectedValue)
                {
                    case "Client":
                        dataTable = statisticsController.GetDataClient();
                        break;

                    case "Employees":
                        dataTable = statisticsController.GetDataEmployees();
                        break;

                    case "Commodity":
                        dataTable = statisticsController.GetDataCommodity();
                        break;

                    case "Vendor":
                        dataTable = statisticsController.GetDataVendor();
                        break;

                    case "Bill":
                        dataTable = statisticsController.GetDataBill();
                        break;

                    case "InvoiceDetails":
                        dataTable = statisticsController.GetDataInvoiceDetails();
                        break;

                    case "Goods":
                        dataTable = statisticsController.GetDataGoods();
                        break;

                    default:
                        // Handle unknown selected value
                        break;
                }

                dgvManagement.DataSource = dataTable;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
