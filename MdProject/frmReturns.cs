﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MdProject
{
    public partial class frmReturns : Form
    {
        public frmReturns()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("MM-d-yyyy");
        }

        private void frmReturns_Load(object sender, EventArgs e)
        {
            DataTable db = classReturns.getTopReturnId();
            string returnId = db.Rows[0][0].ToString();
            int newreturnId = Int32.Parse(returnId) + 1;
            txtReturnId.Text = newreturnId.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderId.Text == "") throw new Exception("Enter Order Id");
                if (txtItemId.Text == "") throw new Exception("Enter Item Id");
                if (txtBatchID.Text == "") throw new Exception("Enter Batch Id");
                DataTable db1 = new DataTable();
                DataTable db2 = new DataTable();


                db1 = classCustomers.getCustomerDetailsOrder(txtOrderId.Text);
                db2 = classSalesBatch.getOrderdetails(txtOrderId.Text, txtItemId.Text, txtBatchID.Text);
                txtCustomerId.Text = db1.Rows[0][0].ToString();
                txtCustomerName.Text = db1.Rows[0][1].ToString();
                txtCreditValue.Text = db1.Rows[0][2].ToString();
                txtdiscountPercentage.Text = db1.Rows[0][3].ToString();
                txtAmountpurchased.Text = db2.Rows[0][0].ToString();
                txtFreeItems.Text = db2.Rows[0][1].ToString();
                txtQuantityReturn.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void txtAmountReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtAmountReturn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int amntpurchased = Int32.Parse(txtAmountpurchased.Text);
                int amntreturn = Int32.Parse(txtQuantityReturn.Text);
                if (amntreturn > amntpurchased)
                {
                    txtQuantityReturn.ForeColor = Color.Red;
                }
                else
                {
                    txtQuantityReturn.ForeColor = Color.Black;
                }
            }
            catch(FormatException fex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int x = 1;
            try
            {
                if (txtQuantityReturn.Text == "")
                {
                    throw new Exception("Enter returning amount");
                }
                if (txtQuantityReturn.ForeColor == Color.Red)
                {
                    txtQuantityReturn.Text = "";
                    throw new Exception("Enter a valid returning quantity");  
                }
                if (txtAmountpurchased.Text == "")
                {
                    txtQuantityReturn.Text = "";
                    throw new Exception("Enter Purchased amount");
                }
                x = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (x == 2)
            {
                DataTable db = classBatch.getSellingPrice(txtItemId.Text, txtBatchID.Text);
                
                float sellingprice = float.Parse(db.Rows[0][0].ToString());

                int quantityreturn = Int32.Parse(txtQuantityReturn.Text);
                float amountPayingBack = 0;

                if (Int32.Parse(txtFreeItems.Text) > 0)
                {
                    quantityreturn--;
                }

                amountPayingBack = quantityreturn * sellingprice * (100 - float.Parse(txtdiscountPercentage.Text)) / 100;
                float creditamount = float.Parse(txtCreditValue.Text);

                int inserttoreturn = classReturns.inserttoreturns(txtReturnId.Text ,txtOrderId.Text,txtItemId.Text,txtBatchID.Text , Int32.Parse(txtQuantityReturn.Text),lblDate.Text,amountPayingBack);

                
                var item = new Items
                {
                    iId = txtItemId.Text,
                    iQuantity = Int32.Parse(txtQuantityReturn.Text)
                };
                int updateItemQuantity = item.updateItemQuantity(item);

                int updateItemBatchQuantity = classBatch.updateItemBatchQuantity(txtQuantityReturn.Text, txtBatchID.Text, txtItemId.Text);
                
                if (amountPayingBack >= creditamount)
                {

                    amountPayingBack = amountPayingBack - creditamount;
                    MessageBox.Show("Amount that should handover to customer Rs." + amountPayingBack);
                    int updateCustomer = classCustomers.updateCustomerCreditValueOnReturns(0, txtCustomerId.Text);
                    
                }
                else
                {
                    creditamount = creditamount - amountPayingBack;
                    MessageBox.Show("New credit value of customer is Rs." + creditamount);
                    int updateCustomer = classCustomers.updateCustomerCreditValueOnReturns(creditamount, txtCustomerId.Text);
                                   
                }

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtItemId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtBatchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
    }
}
