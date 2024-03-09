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
    class VendorController
    {
        VendorModel venderModel = new VendorModel();    

        public DataTable GetData()
        {
            return venderModel.GetData();
        }

        public bool AddData(Vendor vendorObj)
        {
            return venderModel.AddData(vendorObj);
        }

        public bool UpdData(Vendor vendorObj)
        {
            return venderModel.UpdData(vendorObj);
        }

        public bool DelData(string id)
        {
            return venderModel.DelData(id);
        }
    }
}
