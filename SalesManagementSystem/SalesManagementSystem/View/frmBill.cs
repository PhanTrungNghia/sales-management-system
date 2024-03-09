using SalesManagementSystem.Controller;
using SalesManagementSystem.Object;
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
    public partial class frmBill : Form
    {
        // Khai báo biến totalAmount để quản lý số lượng kho hàng goods
        private int totalAmount;
        InvoiceDetailsController invoiceDetailsController = new InvoiceDetailsController();
        GoodsController goodsController = new GoodsController();
        DataTable dtInvoiceDetail = new DataTable
        {
            Columns =
    {
        new DataColumn("Id Bill", typeof(string)),
        new DataColumn("Goods", typeof(int)),
        new DataColumn("Quantity", typeof(int)),
        new DataColumn("Price", typeof(int)),
        new DataColumn("Forwarder", typeof(string)),
        new DataColumn("Total Amount", typeof(int)),
    }
        };
        BillController billController = new BillController();

        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            display_enable(false);
            DataTable dt = new System.Data.DataTable();
            dt = billController.GetData();
            dgvListBill.DataSource = dt;
            loadCBBGoodsInvoiceDetails();
            bingding();
            txtInvoiceDateBill.Enabled = false;
            // Cập nhật giá trị cho totalAmount
            //totalAmount = goodsController.GetTotalQuantity();
        }

        // Enable and Disable behavior of buttons
        void display_enable(bool e)
        {
            txtInvoiceIdBill.Enabled = e;
            cbbCashierBill.Enabled = e;
            cbbCustomerBill.Enabled = e;

            btnSaveBill.Enabled = e;
            btnCancelBill.Enabled = e;
            btnThreeDotBill.Enabled = e;
            btnAddBill.Enabled = !e;
            btnDeleteBill.Enabled = !e;
            btnPrintBill.Enabled = !e;
            btnAddInvoiceDetails.Enabled = e;
            btnRemoveInvoiceDetails.Enabled = e;
        }

        void loadCBBClientBill()
        {
            ClientController clientController = new ClientController();
            cbbCustomerBill.DataSource = clientController.GetData();
            // Input value from tb_client
            cbbCustomerBill.DisplayMember = "idClient";
            // Value of columns idClient
            cbbCustomerBill.ValueMember = "idClient";
            cbbCustomerBill.SelectedIndex = 0;
        }

        void loadCBBBillerBill()
        {
            EmployeesController employeesController = new EmployeesController();
            cbbCashierBill.DataSource = employeesController.GetData();
            // Input value from tb_employees
            cbbCashierBill.DisplayMember = "idEmployees";
            // Value of columns idEmployees
            cbbCashierBill.ValueMember = "idEmployees";
            cbbCashierBill.SelectedIndex = 0;
        }

        void loadCBBForwarderBill()
        {
            ForwarderController forwarderController = new ForwarderController();
            cbbForwarder.DataSource = forwarderController.GetData();
            // Input value from tb_employees
            cbbForwarder.DisplayMember = "idForwarder";
            // Value of columns idEmployees
            cbbForwarder.ValueMember = "idForwarder";
        }

        void loadCBBGoodsInvoiceDetails()
        {
            cbbProductInvoiceDetails.DataSource = goodsController.GetData();
            cbbProductInvoiceDetails.DisplayMember = "nameGoods";
            cbbProductInvoiceDetails.ValueMember = "idGoods";
        }

        void clearData()
        {
            txtInvoiceIdBill.Text = "";
            txtInvoiceDateBill.Text = DateTime.Now.Date.ToShortDateString();
            loadCBBBillerBill();
            loadCBBClientBill();
            loadCBBGoodsInvoiceDetails();
            loadCBBForwarderBill();
        }

        private void bingding()
        {
            try
            {
                txtInvoiceIdBill.DataBindings.Clear();
                txtInvoiceIdBill.DataBindings.Add("Text", dgvListBill.DataSource, "invoice_id");

                txtInvoiceDateBill.DataBindings.Clear();
                txtInvoiceDateBill.DataBindings.Add("Text", dgvListBill.DataSource, "invoiceDate");

                cbbCashierBill.DataBindings.Clear();
                cbbCashierBill.DataBindings.Add("Text", dgvListBill.DataSource, "idEmployees");

                cbbCustomerBill.DataBindings.Clear();
                cbbCustomerBill.DataBindings.Add("Text", dgvListBill.DataSource, "idClient");
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmBill form3 = new frmBill();
            form3.ShowDialog();
            form3 = null;
            this.Show();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            display_enable(true);
            clearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInvoiceDateBill.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you delete a bill, the invoice details of that bill will also be deleted.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Delete
                if (billController.DelData(txtInvoiceIdBill.Text.Trim()))
                {
                    MessageBox.Show("Delete Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);     
                }
                else
                {
                    MessageBox.Show("You must remove invoiceDeatails's bill first", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmBill_Load(sender, e);
        }

        Bill addData(Bill billObj)
        {
            billObj.Invoice_id = txtInvoiceIdBill.Text.Trim();
            billObj.InvoiceDate = txtInvoiceDateBill.Text.Trim();
            billObj.Cashier_id = cbbCashierBill.SelectedValue.ToString();
            billObj.Customer_id = cbbCustomerBill.SelectedValue.ToString();

            return billObj;
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            Bill billObj = new Bill();
            Bill billObj_new = this.addData(billObj);

            if (billController.AddData(billObj_new))
            {
                try
                {
                    //totalAmount -= int.Parse(txtQuantityInvoiceDetails.Text.Trim());
                    if (invoiceDetailsController.AddData(dtInvoiceDetail) && goodsController.UpdQuantity(dtInvoiceDetail))
                    {
                        MessageBox.Show("Add Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmBill_Load(sender, e);
        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel what you're doing?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmBill_Load(sender, e);
            else
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upgraded function");
        }

        // Method for checking Rows of Goods is empty whether or not
        private bool checkQuantity(string idGoods, int quantity)
        {
            DataTable dt = new DataTable();
            cbbProductInvoiceDetails.DataSource = goodsController.GetData();
            string selectedProduct = cbbProductInvoiceDetails.Text;
            dt = goodsController.GetData("WHERE idGoods = '" + selectedProduct + "' AND quantityGoods >= " + quantity);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // Method for checking if Goods is exist in InvoiceDetail whether or not
        private bool checkIdGoodsInListInvoiceDetail(string idGoods)
        {
            for (int i = 0; i < dtInvoiceDetail.Rows.Count; i++)
                if (dtInvoiceDetail.Rows[i][1].ToString() == idGoods)
                    return true;
            return false;
        }

        // Method for updating quantity of goods and caculating total price of goods
        private void updateQuantity(string idGoods, int quantity)
        {
            for (int i = 0; i < dtInvoiceDetail.Rows.Count; i++)
                if (dtInvoiceDetail.Rows[i][0].ToString() == idGoods)
                {
                    int soluong = int.Parse(dtInvoiceDetail.Rows[i][2].ToString()) + quantity;
                    if(soluong > 0)
                    {
                        dtInvoiceDetail.Rows[i][2] = soluong;
                    }
                    else if(soluong <= 0){
                        dtInvoiceDetail.Rows[i][3] = 0;
                    }
                    double dongia = double.Parse(dtInvoiceDetail.Rows[i][4].ToString());
                    dtInvoiceDetail.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }

        // Method for adding InvoiceDetails for Bill
        private void btnAddInvoiceDetails_Click(object sender, EventArgs e)
        {

            DataRow dr = dtInvoiceDetail.NewRow();
            dr[0] = txtInvoiceIdBill.Text.Trim();
            dr[1] = cbbProductInvoiceDetails.SelectedValue.ToString();
            DataTable dt = new DataTable();
            string selectedProduct = dr[1].ToString();
            dt = goodsController.GetData("WHERE idGoods = '" + selectedProduct + "' AND quantityGoods >= " + txtQuantityInvoiceDetails.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Stocking");
            }
            else if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Out of stock " + dt.Rows.Count + "\n" +
                    "Request to check the quantity of goods in stock: ");
            }
            if (dt.Rows.Count > 0)
            {
                dr[2] = txtQuantityInvoiceDetails.Text;
            }
            else if (dt.Rows.Count <= 0)
            {
                dr[2] = 0;
            }               
            dr[3] = txtPriceInvoiceDetails.Text;
            dr[4] = cbbForwarder.SelectedValue.ToString();
            dr[5] = (double.Parse(cbbProductInvoiceDetails.SelectedValue.ToString())
                * int.Parse(txtQuantityInvoiceDetails.Text)).ToString();
            dtInvoiceDetail.Rows.Add(dr);
            dataGridView1.DataSource = dtInvoiceDetail;
        }

        // Behavior when choose value from cbbGoodsInvoiceDetails
        private void cbbGoodsInvoiceDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = goodsController.GetData("Where idGoods = '" + cbbProductInvoiceDetails.SelectedValue.ToString() + "'");

            if (dt != null && dt.Rows.Count > 0)
            {
                double cost = double.Parse(dt.Rows[0][2].ToString());
                txtPriceInvoiceDetails.Text = (cost * 1.1).ToString();
                double price;
                int quantity;
                if (double.TryParse(txtPriceInvoiceDetails.Text, out price) && int.TryParse(txtQuantityInvoiceDetails.Text, out quantity))
                {
                    lbTotal.Text = (price * quantity).ToString();
                }
            }
        }

        private void cbbBillersBill_TextChanged(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            dt = invoiceDetailsController.GetDataOne(txtInvoiceIdBill.Text.Trim());
            dataGridView1.DataSource = dt;*/
        }

        private void txtQuantityInvoiceDetails_TextChanged(object sender, EventArgs e)
        {
            double price;
            int quantity;
            if (double.TryParse(txtPriceInvoiceDetails.Text, out price) && int.TryParse(txtQuantityInvoiceDetails.Text, out quantity))
            {
                lbTotal.Text = (price * quantity).ToString();
            }
            else
            {
                // Xử lý lỗi khi chuỗi không thể chuyển đổi thành kiểu dữ liệu tương ứng
                // Ví dụ: Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Error");
            }
        }

        private void btnRemoveInvoiceDetails_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Delete
                if (invoiceDetailsController.DelData(txtInvoiceIdBill.Text.Trim()))
                {
                    MessageBox.Show("Remove Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Remove Fail", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
            frmBill_Load(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            importDataBill importBill = new importDataBill();
            importBill.ShowDialog();
            importBill = null;
            this.Show();
        }

        // Emplty Method
        private void txtBillerBill_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdBill_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbClientBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPriceInvoiceDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListGoodsInvoiceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbBillersBill_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
