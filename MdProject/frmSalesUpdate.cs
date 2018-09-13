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
    public partial class frmSalesUpdate : Form
    {
        public frmSalesUpdate()
        {
            InitializeComponent();
        }

        private void txtSalesId_TextChanged(object sender, EventArgs e)
        {
            try {
                dgvsalesview.DataSource = ClassSales.wildcardsalesdetailsSearch(txtSalesId.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSalesUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                dgvsalesview.DataSource = ClassSales.salesdetailsSearch();
            dgvsalesview.Columns[0].HeaderText = "Sales ID";
            dgvsalesview.Columns[1].HeaderText = "Customer Name";
            dgvsalesview.Columns[2].HeaderText = "Date";
            dgvsalesview.Columns[3].HeaderText = "Amount to be paid";
            dgvsalesview.Columns[4].HeaderText = "Amount paid";
            dgvsalesview.Columns[5].HeaderText = "Balance";
            dgvsalesview.Columns[6].HeaderText = "Discount %";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvsalesview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgvsalesview.Rows[index];
                string orderid= selectedrow.Cells[0].Value.ToString();
                frmSalesDetails formsalesdetails = new frmSalesDetails(orderid);
                formsalesdetails.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
