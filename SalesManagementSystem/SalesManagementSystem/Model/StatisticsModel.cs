using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SalesManagementSystem.Model
{
    class StatisticsModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetDataClient()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idClient, nameClient, sexClient, yearOfBirthClient," +
                " addressClient, hotlineClient, emailClient, scoreClient  from tb_client";
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

        public DataTable GetDataEmployees()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idEmployees, nameEmployees, sexEmployees, yearOfBirthEmployees," +
                " addressEmployees, hotlineEmployees  from tb_employees";
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

        public DataTable GetDataBill()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select b.invoice_id, b.invoiceDate, e.nameEmployees, c.nameClient 
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

        public DataTable GetDataInvoiceDetails()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ivd.idBillinvoiceDetails, g.nameGoods Goods, ivd.quantityinvoiceDetails
            , ivd.costinvoiceDetails, ivd.quantityinvoiceDetails * ivd.costinvoiceDetails TotalAmount 
            from tb_invoiceDetails ivd, tb_goods g 
            where ivd.product_id_invoiceDetails = g.idGoods";
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

        public DataTable GetDataCommodity()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idCommodity, nameCommodity, codeCommodity," +
                " costCommodity, quantityCommodity from tb_commodity";
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

        public DataTable GetDataVendor()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idVendor, nameVendor, codeVendor from tb_vendor";
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

        public DataTable GetDataGoods()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_goods";
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
    }
}
