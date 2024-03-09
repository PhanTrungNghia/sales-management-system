using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Login
    {
        string userName, password;
        private static string sayHello ;

        public Login()
        {
        }

        public Login(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public static string SayHello { get => sayHello; set => sayHello = value; }
    }
}
