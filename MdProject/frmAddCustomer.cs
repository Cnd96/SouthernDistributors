using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace MdProject
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
            btnChange.Visible = false;
            btnDelete.Visible = false;
            lblCredit.Visible = false;
            txtCustomerCredit.Visible = false;
            DataTable db = new DataTable();

            string query = "select top 1 customerid from customer order by customerid desc";
            db = clsConnection.GetData(query);
            string CustomerId = db.Rows[0][0].ToString();
            string sub = CustomerId.Substring(3);
            int newCusId = Int32.Parse(sub)+1;
            txtCustomerId.Text = "Cus" + newCusId.ToString();
            
        }
  
        public frmAddCustomer(string id,string name, String telephone, string address,String credit)
        {
            InitializeComponent();
            btnSave.Visible = false;
            txtCustomerId.Text = id;
            txtCustomerName.Text = name;
            txtCusContact.Text = telephone.ToString();
            txtCustomerAddress.Text = address;
            txtCustomerCredit.Text = credit.ToString() ;

        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            int x = 1;
            try
            {
                if (txtCustomerName.Text == "") throw new Exception("Enter Customer Name");
                if (!Regex.Match(txtCusContact.Text, @"\(?\d{2}\)?-? *\d{3}-? *-?\d{4}").Success)
                {
                    MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCusContact.Focus();
                    return;
                }
                if (txtCustomerAddress.Text == "") throw new Exception("Enter Customer Address");
                x = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (x == 2) {
                try {
                    string query1 = "UPDATE Customer  SET CustomerName = '" + txtCustomerName.Text + "', Address = '" + txtCustomerAddress.Text + "', Contactno='" + Int32.Parse(txtCusContact.Text) + "', Creditvalue='" + float.Parse(txtCustomerCredit.Text) + "' where CustomerId  ='" + txtCustomerId.Text + "'";
                    clsConnection.SendQuery(query1);
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }

                        if (c is RichTextBox)
                        {
                            ((RichTextBox)c).Text = String.Empty;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Enter valid credit value.");
                }
                
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int x = 1;
            try {
                if (txtCustomerName.Text == "") throw new Exception("Enter Customer Name");
                if (!Regex.Match(txtCusContact.Text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success)
                {
                    MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCusContact.Focus();
                    return;
                }
                if (txtCustomerAddress.Text == "") throw new Exception("Enter Customer Address");
                x = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (x == 2)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Submit?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int insertcustomer = classCustomers.insertToCustomers(txtCustomerId.Text, txtCustomerName.Text,Int32.Parse(txtCusContact.Text),txtCustomerAddress.Text);

                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }

                        if (c is RichTextBox)
                        {
                            ((RichTextBox)c).Text = String.Empty;
                        }
                    }

                }
                else
                {
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }                    
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             string query1 ="delete from customer where customerid='"+txtCustomerId.Text+"'";
                    clsConnection.SendQuery(query1);
            MessageBox.Show("Deleted Successfully");
            this.Close();
        }
    }
}
