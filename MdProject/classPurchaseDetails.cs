using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classPurchaseDetails
    {
        public static int insertpurchaseDetails(string pid, string iid, string bid, int quantity)
        {
            string query = "insert into purchasedetails values ( '" + pid + "', '" + iid + "', '" + bid + "', " + quantity + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
