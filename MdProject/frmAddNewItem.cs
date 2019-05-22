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
    public partial class frmAddNewItem : Form
    {
        public frmAddNewItem()
        {
            InitializeComponent();
        }
        
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == "") throw new Exception("Enter an Item ID.");
                if (txtItemName.Text == "") throw  new Exception("Enter an Item Name.");
                if (txtItemDesc.Text == "") throw new Exception("Enter an Item Description.");

                var item = new classItems
                {
                    iId= txtItemId.Text,
                    iName= txtItemName.Text,
                    iDescription= txtItemDesc.Text,
                    iQuantity=0
                };
                int updatecustomer = item.insertToItem(item);

              
                txtItemId.Text = "";
                txtItemDesc.Text = "";
                txtItemName.Text = "";
                MessageBox.Show("Item has successfuly added");
            }
            catch(SqlException sqle)
            {
                clsConnection.connectionclose();
                MessageBox.Show("Item ID taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {              
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddNewItem_Load(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            string query = "select top 1 itemid from item order by itemid desc";
            db = clsConnection.GetData(query);
            string itemId = db.Rows[0][0].ToString();
            int newIId = Int32.Parse(itemId) + 1;
            txtItemId.Text = newIId.ToString();
        }

        
    }
}
