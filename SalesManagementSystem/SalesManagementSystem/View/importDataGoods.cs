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
    public partial class importDataGoods : Form
    {
        public importDataGoods()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgvImportData.DataSource = dt;
            if (dt != null)
            {
                List<Goods> goodsList = new List<Goods>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Goods goods = new Goods();
                    goods.IdGoods = dt.Rows[i]["idGoods"].ToString();
                    goods.NameGoods = dt.Rows[i]["nameGoods"].ToString();
                    int costGoods;
                    if (int.TryParse(dt.Rows[i]["costGoods"].ToString(), out costGoods))
                    {
                        dt.Rows[i]["costGoods"] = costGoods;
                        goods.CostGoods = costGoods;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["costGoods"]
                        dt.Rows[i]["costGoods"] = 0;
                        goods.CostGoods = 0;
                    }
                    int quantityGoods;
                    if (int.TryParse(dt.Rows[i]["quantityGoods"].ToString(), out quantityGoods))
                    {
                        dt.Rows[i]["quantityGoods"] = quantityGoods;
                        goods.QuantityGoods = quantityGoods;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["costGoods"]
                        dt.Rows[i]["quantityGoods"] = 0;
                        goods.QuantityGoods = 0;
                    }
                    int commodity_id;
                    if (int.TryParse(dt.Rows[i]["commodity_id"].ToString(), out commodity_id))
                    {
                        dt.Rows[i]["commodity_id"] = commodity_id;
                        goods.Commodity_id = commodity_id;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["costGoods"]
                        dt.Rows[i]["commodity_id"] = 0;
                        goods.Commodity_id = 0;
                    }
                    int vender_id;
                    if (int.TryParse(dt.Rows[i]["vender_id"].ToString(), out vender_id))
                    {
                        dt.Rows[i]["vender_id"] = vender_id;
                        goods.Vender_id = vender_id;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["costGoods"]
                        dt.Rows[i]["vender_id"] = 0;
                        goods.Vender_id = 0;
                    }
                    goods.CodeGoods = dt.Rows[i]["codeGoods"].ToString();
                    goodsList.Add(goods);
                }
                goodsBindingSource.DataSource = goodsList;
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
                DapperPlusManager.Entity<Goods>().Table("tb_goods");
                List<Goods> goodsList = goodsBindingSource.DataSource as List<Goods>;
                if (goodsList != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(goodsList);
                    }
                }
                MessageBox.Show("Finish !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvImportData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importDataGoods_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
