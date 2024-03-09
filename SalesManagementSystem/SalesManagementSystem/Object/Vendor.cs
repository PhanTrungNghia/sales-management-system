using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Vendor
    {
        int idVendor;
        string nameVendor, codeVendor;

        public Vendor()
        {

        }

        public Vendor(int idVendor, string nameVendor, string codeVendor)
        {
            this.IdVendor = idVendor;
            this.NameVendor = nameVendor;
            this.CodeVendor = codeVendor;
        }

        public int IdVendor { get => idVendor; set => idVendor = value; }
        public string NameVendor { get => nameVendor; set => nameVendor = value; }
        public string CodeVendor { get => codeVendor; set => codeVendor = value; }
    }
}
