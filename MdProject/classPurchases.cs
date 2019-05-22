using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classPurchases
    {
        static DataTable db = new DataTable();
        public static DataTable getTopPurchaseId()
        {
            string query = "select top 1 purchaseid from purchase order by  purchaseid desc";
            db = clsConnection.GetData(query);

            return db;
        }

        public static int insertTopurchase(string pid, string date, float amount)
        {
            string query = "insert into purchase values ( '" + pid + "', '" + date + "', " + amount + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
