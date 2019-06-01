using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MdProject
{
    class classCustomers
    {
        static DataTable db;
        string customerID;
        string customerName;
        int contactNo;
        string address;
        float customerCreditValue;

        public string cusId
        {
            get { return customerID; }
            set
            {
                customerID = value;
            }
        }
        public string cusName
        {
            get { return customerName; }
            set
            {
                if (value == "") throw new Exception("Enter Customer Name");
                customerName = value;
            }
        }
        public int cusContact
        {
            get { return contactNo; }
            set
            {
                contactNo = value;
            }
        }
        public string cusAddress
        {
            get { return address; }
            set
            {
                if (value == "") throw new Exception("Enter Customer Address");
                address = value;
            }
        }

        public float cusCreditValue
        {
            get { return customerCreditValue; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Credit value cannot be negative.");
                }
                customerCreditValue = value;
            }
        }

        public static DataTable getTopCustomerId()
        {

            string query = "select top 1 customerid from customer order by customerid desc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getCustomerId(string cusName)
        {

            string query = "select customerid from customer where customername  ='" + cusName + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getAllCustomers()
        {
            
            string query = "Select * from customer ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getCustomerName(string cusId)
        {

            string query = "select customername from customer where customerid ='" + cusId + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getAllCustomersNames()
        {

            string query = "Select customername from customer";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getCustomerCreditvalue(string cid)
        {

            string query = "select customerid,creditvalue from customer where customername  ='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getCustomerCreditvalueById(string cid)
        {

            string query = "select creditvalue from customer where customerId='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static AutoCompleteStringCollection getAutoCompleteCustomersNames()
        {

            string query = "Select customername from customer";
            AutoCompleteStringCollection collection = clsConnection.GetAutucompleteData(query);

            return collection;
        }
        public static DataTable wildCardCustomerName(string cusname)
        {
            
            string query = "Select * from customer WHERE customername LIKE '%" + cusname + "%'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getCustomerDetailsOrder(string oid)
        {
            string query = "Select c.customerid, c.customername, c.creditvalue , o.DiscountPercentage from customer c inner join orderbill o on o.customerid=c.customerid where o.orderid='" + oid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public  int insertToCustomers(classCustomers customer)
        {
            string query = "insert into customer values ( '" + customer.cusId + "', '" + customer.cusName + "', " + customer.cusContact + ", '" + customer.address + "'," + 0 + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int deleteCustomer(string cusID)
        {
            string query = "delete from customer where customerid='" + cusID + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public  int updateCustomer(classCustomers customer)
        {
            string query = "UPDATE Customer  SET CustomerName = '" + customer.cusName + "', Address = '"+ customer.address + "', Contactno='" + customer.cusContact + "', Creditvalue='"+ customer.cusCreditValue + "' where CustomerId  ='" + customer.cusId + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int updateCustomerCreditValue(string amountPaying,string customerId)
        {
            string query = "UPDATE customer SET creditvalue=creditvalue-" + amountPaying + " where customerID ='" + customerId + "'"; 
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int updateCustomerCreditValueIncrease(string creditAmount, string customerId)
        {
           
            string query = "UPDATE customer SET creditvalue=creditvalue+" + creditAmount + " where customerID ='" + customerId + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int updateCustomerCreditValueOnReturns(float amount, string customerId)
        {
            
            string query = "UPDATE customer SET creditvalue=" + amount + " where customerID ='" + customerId + "'";
            int result = clsConnection.SendQuery(query);
            return result;
        }
    }
}
