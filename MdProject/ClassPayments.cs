using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class ClassPayments
    {
        public static DataTable PaymentSearch()
        {

            DataTable db = new DataTable();
            string query = "Select p.paymentid,c.customerid,c.customername,p.date,p.amount from payment p inner join customer c on p.customerid=c.customerid";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable PaymentSearch2(string cid)
        {

            DataTable db = new DataTable();
            string query = "Select p.paymentid,c.customername,p.date,p.amount from payment p inner join customer c on p.customerid=c.customerid where c.customerid='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static int insertTopayment(string pid, string cid,  string Date, float amount)
        {
            string query = "insert payment values ('" + pid + "', '" + cid + "',  '" + Date + "', " + amount + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }

    }
}
