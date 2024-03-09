using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SalesManagementSystem.Object;



namespace SalesManagementSystem.Model
{
    class EmployeesModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
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

        public bool AddData(Employees employeeObj)
        {
            cmd.CommandText = "insert into tb_employees values ('" + employeeObj.IdEmployees + "',N'" + 
                employeeObj.NameEmployees + "',N'" + employeeObj.SexEmployees + "',CONVERT(DATE,'" + 
                employeeObj.YearOfBirthEmployees + "',103),N'" + employeeObj.AddressEmployees + "','" + 
                employeeObj.HotlineEmployees + "','" + employeeObj.SalaryEmployees + "','" 
                + employeeObj.EmailEmployees + "','" + employeeObj.PasswordEmployees + "')";
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

        public bool UpdData(Employees employeeObj)
        {
            cmd.CommandText = "Update tb_employees set nameEmployees =  N'" + employeeObj.NameEmployees +
                "', sexEmployees = N'" + employeeObj.SexEmployees + "', yearOfBirthEmployees = CONVERT(DATE,'" + employeeObj.YearOfBirthEmployees + "',103), addressEmployees = N'" +
                employeeObj.AddressEmployees + "',hotlineEmployees = '" + 
                employeeObj.HotlineEmployees + "' Where idEmployees = '" + employeeObj.IdEmployees + "'";
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

        public bool UpdPassword(Employees employeeObj)
        {
            cmd.CommandText = "Update tb_employees set passwordEmployees ='" + employeeObj.PasswordEmployees + 
                "' Where idEmployees = '" + employeeObj.IdEmployees + "'";
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
            cmd.CommandText = "delete tb_employees where idEmployees = '" + id + "'";
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
