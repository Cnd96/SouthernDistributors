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
    public partial class frmSalesDetails : Form
    {
        public frmSalesDetails()
        {
            InitializeComponent();
        }
        string orderid;
        string prevcusid;
        string newcusid;
        public frmSalesDetails(string oid)
        {
            InitializeComponent();
            orderid = oid;
            try
            {
                customernamefill();
                txtOrderId.Text = orderid;             
                DataTable db = new DataTable();
                db = ClassSaleQuery.customersearchfromorder(orderid);
                txtCustomerId.Text = db.Rows[0][0].ToString();
                prevcusid = db.Rows[0][0].ToString();
                txtCustomerName.Text = db.Rows[0][1].ToString();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmSalesDetails(string oid,int x)
        {
            InitializeComponent();
            orderid = oid;
            try
            {
                customernamefill();
                txtOrderId.Text = orderid;
                DataTable db = new DataTable();
                db = ClassSaleQuery.customersearchfromorder(orderid);
                txtCustomerId.Text = db.Rows[0][0].ToString();
                prevcusid = db.Rows[0][0].ToString();
                txtCustomerName.Text = db.Rows[0][1].ToString();
                btndelete.Visible = false;
                btnUpdate.Visible = false;
                txtCustomerName.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmSalesDetails_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSalesdetails.DataSource = ClassSaleQuery.salesUpdatebillsearch(orderid);
            dgvSalesdetails.Columns[0].HeaderText = "Item ID";
            dgvSalesdetails.Columns[1].HeaderText = "Batch ID";
            dgvSalesdetails.Columns[2].HeaderText = "Item Name";
            dgvSalesdetails.Columns[3].HeaderText = "Quantity";
            dgvSalesdetails.Columns[4].HeaderText = "Discount Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                txtCustomerName.AutoCompleteCustomSource = collection;
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (prevcusid == txtCustomerId.Text)
            {
                MessageBox.Show("No updates");
            }
                else
                {
                    DataTable db = new DataTable();
                    string query = "select creditvalue from orderbill where orderid='" + txtOrderId.Text + "'";
                    db = clsConnection.GetData(query);
                    float creditvalue = float.Parse(db.Rows[0][0].ToString());
                    
                    string query1 = "UPDATE customer SET creditvalue=creditvalue-" + creditvalue + " where customerID ='" + prevcusid + "'";
                    clsConnection.SendQuery(query1);

                    string query2 = "UPDATE customer SET creditvalue=creditvalue+" + creditvalue + " where customerID ='" + txtCustomerId.Text + "'";
                    clsConnection.SendQuery(query2);

                    string query3 = "UPDATE orderbill SET  customerID ='" + txtCustomerId.Text + "' where orderid='" + txtOrderId.Text + "'";
                    clsConnection.SendQuery(query3);

                    MessageBox.Show("Updated Successfully.");
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable db = new DataTable();
                string query = "select customerid from customer where customername  ='" + txtCustomerName.Text + "'";
                db = clsConnection.GetData(query);
                txtCustomerId.Text = db.Rows[0][0].ToString();
                newcusid = db.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgvSalesdetails.Rows.Count; i++)
                {

                    try
                    {

                        string IID = dgvSalesdetails.Rows[i].Cells[0].Value.ToString();
                        string BID = dgvSalesdetails.Rows[i].Cells[1].Value.ToString();

                        int quantity = Int32.Parse(dgvSalesdetails.Rows[i].Cells[3].Value.ToString()) + Int32.Parse(dgvSalesdetails.Rows[i].Cells[4].Value.ToString());
                        string query = "UPDATE item SET Qty=Qty+" + quantity + " where ItemID ='" + IID + "'";
                        clsConnection.SendQuery(query);

                        string query1 = "UPDATE itembatch SET Quantity=Quantity+" + quantity + " where ItemID ='" + IID + "' and batchid='" + BID + "'";
                        clsConnection.SendQuery(query1);

                        string query2 = "delete from orderbill where orderid='" + txtOrderId.Text + "'";
                        clsConnection.SendQuery(query2);

                        string query3 = "delete from orderdetails where orderid='" + txtOrderId.Text + "'";
                        clsConnection.SendQuery(query3);


                        this.Close();

                    }
                    catch (SqlException sexc)
                    {
                        clsConnection.connectionclose();
                        MessageBox.Show("Enter an Item only once", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        clsConnection.connectionclose();
                    }
                }
                MessageBox.Show("Deleted Successfully");
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
