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
    public partial class frmSalesReportView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
        public frmSalesReportView(int month,string mon)
        {
            try
            {
                InitializeComponent();
                int salesmonth = month;
                con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("select sum(amounttobepaid) from Orderbill where month(date)=" + salesmonth + "", con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                float amount = float.Parse(dt.Rows[0][0].ToString());

                DataSet1 ds = new DataSet1();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select o.orderid ,c.customername,o.date,o.amounttobepaid,'" + mon + "' as month ," + amount + "as total from Orderbill o inner join Customer c on c.CustomerID=o.CustomerID where month(date)=" + salesmonth + "";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.DataTable3);
                salesViewReport myr = new salesViewReport();
                myr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myr;
            }catch(FormatException fex)
            {
                MessageBox.Show("No Sales on this month");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSalesReportView_Load(object sender, EventArgs e)
        {

        }
    }
}
