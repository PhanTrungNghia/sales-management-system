using SalesManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Controller
{
    internal class StatisticsController
    {
        StatisticsModel statisticsModel = new StatisticsModel();

        public DataTable GetDataClient()
        {
            return statisticsModel.GetDataClient();
        }

        public DataTable GetDataEmployees()
        {
            return statisticsModel.GetDataEmployees();
        }

        public DataTable GetDataBill()
        {
            return statisticsModel.GetDataBill();
        }

        public DataTable GetDataInvoiceDetails()
        {
            return statisticsModel.GetDataInvoiceDetails();
        }

        public DataTable GetDataCommodity()
        {
            return statisticsModel.GetDataCommodity();
        }

        public DataTable GetDataVendor()
        {
            return statisticsModel.GetDataVendor();
        }

        public DataTable GetDataGoods()
        {
            return statisticsModel.GetDataGoods();
        }
    }
}
