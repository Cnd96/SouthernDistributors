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

            DataTable db = classCustomers.getTopCustomerId();
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
            
            try
            {
                if (!Regex.Match(txtCusContact.Text, @"^\d{10}$").Success)
                {
                    throw new Exception("Enter valid phone number");
                }
                
                    var customer = new classCustomers
                    {
                        cusId = txtCustomerId.Text,
                        cusName = txtCustomerName.Text,
                        cusAddress = txtCustomerAddress.Text,
                        cusContact = Int32.Parse(txtCusContact.Text),
                        cusCreditValue = float.Parse(txtCustomerCredit.Text)
                    };
                    int updatecustomer = customer.updateCustomer(customer);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try {
                
                if (!Regex.Match(txtCusContact.Text, @"^\d{10}$").Success)
                {
                    throw new Exception("Enter valid phone number");
                }
                var customer = new classCustomers
                {
                    cusId = txtCustomerId.Text,
                    cusName = txtCustomerName.Text,
                    cusAddress = txtCustomerAddress.Text,
                    cusContact = Int32.Parse(txtCusContact.Text)
                };

                DialogResult result = MessageBox.Show("Are you sure you want to Submit?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    int insertcustomer = customer.insertToCustomers(customer);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                classCustomers.deleteCustomer(txtCustomerId.Text);
                MessageBox.Show("Deleted Successfully");
                this.Close();
            }
        }
    }
}
