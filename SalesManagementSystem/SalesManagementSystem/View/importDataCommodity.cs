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
    public partial class importDataCommodity : Form
    {
        public importDataCommodity()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

        private void importDataCommoditycs_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_Click_1(object sender, EventArgs e)
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

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-6R0F6DU;Initial Catalog=sales_management_system;Integrated Security=True";
                DapperPlusManager.Entity<Commodity>().Table("tb_commodity");
                List<Commodity> commodityList = commodityBindingSource.DataSource as List<Commodity>;
                if (commodityList != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(commodityList);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbSheet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgvImportData.DataSource = dt;
            if (dt != null)
            {
                List<Commodity> commodityList = new List<Commodity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Commodity commodity = new Commodity();
                    int idCommodity;
                    if (int.TryParse(dt.Rows[i]["idCommodity"].ToString(), out idCommodity))
                    {
                        dt.Rows[i]["idCommodity"] = idCommodity;
                        commodity.IdCommodity = idCommodity;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["idCommodity"]
                        dt.Rows[i]["idCommodity"] = 0;
                        commodity.IdCommodity = 0;
                    }
                    commodity.NameCommodity = dt.Rows[i]["nameCommodity"].ToString();
                    commodity.CodeCommodity = dt.Rows[i]["codeCommodity"].ToString();
                    int costCommodity;
                    if (int.TryParse(dt.Rows[i]["costCommodity"].ToString(), out costCommodity))
                    {
                        dt.Rows[i]["costCommodity"] = costCommodity;
                        commodity.CostCommodity = costCommodity;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["ScoreClient"]
                        dt.Rows[i]["costCommodity"] = 0;
                        commodity.CostCommodity = 0;
                    }
                    int quantityCommodity;
                    if (int.TryParse(dt.Rows[i]["quantityCommodity"].ToString(), out quantityCommodity))
                    {
                        dt.Rows[i]["quantityCommodity"] = quantityCommodity;
                        commodity.QuantityCommodity = quantityCommodity;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["ScoreClient"]
                        dt.Rows[i]["quantityCommodity"] = 0;
                        commodity.QuantityCommodity = 0;
                    }
                    commodityList.Add(commodity);
                }
                commodityBindingSource.DataSource = commodityList;
            }
        }
    }
}
