using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace MdProject
{
    public partial class frmExpireDateReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
        public frmExpireDateReport()
        {
            InitializeComponent();
            

        }
        public frmExpireDateReport(string date)
        {
            
            InitializeComponent();
            string expiredate = date;
            con.Open();
            DataSet1 ds = new DataSet1();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select i.itemname ,ib.itemid, ib.batchid,ib.expdate,ib.quantity ,'"+expiredate+"' as date from ItemBatch ib inner join item i on i.itemid = ib.itemid where ExpDate< '" + expiredate+"'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable2);
            expdatereport myr = new expdatereport();
            myr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myr;
        }


            private void frmExpireDateReport_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
