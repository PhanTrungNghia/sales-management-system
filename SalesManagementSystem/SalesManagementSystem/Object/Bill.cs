using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Bill
    {
        string invoice_id, invoiceDate, cashier_id, customer_id;

        public Bill()
        {
        }

        public Bill(string invoice_id, string invoiceDate, string cashier_id, string customer_id)
        {
            this.invoice_id = invoice_id;
            this.invoiceDate = invoiceDate;
            this.cashier_id = cashier_id;
            this.customer_id = customer_id;
        }

        public string Invoice_id { get => invoice_id; set => invoice_id = value; }
        public string InvoiceDate { get => invoiceDate; set => invoiceDate = value; }
        public string Cashier_id { get => cashier_id; set => cashier_id = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }

        public string toString()
        {
            return "Id: " + invoice_id + ", Date: " + InvoiceDate +
                ", Cashier_id: " + cashier_id + ", Customer_id: " + 
                customer_id + ".";
        }
    }
}
