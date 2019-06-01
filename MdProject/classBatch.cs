using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classBatch
    {
        static DataTable db;
        Items item;
        string batchId;
        float sellingPrice;
        string expDate;
        float costPerUnit;
        int quantity;

        public classBatch()
        {
            item = new Items();
        }
        public string itemid
        {
            get { return item.iId; }
            set
            {
                item.iId = value;
            }
        }
        public string batchid
        {
            get { return batchId; }
            set
            {
                batchId = value;
            }
        }
        public string expireDate
        {
            get { return expDate; }
            set
            {
                expDate = value;
            }
        }
        public float sellingprice
        {
            get { return sellingPrice; }
            set
            {
                sellingPrice = value;
            }
        }
        public float costperunit
        {
            get { return costPerUnit; }
            set
            {
                costPerUnit = value;
            }
        }
        public int itemquantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        public static DataTable getItemsAvailable()
        {

            DataTable db = new DataTable();
            string query = "Select ib.itemid , ib.batchid, i.itemname , ib.quantity from batch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 order by ib.itemid asc";
            db = clsConnection.GetData(query);

            return db;
        }

        public static DataTable getSellingPrice(string itemid,string batchid)
        {
            

            string query = "select sellingprice from batch where itemid='" + itemid + "' and batchid='" + batchid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getSellingPriceExpDate(string itemid, string batchid)
        {


            string query = "select sellingprice,expdate from batch where batchId='" + batchid + "' and itemid='" + itemid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getTopBatchId(string itemID)
        {
            string query = "select top 1 batchid from batch where itemid=" + itemID + " order by itemid desc ";
            db = clsConnection.GetData(query);

            return db;
        }

        //public  int insertToBatchItemID(classItemBatch item)
        //{
        //    string query = "insert into ItemBatchID values ( '" + item.itemid + "', '" + item.batchid + "'); ";
        //    int result = clsConnection.SendQuery(query);
        //    return result;
        //}
        public  int insertToItemBatch(classBatch item)
        {
            string query = "insert into Batch values ('" + item.itemid + "', '" + item.batchid + "', " + item.sellingprice + ", '" + item.expireDate + "', " + item.itemquantity + ", " + item.costperunit + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }

        public static int updateItemBatchQuantity(string quantity,string batchId, string itemId)
        {
           
            string query = "UPDATE batch SET  Quantity=Quantity+" + quantity + " where BatchID ='" + batchId + "' and itemid='" + itemId + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }

    }
}
