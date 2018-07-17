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
    public partial class frmCustomerReports : Form
    {
        public frmCustomerReports()
        {
            InitializeComponent();
        }

        private void frmCustomerReports_Load(object sender, EventArgs e)
        {
            customernamefill();
            
        }
        private void customernamefill()
        {
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select customername from customer", con1);
                con1.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                txtCusName.AutoCompleteCustomSource = collection;
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCusName_Leave(object sender, EventArgs e)
        {
            try
            {
                
                    DataTable db = new DataTable();
                    string query = "select customerid from customer where customername  ='" + txtCusName.Text + "'";
                    db = clsConnection.GetData(query);
                    string cusid = db.Rows[0][0].ToString();

              

                dgvsalesview.DataSource = ClassSaleQuery.salesdetailsSearch2(cusid);
                dgvsalesview.Columns[0].HeaderText = "Sales ID";
                dgvsalesview.Columns[1].HeaderText = "Customer Name";
                dgvsalesview.Columns[2].HeaderText = "Date";
                dgvsalesview.Columns[3].HeaderText = "Amount to be paid";
                dgvsalesview.Columns[4].HeaderText = "Amount paid";
                dgvsalesview.Columns[5].HeaderText = "Balance";

                dgvPaymentView.DataSource = ClassPayments.PaymentSearch2(cusid);
                dgvPaymentView.Columns[0].HeaderText = "Payment ID";
                dgvPaymentView.Columns[1].HeaderText = "Customer Name";
                dgvPaymentView.Columns[2].HeaderText = "Date";
                dgvPaymentView.Columns[3].HeaderText = "Amount";

                DataTable db1 = new DataTable();
                string query1 = "select creditvalue from customer where customername  ='" + txtCusName.Text + "'";
                db1 = clsConnection.GetData(query1);
                txtcredit.Text = db1.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {


            frmCustomerCreditViewReport frinvoice = new frmCustomerCreditViewReport();
            frinvoice.ShowDialog();
        }
    }
}
