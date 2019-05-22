using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classItemBatch
    {
        public static int insertToBatchItem(string iid, string bid)
        {
            string query = "insert into ItemBatchID values ( '" + iid + "', '" + bid + "'); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertToBatch(string iid, string bid, float sellPrice, string expDate, int quan, float costperunit)
        {
            string query = "insert into ItemBatch values ('" + iid + "', '" + bid + "', " + sellPrice + ", '" + expDate + "', " + quan + ", " + costperunit + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
