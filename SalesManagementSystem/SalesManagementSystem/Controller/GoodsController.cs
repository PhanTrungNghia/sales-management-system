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
    class GoodsController
    {

        GoodsModel goodsModel = new GoodsModel();

        public DataTable GetData()
        {
            return goodsModel.GetData();
        }

        public DataTable GetData(string expression)
        {
            return goodsModel.GetData(expression);
        }

        public bool AddData(Goods goodsObj)
        {
            return goodsModel.AddData(goodsObj);
        }

        public bool UpdData(Goods goodsObj)
        {
            return goodsModel.UpdData(goodsObj);
        }

        public bool UpdQuantity(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = goodsModel.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int previousQuantity = int.Parse(dthh.Rows[j][3].ToString());
                        int newQuantity = int.Parse(dthh.Rows[j][3].ToString()) - int.Parse(dt.Rows[i][2].ToString());
                        if(newQuantity <= 0)
                        {
                            newQuantity = 0;
                        }
                        if (!goodsModel.UpdQuantity(dthh.Rows[j][0].ToString(), newQuantity))
                            return false;
                        break;
                    }
                }
            }
            return true;
        }

        public bool DelData(string id)
        {
            return goodsModel.DelData(id);
        }

    }
}
