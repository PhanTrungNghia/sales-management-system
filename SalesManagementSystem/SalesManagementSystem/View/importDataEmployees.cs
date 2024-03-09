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
    public partial class importDataEmployees : Form
    {
        public importDataEmployees()
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
                DapperPlusManager.Entity<Employees>().Table("tb_employees");
                List<Employees> employeesList = employeesBindingSource.DataSource as List<Employees>;
                if (employeesList != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(employeesList);
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
                List<Employees> employeesList = new List<Employees>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employees employees = new Employees();
                    employees.IdEmployees = dt.Rows[i]["idEmployees"].ToString();
                    employees.NameEmployees = dt.Rows[i]["nameEmployees"].ToString();
                    employees.SexEmployees = dt.Rows[i]["sexEmployees"].ToString();
                    employees.YearOfBirthEmployees = dt.Rows[i]["yearOfBirthEmployees"].ToString();
                    employees.AddressEmployees = dt.Rows[i]["addressEmployees"].ToString();
                    employees.HotlineEmployees = dt.Rows[i]["hotlineEmployees"].ToString();
                    int salaryEmployees;
                    if (int.TryParse(dt.Rows[i]["salaryEmployees"].ToString(), out salaryEmployees))
                    {
                        dt.Rows[i]["salaryEmployees"] = salaryEmployees;
                        employees.SalaryEmployees = salaryEmployees;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi chuỗi sang kiểu int
                        // Ví dụ: Gán giá trị mặc định cho dt.Rows[i]["salaryEmployees"]
                        dt.Rows[i]["salaryEmployees"] = 0;
                        employees.SalaryEmployees = 0;
                    }
                    employees.EmailEmployees = dt.Rows[i]["emailEmployees"].ToString();
                    employees.PasswordEmployees = dt.Rows[i]["passwordEmployees"].ToString();
                    employeesList.Add(employees);
                }
                employeesBindingSource.DataSource = employeesList;
            }
        }
    }
}
