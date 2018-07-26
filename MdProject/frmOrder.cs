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
        private void frmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable db = new DataTable();
                string query = "select top 1 purchaseid from purchase order by  purchaseid desc";
                db = clsConnection.GetData(query);
                string purchaseId = db.Rows[0][0].ToString();
                int newpurchaseId = Int32.Parse(purchaseId) + 1;
                txtPurchaseId.Text = newpurchaseId.ToString();

                dgvStockView.DataSource = classOrderQuery.itemsearchall();
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
            stockcombofill();
        }
        private void stockcombofill()
        {
            string query ="Select ItemName from Item";
            DataTable dbcombo = new DataTable();
            dbcombo = clsConnection.GetData(query);
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
                DataTable db = new DataTable();
                DataTable db1 = new DataTable();
                string query = "select * from Item where ItemID ='" + IID + "'";
                string query1 = "select top 1 batchid from itembatchid where itemid="+IID+" order by itemid desc ";
                db1= clsConnection.GetData(query1);
                db = clsConnection.GetData(query);
                DateTime date = DateTime.Now;
                lblItemId.Text = db.Rows[0][0].ToString();
                lblItemName.Text = db.Rows[0][1].ToString();
                lblItemDesc.Text = db.Rows[0][3].ToString();
                txtBatchId.Text = (Int32.Parse(db1.Rows[0][0].ToString())+1).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IndexOutOfRangeException sex)
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
            classOrderBill bll = new classOrderBill();

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
                dgvStockView.DataSource = classOrderQuery.wildCardDescription(cmbItemDesc.Text);             
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
                    db1 = classOrderQuery.itemSelectItemId(IID);
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

                    int insertBatchItem = classOrderQuery.insertToBatchItem(dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString());
                    int insertBatch = classOrderQuery.insertToBatch(dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString(), float.Parse(dgvBillView.Rows[i].Cells[3].Value.ToString()), date, Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()), float.Parse(dgvBillView.Rows[i].Cells[4].Value.ToString()));
                    int insertopurchasedetails = classOrderQuery.insertpurchaseDetails(txtPurchaseId.Text, dgvBillView.Rows[i].Cells[0].Value.ToString(), dgvBillView.Rows[i].Cells[1].Value.ToString(), Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()));
                    string IID =dgvBillView.Rows[i].Cells[0].Value.ToString();

                    string query = "UPDATE item SET Qty=Qty+"+ Int32.Parse(dgvBillView.Rows[i].Cells[5].Value.ToString()) + " where ItemID ='" + IID + "'";
                    clsConnection.SendQuery(query);
                    
                }
                catch(SqlException sexc)
                {
                    clsConnection.connectionclose();
                    MessageBox.Show("Enter an Item only once", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(sexc.Message);
                }
                catch (Exception ex)
                {
                    clsConnection.connectionclose();
                }
            }
            try
            {
                int insertPurchase = classOrderQuery.insertTopurchase(txtPurchaseId.Text, lblDate.Text, float.Parse(txtAmount.Text));
                DataTable db = new DataTable();
                string query = "select top 1 purchaseid from purchase order by  purchaseid desc";
                db = clsConnection.GetData(query);
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
            dgvStockView.DataSource = classOrderQuery.itemsearchall();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStockView.DataSource = classOrderQuery.itemsearchall();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
