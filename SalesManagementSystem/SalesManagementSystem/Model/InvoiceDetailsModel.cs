using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Model
{
    class InvoiceDetailsModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetDataOne(string id)
        {

            DataTable dt = new DataTable();
            cmd.CommandText = @"select ivd.idBillinvoiceDetails, g.idGoods Goods, ivd.quantityinvoiceDetails
            , ivd.costinvoiceDetails, ivd.quantityinvoiceDetails * ivd.costinvoiceDetails TotalAmount 
            from tb_invoiceDetails ivd, tb_goods g 
            where ivd.product_id_invoiceDetails = g.idGoods and invoice_id = '" + id + "'";
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
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;

        }

        public bool AddData(DataTable dt)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "insert into tb_invoiceDetails values ('" + dt.Rows[i][0].ToString() 
                        + "','" + dt.Rows[i][1].ToString() + "'," + dt.Rows[i][2].ToString() 
                        + "," + dt.Rows[i][3].ToString() + "," + dt.Rows[i][4].ToString() + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Connection;
                    con.OpenConn();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string id)
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
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
