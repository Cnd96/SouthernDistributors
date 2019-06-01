using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class Items
    {
        static DataTable db = new DataTable();
        string itemID;
        string itemName;
        string itemDescription;
        int itemQuantity;

        public string iId
        {
            get { return itemID; }
            set
            {
                if (value == "") throw new Exception("Enter item ID");
                itemID = value;
            }
        }
        public string iName
        {
            get { return itemName; }
            set
            {
                if (value == "") throw new Exception("Enter item name");
                itemName = value;
            }
        }
        public string iDescription
        {
            get { return itemDescription; }
            set
            {
                if (value == "") throw new Exception("Enter item description");
                itemDescription = value;
            }
        }
        public int iQuantity
        {
            get { return itemQuantity; }
            set
            {
                if (value <0) throw new Exception("Enter valid item quantity");
                itemQuantity = value;
            }
        }

        public static DataTable itemsearchall()
        {
            string query = "Select * from Item order by itemid asc";
            db = clsConnection.GetData(query);

            return db;
        }

        public static DataTable getItem(string itemID)
        {
            string query = "select * from Item where ItemID ='" + itemID + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getItemName()
        {
            string query = "Select ItemName from Item";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getTopItemId()
        {
            string query = "select top 1 itemid from item order by itemid desc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardItemName(string itemcombotext)
        {

            string query = "Select ib.itemid , ib.batchid, i.itemname , ib.quantity from batch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 and itemname LIKE '%" + itemcombotext + "%'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardDescription(string itemcombotext)
        {
            string query = "Select * from item WHERE itemname LIKE '%" + itemcombotext + "%'";
            db = clsConnection.GetData(query);

            return db;
        }
        public  int insertToItem(Items item)
        {
            string query = "insert into Item values ( '" + item.itemID + "', '" + item.itemName + "', '"+item.itemQuantity+"','" + item.itemDescription + "'); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public int updateItemQuantity(Items item)
        {
            string query = "UPDATE item SET Qty=Qty+" + item.itemQuantity + " where ItemID ='" + item.itemID + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }

    }
}
