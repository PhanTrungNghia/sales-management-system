using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Forwarder
    {
        string nameForwarder, codeForwarder;
        int idForwarder;

        public string NameForwarder { get => nameForwarder; set => nameForwarder = value; }
        public string CodeForwarder { get => codeForwarder; set => codeForwarder = value; }
        public int IdForwarder { get => idForwarder; set => idForwarder = value; }
    }
}
