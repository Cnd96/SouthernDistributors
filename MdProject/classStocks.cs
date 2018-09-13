using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class classStocks
    {
        public static DataTable itemsSearch()
        {

            DataTable db = new DataTable();
            string query = "Select ib.itemid , ib.batchid,i.itemcategory, i.itemname , ib.quantity,ib.sellingprice,ib.expdate from itembatch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 order by ib.itemid asc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardDescription(string itemcombotext)
        {

            DataTable db = new DataTable();
            string query = "Select ib.itemid , ib.batchid, i.itemname,i.itemcategory , ib.quantity,ib.sellingprice,ib.expdate from itembatch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 and i.itemname LIKE '%" + itemcombotext + "%' order by ib.itemid asc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static int deleteItem(string itemid, string bid ,int quantity)
        {
            string query = "delete itembatch where itemid='" + itemid + "' and batchID ='" + bid + "'";
            int x=clsConnection.SendQuery(query);
            string query1= "UPDATE item SET Qty=Qty-" + quantity + " where ItemID ='" + itemid + "'";
            x= clsConnection.SendQuery(query1);
            return x;
        }
        public static int UpdateItem(string itemid, string bid, int quantity,float sellprice,string exp,string icategory, string iname,int quantitydiff)
        {
            string query = "update itembatch set itemid='" + itemid + "' , batchID ='" + bid + "' , quantity=" + quantity + " , sellingprice=" + sellprice + " , expdate ='" + exp + "' where itemid='" + itemid + "' and batchID ='" + bid + "'";
            int x = clsConnection.SendQuery(query);
            string query1 = "UPDATE item SET  itemcategory ='" + icategory + "' , itemname ='" + iname + "' where ItemID ='" + itemid + "'";
            x = clsConnection.SendQuery(query1);
            string query2 = "UPDATE item SET Qty=Qty+" + quantitydiff + " where ItemID ='" + itemid + "'";
            x = clsConnection.SendQuery(query2);
            return x;
        }
    }
}
