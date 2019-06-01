using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MdProject
{
    class classReturns
    {
        static DataTable db;

        public static DataTable getTopReturnId()
        {

            string query = "select top 1 returnid from returns order by returnid desc";
            db = clsConnection.GetData(query);

            return db;
        }

        
        public static DataTable returndetails(string oid)
        {

            string query = "select r.returnid,r.orderid,r.ItemId,r.BatchId,r.Qty,r.Date,r.AmountOfReturns from returns r inner join orderbill o on o.OrderID=r.OrderId where o.orderid ='" + oid + "'";
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
