using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MdProject
{
    class ClassSales
    {
        static DataTable db;
        string orderID;
        string customerId;
        string Date;  
        float creditValue;
        float Discount;
        float amountToBePaid;
        float amountPaid;
        float discountPercentage;
        float Total;

        public string orderid
        {
            get { return orderID; }
            set
            {
                if (value == "") throw new Exception("Enter Order ID");
                orderID = value;
            }
        }
        public string customerid
        {
            get { return customerId; }
            set
            {
                if (value == "") throw new Exception("Enter Customer ID");
                customerId = value;
            }
        }
        public string date
        {
            get { return Date; }
            set
            {
                Date = value;
            }
        }
        public static DataTable getTopSalesId()
        {

            string query = "select top 1 orderid from sales order by orderid desc";
            db = clsConnection.GetData(query);

            return db;
        }
        public float creditvalue
        {
            get { return creditValue; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Credit value cannot be negative.");
                }
                creditValue = value;
            }
        }
        public float discount
        {
            get { return Discount; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Discount amount cannot be negative.");
                }
                Discount = value;
            }
        }
        public float amountobepaid
        {
            get { return amountToBePaid; }
            set
            {
                amountToBePaid = value;
            }
        }
        public float amountpaid
        {
            get { return amountPaid; }
            set
            {
                amountPaid = value;
            }
        }
        public float discountpercentage
        {
            get { return discountPercentage; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Discount percentage cannot be negative.");
                }
                discountPercentage = value;
            }
        }
        public float total
        {
            get { return Total; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Total amount cannot be negative.");
                }
                Total = value;
            }
        }


        public  int insertSale(ClassSales sale)
        {
            string query = "INSERT INTO sales VALUES  ( '" + sale.orderid + "','" + sale.customerid + "','" + sale.date + "', " + sale.discount + ", " + sale.amountobepaid + ", " + sale.amountpaid + ", " + sale.creditvalue + ", " + sale.discountpercentage + ", " + sale.total  + ");";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static int insertToOrderDetails(string oid, string iid, string bid, int quantity, int discountItems,float amount)
        {
           
            string query = "INSERT INTO SalesBatch VALUES  ( '" + oid + "','" + iid + "','" + bid + "', " + quantity + ", " + discountItems + ", " + amount + ");";
            int result = clsConnection.SendQuery(query);
            return result;
        }
        public static DataTable salesdetailsSearch()
        {

   
            string query = "Select s.orderid, c.customername, s.date, s.amounttobepaid, s.amountpaid, s.creditvalue, s.discountpercentage from sales s inner join customer c on c.customerid=s.customerid ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable salesdetailsSearch2(string cid)
        {


            string query = "Select s.orderid, c.customername, s.date, s.amounttobepaid, s.amountpaid, s.creditvalue from sales s inner join customer c on c.customerid=s.customerid  where c.customerid='" + cid + "'";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable wildcardsalesdetailsSearch(string oid)
        {

            string query = "Select s.orderid, c.customername,s.date,s.amounttobepaid,s.amountpaid,s.creditvalue,s.discountpercentage from sales s inner join customer c on c.customerid=s.customerid where s.orderid like '" + oid+"%'";
            db = clsConnection.GetData(query);
            
            return db;
        }
        public static DataTable salesSearch()
        {

      
            string query = "Select od.itemid, od.batchid, i.itemname,od.qty,od.discoutnitems, ";
            db = clsConnection.GetData(query);

            return db;
        }
        public static DataTable customersearchfromSales(string oid)
        {

       
            string query = "Select c.customerid ,c.customername from customer c inner join sales s on c.customerid=s.customerid where orderid='" + oid+"'";
            db = clsConnection.GetData(query);

            return db;
        }

        public static DataTable salesUpdatebillsearch(string oid)
        {

            string query = "Select od.itemid,od.batchid,i.itemname,od.qty,od.discountitems from item i inner join SalesBatch od on od.itemid=i.itemid where orderid='" + oid +"'";
            db = clsConnection.GetData(query);

            return db;
        }
        
    }
}
