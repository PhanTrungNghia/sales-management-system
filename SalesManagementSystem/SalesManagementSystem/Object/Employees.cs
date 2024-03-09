using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Employees
    {
        string idEmployees, nameEmployees, sexEmployees, addressEmployees, 
            hotlineEmployees, passwordEmployees;
        string yearOfBirthEmployees, emailEmployees;
        int salaryEmployees;

        public Employees()
        {
        }

        public Employees(string idEmployees, string nameEmployees, string sexEmployees, string addressEmployees,
            string hotlineEmployees, string passwordEmployees, string yearOfBirthEmployees,
            string emailEmployees, int salaryEmployees)
        {
            this.idEmployees = idEmployees;
            this.nameEmployees = nameEmployees;
            this.sexEmployees = sexEmployees;
            this.addressEmployees = addressEmployees;
            this.hotlineEmployees = hotlineEmployees;
            this.passwordEmployees = passwordEmployees;
            this.yearOfBirthEmployees = yearOfBirthEmployees;
            this.emailEmployees = emailEmployees;
            this.salaryEmployees = salaryEmployees;
        }

        public string IdEmployees { get => idEmployees; set => idEmployees = value; }
        public string NameEmployees { get => nameEmployees; set => nameEmployees = value; }
        public string SexEmployees { get => sexEmployees; set => sexEmployees = value; }
        public string AddressEmployees { get => addressEmployees; set => addressEmployees = value; }
        public string HotlineEmployees { get => hotlineEmployees; set => hotlineEmployees = value; }
        public string PasswordEmployees { get => passwordEmployees; set => passwordEmployees = value; }
        public string YearOfBirthEmployees { get => yearOfBirthEmployees; set => yearOfBirthEmployees = value; }
        public string EmailEmployees { get => emailEmployees; set => emailEmployees = value; }
        public int SalaryEmployees { get => salaryEmployees; set => salaryEmployees = value; }
    }
}
