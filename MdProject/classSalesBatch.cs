using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classSalesBatch
    {
        static DataTable db;

     

        public static DataTable getOrderdetails(string oid, string iid, string bid)
        {

            string query = "select qty,discountitems from SalesBatch where orderid='" + oid + "' and itemid='" + iid + "' and batchid='" + bid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
    }
}
