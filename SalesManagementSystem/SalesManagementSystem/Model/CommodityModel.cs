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
    class CommodityModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
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

        public bool AddData(Commodity commodityObj)
        {
            cmd.CommandText = "insert into tb_commodity values ('" + commodityObj.IdCommodity + "',N'" +
                 commodityObj.NameCommodity + "',N'" + commodityObj.CodeCommodity + "',N'"
                 + commodityObj.CostCommodity + "',N'" + commodityObj.QuantityCommodity + "')";
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

        public bool UpdData(Commodity commodityObj)
        {
            cmd.CommandText = "Update tb_commodity set nameCommodity =  N'" + commodityObj.NameCommodity +
                "', codeCommodity = N'" + commodityObj.CodeCommodity + "', costCommodity = N'" + commodityObj.CostCommodity +
                "', quantityCommodity = N'" + commodityObj.QuantityCommodity +
                "' Where idCommodity = '" + commodityObj.IdCommodity + "'";
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
            cmd.CommandText = "delete tb_commodity where idCommodity = '" + id + "'";
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
