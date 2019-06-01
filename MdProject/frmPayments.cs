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
                DataTable db = ClassPayments.getPaymentId();
                string payId = db.Rows[0][0].ToString();
                int npayId = Int32.Parse(payId) + 1;
                txtPaymentId.Text = npayId.ToString();


                AutoCompleteStringCollection collection = classCustomers.getAutoCompleteCustomersNames();
                
                txtCusName.AutoCompleteCustomSource = collection;
              

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
                DataTable db = classCustomers.getCustomerCreditvalue(txtCusName.Text);
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
                var payement = new ClassPayments
                {
                    paymentid= txtPaymentId.Text,
                    paymentdate= lblDate.Text,
                    paymentamount= float.Parse(txtAmountPaying.Text),
                    customerid= txtcusId.Text
                };

                int pay = payement.insertTopayment(payement);
                int customer=classCustomers.updateCustomerCreditValue(txtAmountPaying.Text ,txtcusId.Text);
               
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
