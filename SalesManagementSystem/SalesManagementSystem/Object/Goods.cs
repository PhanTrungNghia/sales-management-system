using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Goods
    {
        string idGoods, nameGoods;
        int costGoods, quantityGoods;
        string codeGoods;
        int commodity_id, vender_id;

        public Goods()
        {
        }

        public Goods(string idGoods, string nameGoods, int costGoods, int quantityGoods, 
            string codeGoods, int commodity_id, int vender_id)
        {
            this.idGoods = idGoods;
            this.nameGoods = nameGoods;
            this.costGoods = costGoods;
            this.quantityGoods = quantityGoods;
            this.codeGoods = codeGoods;
            this.commodity_id = commodity_id;
            this.vender_id = vender_id;
        }

        public string CodeGoods { get => codeGoods; set => codeGoods = value; }
        public int Commodity_id { get => commodity_id; set => commodity_id = value; }
        public int Vender_id { get => vender_id; set => vender_id = value; }
        public string IdGoods { get => idGoods; set => idGoods = value; }
        public string NameGoods { get => nameGoods; set => nameGoods = value; }
        public int CostGoods { get => costGoods; set => costGoods = value; }
        public int QuantityGoods { get => quantityGoods; set => quantityGoods = value; }
    }
}

