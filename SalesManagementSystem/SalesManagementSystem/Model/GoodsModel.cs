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
    class GoodsModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idGoods, nameGoods, costGoods," +
                " quantityGoods, codeGoods, commodity_id, vender_id from tb_goods";
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

        public DataTable GetData(string expression)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_goods " + expression;
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

        public bool AddData(Goods goodsObj)
        {
            cmd.CommandText = "insert into tb_goods values ('" + goodsObj.IdGoods + "',N'" +
                goodsObj.NameGoods + "',N'" + goodsObj.CostGoods + "','" + goodsObj.QuantityGoods
                + "',N'" + goodsObj.CodeGoods + "','" 
                + goodsObj.Commodity_id + "','" + goodsObj.Vender_id + "')";
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

        public bool UpdData(Goods goodsObj)
        {
            cmd.CommandText = "Update tb_goods set nameGoods =  N'" + goodsObj.NameGoods +
                "', costGoods = N'" + goodsObj.CostGoods + "',quantityGoods = N'" + 
                goodsObj.QuantityGoods + "',codeGoods = N'" + goodsObj.CodeGoods +
                "',commodity_id = N'" + goodsObj.Commodity_id +
                "',vender_id = N'" + goodsObj.Vender_id + "' Where idGoods = '" + goodsObj.IdGoods + "'";
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

        public bool UpdQuantity(string idGoods, int quantity)
        {
            cmd.CommandText = "Update tb_goods set quantityGoods = " + quantity + 
                " Where idGoods = '" + idGoods + "'";
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
            cmd.CommandText = "delete tb_goods where idGoods = '" + id + "'";
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
