using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public static DataTable getCustomerId()
        {

            string query = "select top 1 customerid from customer order by customerid desc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable getAllCustomers()
        {
            
            string query = "Select * from customer ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildCardCustomerName(string cusname)
        {
            
            string query = "Select * from customer WHERE customername LIKE '%" + cusname + "%'";
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
    }
}
