using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class ClassPayments
    {
        static DataTable db;
        string paymentId;
        classCustomers Customer;
        float paymentAmount;
        string paymentDate;
      
        public ClassPayments()
        {
            Customer = new classCustomers();
        }
        public string paymentid
        {
            get { return paymentId; }
            set
            {
                paymentId = value;
            }
        }
        public string customerid
        {
            get { return Customer.cusId; }
            set
            {
                Customer.cusId = value;
            }
        }
        public string paymentdate
        {
            get { return paymentDate; }
            set
            {
                paymentDate = value;
            }
        }
        public float paymentamount
        {
            get { return paymentAmount; }
            set
            {
                paymentAmount = value;
            }
        }
  
   

        public static DataTable getPaymentId()
        {
            string query = "select top 1 paymentid from payment order by paymentid desc";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable PaymentSearch()
        {
            string query = "Select p.paymentid,c.customerid,c.customername,p.date,p.amount from payment p inner join customer c on p.customerid=c.customerid";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable customerPaymentSearch(string cid)
        {
            string query = "Select p.paymentid,c.customername,p.date,p.amount from payment p inner join customer c on p.customerid=c.customerid where c.customerid='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public  int insertTopayment(ClassPayments payment)
        {
            string query = "insert payment values ('" + payment.paymentid + "', '" + payment.customerid + "',  '" + payment.paymentdate + "', " + payment.paymentamount + "); ";
            int result = clsConnection.SendQuery(query);
            return result;
        }

    }
}
