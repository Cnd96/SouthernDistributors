using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
        public static AutoCompleteStringCollection GetAutucompleteData(String Query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            con.Close();
            return collection;
        }

    }
}
