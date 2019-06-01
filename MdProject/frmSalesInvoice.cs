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
    public partial class frmSalesInvoice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
        public frmSalesInvoice()
        {
            InitializeComponent();
        }
        public frmSalesInvoice(string orderid)
        {
            InitializeComponent();
            con.Open();
            DataSet1 ds = new DataSet1();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;        
            cmd.CommandText = "select ob.date, o.OrderId, c.customername, ob.creditvalue, i.itemname, o.qty, o.discountitems, ib.sellingprice, o.Amount , ob.total , ob.AmountPAid, ob.AmountToBePaid, ob.Discount from item i inner join salesbatch o on i.itemid= o.ItemId inner join Batch ib on o.ItemId= ib.ItemId and o.BatchId= ib.BatchId inner join Sales ob on ob.OrderID= o.OrderId inner join customer c on ob.CustomerID= c.CustomerID where  o.orderid = '" + orderid + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            SalesInvoice myr = new SalesInvoice();
            myr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void print() {

           
        }
        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
