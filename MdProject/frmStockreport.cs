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
    public partial class frmStockreport : Form
    {
        public frmStockreport()
        {
            InitializeComponent();
        }

        private void frmStockreport_Load(object sender, EventArgs e)
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
                dgvstockView.DataSource = classStocks.wildCardDescription(cmbStockSelect.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReportExpDate_Click(object sender, EventArgs e)
        {
            string format = dateTimePicker1.Value.ToShortDateString();
            DateTime dt = Convert.ToDateTime(format);
            string date = dt.ToString("MM-d-yyyy");
            frmExpireDateReport frmexp = new frmExpireDateReport(date);
            frmexp.ShowDialog();
        }
    }
}
