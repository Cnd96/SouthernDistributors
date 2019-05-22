using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class classOrderQuery
    {
        public static DataTable itemsearchall()
        {
            
                DataTable db = new DataTable();
                string query = "Select * from Item order by itemid asc";
                db = clsConnection.GetData(query);
            
            return db;
        }

        public static DataTable itemSelectItemId(string itemID)
        {

            DataTable db = new DataTable();
            string query = "select * from Item where ItemID ='" + itemID + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardDescription(string itemcombotext)
        {
            
                DataTable db = new DataTable();
                string query = "Select * from item WHERE itemname LIKE '%" + itemcombotext + "%'";
                db = clsConnection.GetData(query);
            
            return db;
        }
        public static int insertToBatchItem(string iid, string bid)
        {
            string query = "insert into ItemBatchID values ( '" + iid + "', '" + bid + "'); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertToBatch(string iid,string bid,float sellPrice,string expDate, int quan, float costperunit)
        {
            string query = "insert into ItemBatch values ('" + iid + "', '" + bid + "', " + sellPrice + ", '" + expDate + "', " + quan + ", " + costperunit + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertToItem(string iid, string name,string desc)
        {
            string query = "insert into Item values ( '" + iid + "', '" + name + "',0, '" + desc + "'); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertpurchaseDetails(string pid, string iid, string bid,int quantity)
        {
            string query = "insert into purchasedetails values ( '" + pid + "', '" + iid + "', '" + bid + "', " + quantity + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertTopurchase(string pid, string date, float amount)
        {
            string query = "insert into purchase values ( '" + pid + "', '" + date + "', " + amount + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
