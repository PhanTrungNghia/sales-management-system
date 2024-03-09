using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Model
{
    class VendorModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
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

        public bool AddData(Vendor vendorObj)
        {
            cmd.CommandText = "insert into tb_vendor values ('" + vendorObj.IdVendor + "',N'" +
                vendorObj.NameVendor + "',N'" + vendorObj.CodeVendor + "')";
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

        public bool UpdData(Vendor vendorObj)
        {
            cmd.CommandText = "Update tb_vendor set nameVendor =  N'" + vendorObj.NameVendor +
                "', codeVendor = N'" + vendorObj.CodeVendor + "' Where idVendor = '" + vendorObj.IdVendor + "'";
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

        public bool DelData(string id)
        {
            cmd.CommandText = "delete tb_vendor where idVendor = '" + id + "'";
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
