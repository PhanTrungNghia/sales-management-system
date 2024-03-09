using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ExcelDataReader;
using SalesManagementSystem.Object;
using Z.Dapper.Plus;

namespace SalesManagementSystem.View
{
    public partial class importDataClient : Form
    {
        public importDataClient()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtName.Text = openFileDialog.FileName; 
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}

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

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgvImportData.DataSource = dt;
            if(dt != null)
            {
                List<Client> clientList = new List<Client>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Client client = new Client();
                    client.IdClient = dt.Rows[i]["idClient"].ToString();
                    client.NameClient = dt.Rows[i]["nameClient"].ToString();
                    client.SexClient = dt.Rows[i]["sexClient"].ToString();
                    client.YearOfBirthClient = dt.Rows[i]["yearOfBirthClient"].ToString();
                    client.AddressClient = dt.Rows[i]["addressClient"].ToString();
                    client.HotlineClient = dt.Rows[i]["hotlineClient"].ToString();
                    int scoreClient;
                    if (int.TryParse(dt.Rows[i]["scoreClient"].ToString(), out scoreClient))
                    {
                        dt.Rows[i]["scoreClient"] = scoreClient;
                        client.ScoreClient = scoreClient;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["ScoreClient"]
                        dt.Rows[i]["scoreClient"] = 0;
                        client.ScoreClient = 0;
                    }
                    client.EmailClient = dt.Rows[i]["emailClient"].ToString();
                    clientList.Add(client);
                }
                clientBindingSource.DataSource = clientList;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-6R0F6DU;Initial Catalog=sales_management_system;Integrated Security=True";
                DapperPlusManager.Entity<Client>().Table("tb_client");
                List<Client> clientList = clientBindingSource.DataSource as List<Client>;
                if(clientList != null)
                {
                    using(IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(clientList);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgvImportData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importDataClient_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
