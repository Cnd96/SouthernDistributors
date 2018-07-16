using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MdProject
{
    class classReturnQuery
    {
        public static DataTable customerdetails(string oid)
        {
            string cus = "Cus1001";
            DataTable db = new DataTable();
            string query = "Select c.customerid, c.customername, c.creditvalue , o.DiscountPercentage from customer c inner join orderbill o on o.customerid=c.customerid where o.orderid='"+oid+"'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable orderdetails(string oid, string iid, string bid)
        {

            DataTable db = new DataTable();
            string query = "select qty,discountitems from orderdetails where orderid='"+oid+ "' and itemid='"+iid+"' and batchid='"+bid+"'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static int inserttoreturns(string rid,string oid, string iid, string bid, int quantity, string date, float amountofreturn)
        {
            string query = "INSERT INTO returns VALUES  ('" + rid + "', '" + oid + "','" + iid + "','" + bid + "', " + quantity + ",'" + date + "', " + amountofreturn + ");";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
