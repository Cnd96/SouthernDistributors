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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder fro = new frmOrder();
            fro.ShowDialog();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            frmSales frs = new frmSales();
            frs.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            frmCustomer frc = new frmCustomer();
            frc.ShowDialog();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            frmReturns frr = new frmReturns();
            frr.ShowDialog();
        }

        private void btnStocksview_Click(object sender, EventArgs e)
        {
            frmStocks frstocks = new frmStocks();
            frstocks.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayments frpay = new frmPayments();
            frpay.ShowDialog();
        }

        private void btnSalesUpdate_Click(object sender, EventArgs e)
        {
            frmSalesUpdate frsalesupdate = new frmSalesUpdate();
            frsalesupdate.ShowDialog();
        }
        //
        //
        //***Code for button hover effects:
        //
        // Order button hover effect:
        //
        private void btnOrder_MouseEnter(object sender, EventArgs e) => btnOrder.BackgroundImage = Properties.Resources.Order2;
        private void btnOrder_MouseLeave(object sender, EventArgs e) => btnOrder.BackgroundImage = Properties.Resources.Order;
        //
        // Sales button hover effect:
        //
        private void btnsales_MouseEnter(object sender, EventArgs e) => btnsales.BackgroundImage = Properties.Resources.Sales2;
        private void btnsales_MouseLeave(object sender, EventArgs e) => btnsales.BackgroundImage = Properties.Resources.Sales;
        //
        // Returns button hover effect:
        //
        private void btnReturns_MouseEnter(object sender, EventArgs e) => btnReturns.BackgroundImage = Properties.Resources.Return2;
        private void btnReturns_MouseLeave(object sender, EventArgs e) => btnReturns.BackgroundImage = Properties.Resources.Return;
        //
        // Customers button hover effect:
        //
        private void btncustomers_MouseEnter(object sender, EventArgs e) => btncustomers.BackgroundImage = Properties.Resources.Customer2;
        private void btncustomers_MouseLeave(object sender, EventArgs e) => btncustomers.BackgroundImage = Properties.Resources.Customer;
        //
        // Side pannel view button hover effect:
        //
        private void btnSidePannelView_MouseEnter(object sender, EventArgs e) => btnSidePannelView.BackgroundImage = Properties.Resources.listView2;
        private void btnSidePannelView_MouseLeave(object sender, EventArgs e) => btnSidePannelView.BackgroundImage = Properties.Resources.listView1;
        //
        //
        // ***Auto hide code for side panel
        //
        private void btnSidePannelView_Click(object sender, EventArgs e) => pnlSidePanel.Visible = true;
         private void frmMain_MouseEnter(object sender, EventArgs e) => pnlSidePanel.Visible = false;
        //
        //
        // ***Close button code:
        //
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        //
        //
        // ***Miniize button code:
        //
        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            frmSalesReport frs = new frmSalesReport();
            frs.ShowDialog();
        }

        private void btnStocksReport_Click(object sender, EventArgs e)
        {
            frmStockreport frs = new frmStockreport();
            frs.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerReports frc = new frmCustomerReports();
            frc.ShowDialog();
        }
    }
}
