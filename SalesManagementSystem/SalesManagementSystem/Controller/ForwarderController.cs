using SalesManagementSystem.Model;
using SalesManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SalesManagementSystem.Controller
{
    class ForwarderController
    {
        ForwarderModel forwarderModel = new ForwarderModel();

        public DataTable GetData()
        {
            return forwarderModel.GetData();
        }

        public bool AddData(Forwarder forwarderObj)
        {
            return forwarderModel.AddData(forwarderObj);
        }

        public bool UpdData(Forwarder forwarderObj)
        {
            return forwarderModel.UpdData(forwarderObj);
        }

        public bool DelData(string id)
        {
            return forwarderModel.DelData(id);
        }
    }
}
