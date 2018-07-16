using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MdProject
{
    class clsConnection
    {
        static SqlConnection con = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
       

        public static void connectionclose()
        {
            con.Close();
        }
        public static void connectionopen()
        {
            con.Open();
        }
        public static int SendQuery(String sendQuery)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sendQuery, con);
            int x = SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public static DataTable GetData(String getQuery)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(getQuery, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            return dt;
        }
        
    }
}
