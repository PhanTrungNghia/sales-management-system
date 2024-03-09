using SalesManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Object;


namespace SalesManagementSystem.Controller
{
     class EmployeesController
    {
        EmployeesModel employeesModel = new EmployeesModel();
        public DataTable GetData()
        {
            return employeesModel.GetData();
        }
        public bool AddData (Employees employeeObj)
        {
            return employeesModel.AddData(employeeObj);
        }
        public bool UpdData (Employees employeeObj)
        {
            return employeesModel.UpdData(employeeObj);
        }
        public bool UpdPassword (Employees employeeObj)
        {
            return employeesModel.UpdPassword(employeeObj);
        }
        public bool DelData (string id)
        {
            return employeesModel.DelData(id);
        }
    }
}
