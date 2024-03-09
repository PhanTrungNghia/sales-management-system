using SalesManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace SalesManagementSystem.Controller
{
    class LoginController
    {
        LoginModel loginModel = new LoginModel ();

        public DataTable GetData()
        {
            return loginModel.GetData();
        }
    }
}
