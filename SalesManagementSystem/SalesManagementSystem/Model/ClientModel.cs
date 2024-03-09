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
    class ClientModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select idClient, nameClient, sexClient, yearOfBirthClient," +
                " addressClient, hotlineClient, emailClient, scoreClient from tb_client";
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

        public bool AddData(Client clientObj)
        {
            cmd.CommandText = "insert into tb_client values ('" + clientObj.IdClient + "',N'" +
                clientObj.NameClient + "',N'" + clientObj.SexClient + "',CONVERT(DATE,'" +
                clientObj.YearOfBirthClient + "',103),N'" + clientObj.AddressClient + "','" +
                clientObj.HotlineClient + "','" + clientObj.ScoreClient + "','" + clientObj.EmailClient + "')";
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

        public bool UpdData(Client clientObj)
        {
            cmd.CommandText = "Update tb_client set nameClient =  N'" + clientObj.NameClient +
                "', sexClient = N'" + clientObj.SexClient + "', yearOfBirthClient = CONVERT(DATE,'" + clientObj.YearOfBirthClient + "',103), addressClient = N'" +
                clientObj.AddressClient + "',hotlineClient = '" +
                clientObj.HotlineClient + "',scoreClient = '" +
                clientObj.ScoreClient + "',emailClient = '" +
                clientObj.EmailClient + "' Where idClient = '" + clientObj.IdClient + "'";
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

        public bool UpdScore(Client clientObj)
        {
            cmd.CommandText = "Update tb_employees set scoreClient ='" + clientObj.ScoreClient +
                "' Where idClient = '" + clientObj.IdClient + "'";
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
            cmd.CommandText = "delete tb_client where idClient = '" + id + "'";
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
