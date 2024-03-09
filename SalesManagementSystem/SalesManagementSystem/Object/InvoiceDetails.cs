using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class InvoiceDetails
    {
        string idBillinvoiceDetail, product_id_invoiceDetails;
        int quantityinvoiceDetail, costinvoiceDetail;

        public InvoiceDetails()
        {
        }

        public InvoiceDetails(string idBillinvoiceDetail, string product_id_invoiceDetails,
            int quantityinvoiceDetail, int costinvoiceDetail)
        {
            this.idBillinvoiceDetail = idBillinvoiceDetail;
            this.product_id_invoiceDetails = product_id_invoiceDetails;
            this.quantityinvoiceDetail = quantityinvoiceDetail;
            this.costinvoiceDetail = costinvoiceDetail;
        }

        public string IdBillinvoiceDetail { get => idBillinvoiceDetail; set => idBillinvoiceDetail = value; }
        public string Product_id_invoiceDetails { get => product_id_invoiceDetails; set => product_id_invoiceDetails = value; }
        public int QuantityinvoiceDetail { get => quantityinvoiceDetail; set => quantityinvoiceDetail = value; }
        public int CostinvoiceDetail { get => costinvoiceDetail; set => costinvoiceDetail = value; }
    }
}
