using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Commodity
    {
        int idCommodity, costCommodity, quantityCommodity;
        string nameCommodity, codeCommodity;

        public Commodity() { }

        public Commodity(int idCommodity, int costCommodity, int quantityCommodity, string nameCommodity, 
            string codeCommodity)
        {
            this.IdCommodity = idCommodity;
            this.CostCommodity = costCommodity;
            this.QuantityCommodity = quantityCommodity;
            this.NameCommodity = nameCommodity;
            this.CodeCommodity = codeCommodity;
        }

        public int IdCommodity { get => idCommodity; set => idCommodity = value; }
        public int CostCommodity { get => costCommodity; set => costCommodity = value; }
        public int QuantityCommodity { get => quantityCommodity; set => quantityCommodity = value; }
        public string NameCommodity { get => nameCommodity; set => nameCommodity = value; }
        public string CodeCommodity { get => codeCommodity; set => codeCommodity = value; }
    }
}
