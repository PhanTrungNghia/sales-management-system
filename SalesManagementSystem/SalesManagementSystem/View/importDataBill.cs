using ExcelDataReader;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace SalesManagementSystem.View
{
    public partial class importDataBill : Form
    {
        public importDataBill()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgvImportData.DataSource = dt;
            if (dt != null)
            {
                List<Bill> billList = new List<Bill>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Bill bill = new Bill();
                    bill.Invoice_id = dt.Rows[i]["invoice_id"].ToString();
                    bill.InvoiceDate = dt.Rows[i]["invoiceDate"].ToString();
                    bill.Cashier_id = dt.Rows[i]["cashier_id"].ToString();
                    bill.Customer_id = dt.Rows[i]["customer_id"].ToString();
                    billList.Add(bill);
                }
                billBindingSource.DataSource = billList;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                            });
                            tableCollection = result.Tables;
                            cbbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbbSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-6R0F6DU;Initial Catalog=sales_management_system;Integrated Security=True";
                DapperPlusManager.Entity<Bill>().Table("tb_bill");
                List<Bill> vendorList = billBindingSource.DataSource as List<Bill>;
                if (vendorList != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(vendorList);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importDataBill_Load(object sender, EventArgs e)
        {

        }
    }
}
