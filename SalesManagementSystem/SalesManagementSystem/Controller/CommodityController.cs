using SalesManagementSystem.Model;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Controller
{
    class CommodityController
    {
        CommodityModel commodityModel = new CommodityModel();

        public DataTable GetData()
        {
            return commodityModel.GetData();
        }

        public bool AddData(Commodity commodityObj)
        {
            return commodityModel.AddData(commodityObj);
        }

        public bool UpdData(Commodity commodityObj)
        {
            return commodityModel.UpdData(commodityObj);
        }

        public bool DelData(string id)
        {
            return commodityModel.DelData(id);
        }
    }
}
