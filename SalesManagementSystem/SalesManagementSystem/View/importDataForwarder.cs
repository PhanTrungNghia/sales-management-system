using ExcelDataReader;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace SalesManagementSystem.View
{
    public partial class importDataForwarder : Form
    {
        public importDataForwarder()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

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
                DapperPlusManager.Entity<Forwarder>().Table("tb_forwarder");
                List<Forwarder> forwarderList = forwarderBindingSource.DataSource as List<Forwarder>;
                if (forwarderList != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(forwarderList);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgvImportData.DataSource = dt;
            if (dt != null)
            {
                List<Forwarder> forwarderList = new List<Forwarder>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Forwarder forwarder = new Forwarder();  
                    int idForwarder;
                    if (int.TryParse(dt.Rows[i]["idForwarder"].ToString(), out idForwarder))
                    {
                        dt.Rows[i]["idForwarder"] = idForwarder;
                        forwarder.IdForwarder = idForwarder;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["idForwarder"]
                        dt.Rows[i]["idForwarder"] = 0;
                        forwarder.IdForwarder = 0;
                    }
                    forwarder.NameForwarder = dt.Rows[i]["nameForwarder"].ToString();
                    forwarder.CodeForwarder = dt.Rows[i]["codeForwarder"].ToString();
                    forwarderList.Add(forwarder);
                }
                forwarderBindingSource.DataSource = forwarderList;
            }
        }
    }
}
