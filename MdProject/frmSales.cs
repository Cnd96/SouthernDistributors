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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int batchquantityvar;
        float total = 0;
        private void frmSales_Load(object sender, EventArgs e)
        {
           
            try
            {
                DataTable db = new DataTable();

                dgvStockView.DataSource = ClassSaleQuery.itemsSearch();
                dgvStockView.Columns[0].HeaderText = "Item ID";
                dgvStockView.Columns[1].HeaderText = "Batch ID";
                dgvStockView.Columns[2].HeaderText = "Item Name";
                dgvStockView.Columns[3].HeaderText = "Quantity";
                stockcombofill();
                customernamefill();
                DateTime date = DateTime.Now;
                DateLbl.Text = date.ToString("MM-d-yyyy");
                string query = "select top 1 orderid from orderbill order by orderid desc";
                db = clsConnection.GetData(query);
                string OrderId = db.Rows[0][0].ToString();
                int newOrdId = Int32.Parse(OrderId) + 1;
                txtOrderId.Text = newOrdId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            table.Columns.Add("Item Id", typeof(int));
            table.Columns.Add("Batch ID", typeof(string));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Free items", typeof(int));
            table.Columns.Add("Selling Price", typeof(float));
            table.Columns.Add("Amount ", typeof(float));
            table.Columns.Add("Expire Date", typeof(DateTime));

            dgvBill.DataSource = table;
        }
   
        private void stockcombofill()
        {
            string query = "Select itemname from item";
            DataTable dbcombo = new DataTable();
            dbcombo = clsConnection.GetData(query);
            foreach (DataRow dr in dbcombo.Rows)
            {
                cmbItemName.Items.Add(dr["itemname"].ToString());
            }
        }
        static SqlConnection con1 = new SqlConnection(@"Data Source=ASUS-CND\CHAMAL;Initial Catalog=MDProject;Integrated Security=True");
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

        private void cmbItemName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvStockView.DataSource = ClassSaleQuery.wildCardItemName(cmbItemName.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dgvStockView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgvStockView.Rows[index];

                lblItemID.Text = selectedrow.Cells[0].Value.ToString();
                lblBatchId.Text = selectedrow.Cells[1].Value.ToString();
                lblItemDesc.Text = selectedrow.Cells[2].Value.ToString();
                lblQtyAvailable.Text = selectedrow.Cells[3].Value.ToString();

                DataTable db = new DataTable();
                string query = "select sellingprice,expdate from itembatch where batchId='" + selectedrow.Cells[1].Value.ToString() + "' and itemid='" + selectedrow.Cells[0].Value.ToString() + "'";
                db = clsConnection.GetData(query);
                lblSellingPrice.Text = db.Rows[0][0].ToString();
                lblExpireDate.Text = db.Rows[0][1].ToString();
                batchquantityvar = Int32.Parse(selectedrow.Cells[3].Value.ToString());
            }
            catch (ArgumentOutOfRangeException) {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            float sellingpricevar;
            int x = 1;
            try
            {
                sellingpricevar = float.Parse(lblSellingPrice.Text);
                if (txtQuantity.ForeColor == Color.Red)
                {
                    throw new Exception("enter a valid quantity");
                }
                if (txtFreeItems.ForeColor == Color.Red)
                {
                    throw new Exception("enter a valid Free items amount");
                }
                x = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtQuantity.Text = "";
                txtFreeItems.Text = "";
            }
            if (x == 2)
            {
                if (checkboxItem.Checked == true)
                {
                    try
                    {
                        sellingpricevar = float.Parse(lblSellingPrice.Text);
                        txtDiscount.Text = "0";
                        txtDiscount.Enabled = false;
                        btnDiscount.Enabled = false;
                        table.Rows.Add(lblItemID.Text, lblBatchId.Text, lblItemDesc.Text, txtQuantity.Text, txtFreeItems.Text, lblSellingPrice.Text, sellingpricevar * Int32.Parse(txtQuantity.Text), lblExpireDate.Text);
                        dgvBill.DataSource = table;
                        total += sellingpricevar * Int32.Parse(txtQuantity.Text);
                        txtaAmount.Text = total.ToString();
                        txtTobePaid.Text = total.ToString();
                        lblItemID.Text = "";
                        lblBatchId.Text = "";
                        lblItemDesc.Text = "";
                        lblQtyAvailable.Text = "";
                        lblSellingPrice.Text = "";
                        lblExpireDate.Text = "";
                        txtQuantity.Text = "";
                        txtFreeItems.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try 
                    {
                            sellingpricevar = float.Parse(lblSellingPrice.Text);
                            table.Rows.Add(lblItemID.Text, lblBatchId.Text, lblItemDesc.Text, txtQuantity.Text, 0, lblSellingPrice.Text, sellingpricevar * Int32.Parse(txtQuantity.Text), lblExpireDate.Text);
                            dgvBill.DataSource = table;
                            total += sellingpricevar * Int32.Parse(txtQuantity.Text);
                            txtaAmount.Text = total.ToString();
                        if (total < 20000)
                        {
                            txtDiscount.Text = "4";
                        }
                        else
                        {
                            txtDiscount.Text = "15";
                        }
                            lblItemID.Text = "";
                            lblBatchId.Text = "";
                            lblItemDesc.Text = "";
                            lblQtyAvailable.Text = "";
                            lblSellingPrice.Text = "";
                            lblExpireDate.Text = "";
                            txtQuantity.Text = "";
                        txtFreeItems.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            checkboxItem.Enabled = false;
        }

        private void checkboxItem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxItem.Checked == true)
            {
                txtFreeItems.ReadOnly = false;
            }
            else
            {
                txtFreeItems.Text = "";
                txtFreeItems.ReadOnly = true;
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quantemp = Int32.Parse(txtQuantity.Text);
                if (quantemp > batchquantityvar)
                {
                    txtQuantity.ForeColor = Color.Red;
                }
                else
                {
                    txtQuantity.ForeColor = Color.Black;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedindex = dgvBill.CurrentCell.RowIndex;
                DataGridViewRow deleterow = dgvBill.Rows[selectedindex];
                total -= Int32.Parse(deleterow.Cells[6].Value.ToString());
                txtaAmount.Text = total.ToString();
                if (selectedindex > -1)
                {
                    dgvBill.Rows.RemoveAt(selectedindex);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int rowCount = dgvBill.Rows.Count;

            for (int i = rowCount - 1; i >= 0; i--)
            {
                dgvBill.Rows.RemoveAt(i);
            }
            checkboxItem.Enabled = true;
            btnDiscount.Enabled = true;
            txtDiscount.Enabled = true;
            txtDiscount.Text = "";
            txtTobePaid.Text = "";
            txttotalAmount.Text = "0";
            txtaAmount.Text = "0";
            lblItemID.Text = "";
            lblItemID.Text = "";
            lblBatchId.Text = "";
            lblItemDesc.Text = "";
            lblQtyAvailable.Text = "";
            lblSellingPrice.Text = "";
            lblExpireDate.Text = "";
            txtQuantity.Text = "";
            total = 0;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            int discoutvalidatevar = 1;
            float discountvar = 0;
            try
            {
                discountvar = float.Parse(txtDiscount.Text);
                if (discountvar > 99) throw new Exception("Enter a Valid Discount");
                discoutvalidatevar = 2;
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Enter Valid discount.");
                txtDiscount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtDiscount.Text = "";
            }
            if (discoutvalidatevar == 2)
            {
                float totalamount = Int32.Parse(txtaAmount.Text) - (Int32.Parse(txtaAmount.Text) * (discountvar / 100));
                txtTobePaid.Text = totalamount.ToString();
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            try
            {             
                DataTable db = new DataTable();
                string query = "select customername from customer where customerid ='" + txtCustomerId.Text + "'";
                db = clsConnection.GetData(query);
                txtCusName.Text = db.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtFreeItems_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int freeitemtemp = Int32.Parse(txtFreeItems.Text);
                if (Int32.Parse(txtQuantity.Text) + freeitemtemp > Int32.Parse(lblQtyAvailable.Text))
                {
                    txtFreeItems.ForeColor = Color.Red;
                }
                else
                {
                    txtFreeItems.ForeColor = Color.Black;
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
 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oid = txtOrderId.Text;
            int y = 1;
            classSalesBilling bill = new classSalesBilling();
            try
            {
                if (txtCustomerId.Text == "" || txtCusName.Text == "") throw new Exception("Enter a valid customer ID");
                if (txtTobePaid.Text == "") throw new Exception("Order Items.");
                bill.amounttobepay = float.Parse(txtTobePaid.Text);
                bill.amountpay = float.Parse(txttotalAmount.Text);
                y = 2;
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Enter valid paying amount");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (y == 2)
            {
                try
                {
                    DataTable db = new DataTable();
                    string query1 = "select creditvalue from customer where customerId='" + txtCustomerId.Text + "'";
                    db = clsConnection.GetData(query1);

                    int check = 0;
                    if (checkboxItem.Checked == true)
                    {
                        check = 1;
                    }
                    int insertorderbill = ClassSaleQuery.insertToOrderbill(txtOrderId.Text, txtCustomerId.Text, DateLbl.Text, float.Parse(txtaAmount.Text) - bill.amounttobepay, bill.amounttobepay, bill.amountpay, bill.credit, float.Parse(txtDiscount.Text));
                    string query = "UPDATE customer SET creditvalue=creditvalue+" + bill.credit + " where customerID ='" + txtCustomerId.Text + "'";
                    clsConnection.SendQuery(query);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                for (int i = 0; i < dgvBill.Rows.Count; i++)
                {
                    try
                    {
                        int insertOrderDetails = ClassSaleQuery.insertToOrderDetails(txtOrderId.Text, dgvBill.Rows[i].Cells[0].Value.ToString(), dgvBill.Rows[i].Cells[1].Value.ToString(), Int32.Parse(dgvBill.Rows[i].Cells[3].Value.ToString()), Int32.Parse(dgvBill.Rows[i].Cells[4].Value.ToString()), float.Parse(dgvBill.Rows[i].Cells[6].Value.ToString()));

                        int purchseamnt = Int32.Parse(dgvBill.Rows[i].Cells[3].Value.ToString()) + Int32.Parse(dgvBill.Rows[i].Cells[4].Value.ToString());

                        string query = "UPDATE item SET Qty=Qty-" + purchseamnt + " where ItemID ='" + dgvBill.Rows[i].Cells[0].Value.ToString() + "'";
                        clsConnection.SendQuery(query);

                        string query2 = "UPDATE itembatch SET  Quantity=Quantity-" + purchseamnt + " where BatchID ='" + dgvBill.Rows[i].Cells[1].Value.ToString() + "' and itemid='" + dgvBill.Rows[i].Cells[0].Value.ToString() + "'";
                        clsConnection.SendQuery(query2);

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                    int rowCount = dgvBill.Rows.Count;
                    for (int x = rowCount - 1; x >= 0; x--)
                    {
                        dgvBill.Rows.RemoveAt(x);
                    }
                    checkboxItem.Enabled = true;
                    btnDiscount.Enabled = true;
                    txtDiscount.Enabled = true;
                    txtDiscount.Text = "";
                    txtTobePaid.Text = "";
                    txttotalAmount.Text = "";
                    txtaAmount.Text = "";
                    txtCustomerId.Text = "";
                    txtCusName.Text = "";
                    DataTable db1 = new DataTable();
                try
                {
                    dgvStockView.DataSource = ClassSaleQuery.itemsSearch();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                frmSalesInvoice frinvoice = new frmSalesInvoice(oid);
                frinvoice.ShowDialog();

            }
        }

        private void cmbCustomerName_TextChanged(object sender, EventArgs e)
        {          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBill.Rows.Count; i++)
            {
                MessageBox.Show(" " + Int32.Parse(dgvBill.Rows[i].Cells[3].Value.ToString()) + "  " + Int32.Parse(dgvBill.Rows[i].Cells[4].Value.ToString()));
            }

        }

        private void txtCusName_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable db = new DataTable();
                string query = "select customerid from customer where customername  ='" + txtCusName.Text + "'";
                db = clsConnection.GetData(query);
                    txtCustomerId.Text = db.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtCustomerId_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtaAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTobePaid_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txttotalAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtCusName_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttotalAmount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
