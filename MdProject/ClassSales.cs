using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class ClassSales
    {
        public static DataTable itemsSearch()
        {

            DataTable db = new DataTable();
            string query = "Select ib.itemid , ib.batchid, i.itemname , ib.quantity from itembatch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 order by ib.itemid asc";
            db = clsConnection.GetData(query);

            return db;
        }

        public static DataTable wildCardItemName(string itemcombotext)
        {

            DataTable db = new DataTable();
            string query = "Select ib.itemid , ib.batchid, i.itemname , ib.quantity from itembatch ib inner join item i on ib.itemid=i.itemid  where ib.quantity>0 and itemname LIKE '%" + itemcombotext + "%'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static int insertToOrderbill(string oid, string cid, string date, float discount, float amnttobepaid,float amntpaid,float credit,float dispercen)
        {
            string query = "INSERT INTO orderbill VALUES  ( '" + oid + "','" + cid + "','" + date + "', " + discount + ", " + amnttobepaid + ", " + amntpaid + ", " + credit + ", " + dispercen + ", " + (amnttobepaid+ discount) + ");";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertToOrderDetails(string oid, string iid, string bid, int quantity, int discountItems,float amount)
        {
           
            string query = "INSERT INTO orderdetails VALUES  ( '" + oid + "','" + iid + "','" + bid + "', " + quantity + ", " + discountItems + ", " + amount + ");";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static DataTable salesdetailsSearch()
        {

            DataTable db = new DataTable();
            string query = "Select ob.orderid, c.customername, ob.date, ob.amounttobepaid, ob.amountpaid, ob.creditvalue, ob.discountpercentage from orderbill ob inner join customer c on c.customerid=ob.customerid ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable salesdetailsSearch2(string cid)
        {

            DataTable db = new DataTable();
            string query = "Select ob.orderid, c.customername, ob.date, ob.amounttobepaid, ob.amountpaid, ob.creditvalue from orderbill ob inner join customer c on c.customerid=ob.customerid  where c.customerid='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildcardsalesdetailsSearch(string oid)
        {

            DataTable db = new DataTable();
            string query = "Select ob.orderid, c.customername,ob.date,ob.amounttobepaid,ob.amountpaid,ob.creditvalue,ob.discountpercentage from orderbill ob inner join customer c on c.customerid=ob.customerid where ob.orderid like '"+ oid+"%'";
            db = clsConnection.GetData(query);
            
            return db;
        }
        public static DataTable salesSearch()
        {

            DataTable db = new DataTable();
            string query = "Select od.itemid, od.batchid, i.itemname,od.qty,od.discoutnitems, ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable customersearchfromorder(string oid)
        {

            DataTable db = new DataTable();
            string query = "Select c.customerid ,c.customername from customer c inner join orderbill o on c.customerid=o.customerid where orderid='" + oid+"'";
            db = clsConnection.GetData(query);

            return db;
        }

        public static DataTable salesUpdatebillsearch(string oid)
        {

            DataTable db = new DataTable();
            string query = "Select od.itemid,od.batchid,i.itemname,od.qty,od.discountitems from item i inner join orderdetails od on od.itemid=i.itemid where orderid='"+ oid +"'";
            db = clsConnection.GetData(query);

            return db;
        }
        
    }
}
