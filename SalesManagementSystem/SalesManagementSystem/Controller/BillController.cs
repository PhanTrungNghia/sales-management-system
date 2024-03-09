using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Model;
using SalesManagementSystem.Object;

namespace SalesManagementSystem.Controller
{
    class BillController
    {
        BillModel billModel = new BillModel();                                                                                                                                                                                        

        public DataTable GetData()
        {
            return billModel.GetData();
        }
        public bool AddData(Bill billObj)
        {
            return billModel.AddData(billObj);
        }
        public bool DelData(string id)
        {
            return billModel.DelData(id);
        }
    }
}
