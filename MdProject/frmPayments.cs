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
    public partial class frmPayments : Form
    {
         SqlConnection con1 = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
        public frmPayments()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("MM-d-yyyy");
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable db = new DataTable();
                string query = "select top 1 paymentid from payment order by paymentid desc";
                db = clsConnection.GetData(query);
                string payId = db.Rows[0][0].ToString();
                int npayId = Int32.Parse(payId) + 1;
                txtPaymentId.Text = npayId.ToString();

                SqlCommand cmd = new SqlCommand("select customername from customer",con1 );
                con1.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                txtCusName.AutoCompleteCustomSource = collection;
                con1.Close();

                dgvPaymentView.DataSource = ClassPayments.PaymentSearch();
                dgvPaymentView.Columns[0].HeaderText = "Payment ID";
                dgvPaymentView.Columns[1].HeaderText = "Customer Id";
                dgvPaymentView.Columns[2].HeaderText = "Customer Name";
                dgvPaymentView.Columns[3].HeaderText = "Date";
                dgvPaymentView.Columns[4].HeaderText = "Amount";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCusName_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable db = new DataTable();
                string query = "select customerid,creditvalue from customer where customername  ='" + txtCusName.Text + "'";
                db = clsConnection.GetData(query);
                if(float.Parse(db.Rows[0][1].ToString())==0)
                {
                    MessageBox.Show("No Credit value fo this customer.");
                    txtCusName.Text = "";
                }
                else {
                    txtcusId.Text = db.Rows[0][0].ToString();
                    txtCredit.Text = db.Rows[0][1].ToString();
                }
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtAmountPaying_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
           
        }

        private void txtCusName_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtcusId_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPaymentId_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtCredit_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtAmountPaying_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            float Payingvalue;
            int x = 1;
            try
            {
                if (txtcusId.Text == "")
                {
                    throw new Exception("Enter a Customer.");
                }
                Payingvalue = float.Parse(txtAmountPaying.Text);
                if (txtAmountPaying.ForeColor == Color.Red)
                {
                    throw new Exception("Enter a less paying amount.");
                }
                
                x = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAmountPaying.Text = "";
                
            }
            if (x == 2)
            {
                int inserttopayments = ClassPayments.insertTopayment(txtPaymentId.Text,txtcusId.Text,lblDate.Text,float.Parse(txtAmountPaying.Text));
                string query1 = "UPDATE customer SET creditvalue=creditvalue-" + txtAmountPaying.Text + " where customerID ='" + txtcusId.Text + "'";
                clsConnection.SendQuery(query1);
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }

            dgvPaymentView.DataSource = ClassPayments.PaymentSearch();
            dgvPaymentView.Columns[0].HeaderText = "Payment ID";
            dgvPaymentView.Columns[1].HeaderText = "Customer Id";
            dgvPaymentView.Columns[2].HeaderText = "Customer Name";
            dgvPaymentView.Columns[3].HeaderText = "Date";
            dgvPaymentView.Columns[4].HeaderText = "Amount";

        }

        private void txtAmountPaying_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float paytemp = float.Parse(txtAmountPaying.Text);
                if (paytemp > float.Parse(txtCredit.Text))
                {
                    txtAmountPaying.ForeColor = Color.Red;
                }
                else
                {
                    txtAmountPaying.ForeColor = Color.Black;
                }
            }
            catch (FormatException fex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
