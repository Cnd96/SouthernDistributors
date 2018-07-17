using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MdProject
{
    public partial class frmCustomerCreditViewReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
        public frmCustomerCreditViewReport()
        {
            InitializeComponent();
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("select sum(CreditValue) from customer", con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            float amount = float.Parse(dt.Rows[0][0].ToString());

            DataSet1 ds = new DataSet1();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customerid,customername,contactno,creditvalue," + amount + "as total from customer where creditvalue>0 ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable4);
            CustomerCreditReport myr = new CustomerCreditReport();
            myr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myr;
        }

        private void frmCustomerCreditViewReport_Load(object sender, EventArgs e)
        {

        }
    }
}
