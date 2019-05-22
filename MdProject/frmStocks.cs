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
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            try
            {
                dgvstockView.DataSource = classStocks.itemsSearch();
                dgvstockView.Columns[0].HeaderText = "Item ID";
                dgvstockView.Columns[1].HeaderText = "Batch ID";
                dgvstockView.Columns[2].HeaderText = "Item Category";
                dgvstockView.Columns[3].HeaderText = "Item Name";
                dgvstockView.Columns[4].HeaderText = "Quantity";
                dgvstockView.Columns[5].HeaderText = "Selling Price";
                dgvstockView.Columns[6].HeaderText = "Expire Date";
                stockcombofill();
            }
            catch (Exception)
            {

            }

        }
        private void stockcombofill()
        {
            string query = "Select ItemName from Item";
            DataTable dbcombo = new DataTable();
            dbcombo = clsConnection.GetData(query);
            foreach (DataRow dr in dbcombo.Rows)
            {
                cmbStockSelect.Items.Add(dr["ItemName"].ToString());
            }
        }

        private void cmbStockSelect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvstockView.DataSource =classStocks.wildCardDescription(cmbStockSelect.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvstockView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgvstockView.Rows[index];

                string iid = selectedrow.Cells[0].Value.ToString();
                string bid = selectedrow.Cells[1].Value.ToString();
                string icategory = selectedrow.Cells[2].Value.ToString();
                string iname = selectedrow.Cells[3].Value.ToString();
                string qty = selectedrow.Cells[4].Value.ToString();
                string sellprice = selectedrow.Cells[5].Value.ToString();
                string exp = selectedrow.Cells[6].Value.ToString();

                var frmnew = new frmUpdateStock
                {
                    itemId = iid,
                    batchId = bid,
                    itemCategory = icategory,
                    itemName = iname,
                    quantity = qty,
                    sellingPrice = sellprice,
                    expDate = exp
                };
                frmnew.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void dgvstockView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
