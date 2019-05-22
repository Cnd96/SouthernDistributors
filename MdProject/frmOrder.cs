using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MdProject
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("MM-d-yyyy");

            

        }
        DataTable table = new DataTable();
        DataTable db;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                db = classPurchases.getTopPurchaseId();
                string purchaseId = db.Rows[0][0].ToString();
                int newpurchaseId = Int32.Parse(purchaseId) + 1;
                txtPurchaseId.Text = newpurchaseId.ToString();

                dgvStockView.DataSource = classItems.itemsearchall();
                dgvStockView.Columns[0].HeaderText = "Item ID";
                dgvStockView.Columns[1].HeaderText = "Item Category";
                dgvStockView.Columns[2].HeaderText = "Quantity";
                dgvStockView.Columns[3].HeaderText = " Item Name";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            table.Columns.Add("Item Id", typeof(int));// data type int
            table.Columns.Add("Batch ID", typeof(string));// datatype string
            table.Columns.Add("Expire Date", typeof(DateTime));// datatype string
            table.Columns.Add("Selling Price", typeof(float));// data type int
            table.Columns.Add("Cost Per Unit ", typeof(float));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Amount ", typeof(float));
            dgvBillView.DataSource = table;
            stockcomboxfill();
        }
        private void stockcomboxfill()
        {
            DataTable dbcombo = classItems.getItemName();
            foreach (DataRow dr in dbcombo.Rows)
            {
                cmbItemDesc.Items.Add(dr["ItemName"].ToString());
            }
        }

        private void dgvStockView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int index = e.RowIndex;

                DataGridViewRow selectedrow = dgvStockView.Rows[index];
                String IID = selectedrow.Cells[0].Value.ToString();
                
                db = classItems.getItem(IID);
                lblItemId.Text = db.Rows[0][0].ToString();
                lblItemName.Text = db.Rows[0][1].ToString();
                lblItemDesc.Text = db.Rows[0][3].ToString();

                db= classItems.getTopBatchId(IID);

                DateTime date = DateTime.Now;
                
                txtBatchId.Text = (Int32.Parse(db.Rows[0][0].ToString())+1).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IndexOutOfRangeException iex)
            {
                txtBatchId.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        float total = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int x = 1;
            classOrderValidate bll = new classOrderValidate();

            try
            {
                if (lblItemId.Text == "")
                {
                    throw new Exception("Select an Item.");
                }
                if (txtBatchId.Text == "")
                {
                    throw new Exception("Select a Batch ID.");
                }
                bll.itemid = lblItemId.Text;
                bll.batchid = txtBatchId.Text;
                bll.sellingprice = float.Parse(txtSellingPrice.Text);
                bll.costperunit = float.Parse(txtCostPerUnit.Text);
                bll.quantity = float.Parse(txtQuantity.Text);
                if (dateTimePicker1.Value <= DateTime.Today)
                {
                    throw new Exception("Enter a valid Expire date");
                }
                x = 2;
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Enter a valid amount.");
                txtQuantity.Text = "";
                txtSellingPrice.Text = "";
                txtCostPerUnit.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtQuantity.Text = "";
                txtSellingPrice.Text = "";
                txtCostPerUnit.Text = "";
            }

            if (x == 2)
            {
                table.Rows.Add(bll.itemid, bll.batchid, dateTimePicker1.Value.ToShortDateString(), bll.sellingprice, bll.costperunit, bll.quantity, bll.costperunit * bll.quantity);
                dgvBillView.DataSource = table;

                total += (bll.costperunit * bll.quantity);
                txtAmount.Text = total.ToString();
                txtBatchId.Text = "";
                txtQuantity.Text = "";
                txtSellingPrice.Text = "";
                txtCostPerUnit.Text = "";
                lblItemDesc.Text = "";
                lblItemId.Text = "";
                lblItemName.Text = "";
            }
        }

        private void txtCostPerUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedindex = dgvBillView.CurrentCell.RowIndex;
                DataGridViewRow deleterow = dgvBillView.Rows[selectedindex];
                total -= Int32.Parse(deleterow.Cells[6].Value.ToString());
                txtAmount.Text = total.ToString();
                if (selectedindex > -1)
                {
                    dgvBillView.Rows.RemoveAt(selectedindex);
                    //billdgv.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int rowCount =dgvBillView.Rows.Count;

            for (int i = rowCount - 1; i >= 0; i--)
            {
                dgvBillView.Rows.RemoveAt(i);
            }
            txtAmount.Text = "";
            total = 0;
        }
    
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddNewItem ad = new frmAddNewItem();
            ad.ShowDialog();
        }

        private void cmbItemDesc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvStockView.DataSource = classItems.wildCardDescription(cmbItemDesc.Text);             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbItemDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dgvStockView.RowCount == 1)
                {
                    int index = 0;
                    DataGridViewRow selectedrow = dgvStockView.Rows[index];
                    String IID = selectedrow.Cells[0].Value.ToString();

                    DataTable db1 = new DataTable();
                    db1 = classItems.getItem(IID);
                    DateTime date = DateTime.Now;
                    lblItemId.Text = db1.Rows[0][0].ToString();
                    lblItemName.Text = db1.Rows[0][1].ToString();
                    lblItemDesc.Text = db1.Rows[0][3].ToString();
                    txtBatchId.Text = date.ToString("MMMM") + lblItemId.Text;
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBillView.Rows.Count ; i++)
            {
          
                try
                {
                    string format = dgvBillView.Rows[i].Cells[2].Value.ToString();
                    DateTime dt = Convert.ToDateTime(format);
                    string date = dt.ToString("MM-d-yyyy");
                    string IID = dgvBillView.Rows[i].Cells[0].Value.ToString();

                    int insertBatchItem = classItemBatch.insertToBatchItem(dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString());
                    int insertBatch = classItemBatch.insertToBatch(dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString(), float.Parse(dgvBillView.Rows[i].Cells[3].Value.ToString()), date, Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()), float.Parse(dgvBillView.Rows[i].Cells[4].Value.ToString()));
                    int insertopurchasedetails = classPurchaseDetails.insertpurchaseDetails(txtPurchaseId.Text, dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString(), Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()));
                    int updateItemQuantity = classItems.updateItemQuantity(IID, Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()));

                }
                catch(SqlException sqle)
                {
                    clsConnection.connectionclose();
                    MessageBox.Show("Enter an Item only once", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(sqle.Message);
                }
                catch (Exception ex)
                {
                    clsConnection.connectionclose();
                }
            }
            try
            {
                int insertPurchase = classPurchases.insertTopurchase(txtPurchaseId.Text, lblDate.Text, float.Parse(txtAmount.Text));
                DataTable db = classPurchases.getTopPurchaseId();
                string purchaseId = db.Rows[0][0].ToString();
                int newpurchaseId = Int32.Parse(purchaseId) + 1;
                txtPurchaseId.Text = newpurchaseId.ToString();
            }
            catch (Exception ex)
            {
                clsConnection.connectionclose();
            }
            int rowCount = dgvBillView.Rows.Count;

            for (int i = rowCount - 1; i >= 0; i--)
            {
                dgvBillView.Rows.RemoveAt(i);
            }
            dgvStockView.DataSource = classItems.itemsearchall();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStockView.DataSource = classItems.itemsearchall();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbItemDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
