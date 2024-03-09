using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementSystem.Model;
using System.Data;
using SalesManagementSystem.Object;

namespace SalesManagementSystem.Controller
{
    class ClientController
    {

        ClientModel clientModel = new ClientModel();

        public DataTable GetData()
        {
            return clientModel.GetData();
        }

        public bool AddData(Client clientObj)
        {
            return clientModel.AddData(clientObj);
        }

        public bool UpdData(Client clientObj)
        {
            return clientModel.UpdData(clientObj);
        }

        public bool UpdScore(Client clientObj)
        {
            return clientModel.UpdScore(clientObj);
        }

        public bool DelData(string id)
        {
           return clientModel.DelData(id);
        }
    }
}
