using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Model
{
    class BillModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select b.invoice_id, b.invoiceDate, e.idEmployees, c.idClient 
            from tb_bill b, tb_client c, tb_employees e 
            where c.idClient = b.customer_id and e.idEmployees = b.cashier_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mEx = ex.Message;
                // Dispose cmd when is in session
                cmd.Dispose();
                // Close connection to sql
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(Bill bill)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tb_bill (invoice_id, invoiceDate, cashier_id, customer_id) " +
                              "VALUES (@invoice_id, CONVERT(DATE, @invoiceDate, 101), @cashier_id, @customer_id)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@invoice_id", bill.Invoice_id);
                cmd.Parameters.AddWithValue("@invoiceDate", bill.InvoiceDate);
                cmd.Parameters.AddWithValue("@cashier_id", bill.Cashier_id);
                cmd.Parameters.AddWithValue("@customer_id", bill.Customer_id);

                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mEx = ex.Message;
                MessageBox.Show(mEx);
                return false;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
        }

        public bool DelData(string id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM tb_invoiceDetails WHERE idBillinvoiceDetails = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con.Connection;
                con.OpenConn();
                // Delete invoice details
                cmd.ExecuteNonQuery();

                // Clear the parameters before reusing the command
                cmd.Parameters.Clear();

                // Delete bill
                cmd.CommandText = "DELETE FROM tb_bill WHERE invoice_id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                string mEx = ex.Message;
                return false;
            }
        }

        public bool RemoveDataBill(string id)
        {

            cmd.CommandText = "Delete tb_invoiceDetails Where idBillinvoiceDetails = '" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mEx = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
