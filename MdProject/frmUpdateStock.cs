using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdProject
{
    public partial class frmUpdateStock : Form
    {
        int orgquantity = 0;


        public frmUpdateStock()
        {
            InitializeComponent();
        }

        public string itemId
        {
            set
            {
                txtItemId.Text = value;
            }
        }
        public string batchId
        {
            set
            {
                txtBatchId.Text = value;
            }
        }

        public string itemCategory
        {
            set
            {
                txtItemcategory.Text = value;
            }
        }
        public string quantity
        {
            set
            {
                txtQuantity.Text = value;
            }
        }
        public string itemName
        {
            set
            {
                txtItemDesc.Text = value;
            }
        }
        public string sellingPrice
        {
            set
            {
                txtselling.Text = value + 10000;
            }
        }
        public string expDate
        {
            set
            {
                txtExpire.Text = value;
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int y=0;
            if (result == DialogResult.Yes)
            {
                 y = classStocks.deleteItem(txtItemId.Text, txtBatchId.Text, Int32.Parse(txtQuantity.Text));
                if(y==1)
                MessageBox.Show("Deleted SuccessFully.");
            }
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int newquantity = Int32.Parse(txtQuantity.Text);
            int quantitydiff = newquantity-orgquantity;
            DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int y = 0;
            if (result == DialogResult.Yes)
            {
                y = classStocks.UpdateItem(txtItemId.Text, txtBatchId.Text, Int32.Parse(txtQuantity.Text),float.Parse(txtselling.Text),txtExpire.Text,txtItemcategory.Text,txtItemDesc.Text,quantitydiff);
                if (y == 1)
                    MessageBox.Show("Updated SuccessFully.");
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
}
