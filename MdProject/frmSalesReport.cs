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
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {

            try
            {
                dgvsalesview.DataSource = ClassSaleQuery.salesdetailsSearch();
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

        private void txtSalesId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvsalesview.DataSource = ClassSaleQuery.wildcardsalesdetailsSearch(txtSalesId.Text);
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
                string orderid = selectedrow.Cells[0].Value.ToString();
                frmSalesDetails formsalesdetails = new frmSalesDetails(orderid,1);
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

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            if (cmbmonth.SelectedIndex < 0)
            {
                MessageBox.Show("Select a month");
            }
            else if(cmbmonth.SelectedIndex==0)
            {
                frmSalesReportView frmexp = new frmSalesReportView(1,cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 1)
            {
                frmSalesReportView frmexp = new frmSalesReportView(2, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 2)
            {
                frmSalesReportView frmexp = new frmSalesReportView(3, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 3)
            {
                frmSalesReportView frmexp = new frmSalesReportView(4, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 4)
            {
                frmSalesReportView frmexp = new frmSalesReportView(5, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 5)
            {
                frmSalesReportView frmexp = new frmSalesReportView(6, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 6)
            {
                frmSalesReportView frmexp = new frmSalesReportView(7, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 7)
            {
                frmSalesReportView frmexp = new frmSalesReportView(8, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 8)
            {
                frmSalesReportView frmexp = new frmSalesReportView(9, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 9)
            {
                frmSalesReportView frmexp = new frmSalesReportView(10, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 10)
            {
                frmSalesReportView frmexp = new frmSalesReportView(11, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            else if (cmbmonth.SelectedIndex == 11)
            {
                frmSalesReportView frmexp = new frmSalesReportView(12, cmbmonth.Text);
                frmexp.ShowDialog();
            }
            
            
        }
    }
}
