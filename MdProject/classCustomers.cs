using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class classCustomers
    {
        public static DataTable customersearchall()
        {

            DataTable db = new DataTable();
            string query = "Select * from customer ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardCustomerName(string cusname)
        {

            DataTable db = new DataTable();
            string query = "Select * from customer WHERE customername LIKE '%" + cusname + "%'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static int insertToCustomers(string cid, string name, int cno , string Address)
        {
            string query = "insert into customer values ( '" + cid + "', '" + name + "', " + cno + ", '" + Address + "'," + 0 + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
