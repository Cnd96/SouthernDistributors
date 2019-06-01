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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomerlist.DataSource = classCustomers.getAllCustomers();
            dgvCustomerlist.Columns[0].HeaderText = "Customer ID";
            dgvCustomerlist.Columns[1].HeaderText = "Customer Name";
            dgvCustomerlist.Columns[2].HeaderText = "Contact no";
            dgvCustomerlist.Columns[3].HeaderText = "Address";
            dgvCustomerlist.Columns[4].HeaderText = "Credit Value";

            customercombofill();
        }
        private void customercombofill()
        {
            
            DataTable dbcombo = classCustomers.getAllCustomersNames();
            foreach (DataRow dr in dbcombo.Rows)
            {
                cmbCustomerSelect.Items.Add(dr["customername"].ToString());
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmaddc = new frmAddCustomer();
            frmaddc.ShowDialog();
        }

        private void cmbCustomerSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dgvCustomerlist.RowCount == 1)
                {

                    int index = 0;
                    DataGridViewRow selectedrow = dgvCustomerlist.Rows[index];

                    String IID = selectedrow.Cells[0].Value.ToString();
                    string name = selectedrow.Cells[1].Value.ToString();
                    string telephone = selectedrow.Cells[2].Value.ToString();
                    string address = selectedrow.Cells[3].Value.ToString();
                    string credit = selectedrow.Cells[4].Value.ToString();
                    frmAddCustomer frmaddc = new frmAddCustomer(IID, name, telephone, address, credit);
                    frmaddc.ShowDialog();
                }
            }
        }

        private void cmbCustomerSelect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCustomerlist.DataSource = classCustomers.wildCardCustomerName(cmbCustomerSelect.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomerlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgvCustomerlist.Rows[index];

                String IID = selectedrow.Cells[0].Value.ToString();
                string name = selectedrow.Cells[1].Value.ToString();
                string telephone = selectedrow.Cells[2].Value.ToString();
                string address = selectedrow.Cells[3].Value.ToString();
                string credit = selectedrow.Cells[4].Value.ToString();
                frmAddCustomer frmaddc = new frmAddCustomer(IID, name, telephone, address, credit);
                frmaddc.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IndexOutOfRangeException sex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomerlist.DataSource = classCustomers.getAllCustomers();
        }
    }
}
