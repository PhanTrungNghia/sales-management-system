using SalesManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Controller
{
    class InvoiceDetailsController
    {

        InvoiceDetailsModel invoiceDetailsModel = new InvoiceDetailsModel();

        public DataTable GetDataOne(string id)
        {
            return invoiceDetailsModel.GetDataOne(id);
        }

        public bool AddData(DataTable dt)
        {
            return invoiceDetailsModel.AddData(dt);
        }

        public bool DelData(string id)
        {
            return invoiceDetailsModel.DelData(id);
        }

    }
}
