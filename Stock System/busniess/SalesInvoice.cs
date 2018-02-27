using Stock_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.busniess
{
    class SalesInvoice
    {
        public static List<Product> fillProduct()
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            return context.Products.ToList();
        }

        public static List<string> fillCustomer()
        {
           
            List<string> strList = new List<string>();
            var query =
                (from s in Program.context.Customers
                 select s.Name).ToList<string>();
            return query;

        }

        public static List<string> fillStock()
        {
            
            List<string> strList = new List<string>();
            var query =
                (from s in Program.context.Stocks
                 select s.Location).ToList<string>();
            return query;
        }

        public static int getSalesId()
        {

            var query =
                (from s in Program.context.Sales_Order
                 select s.Id).Max();



            return (query + 1);
        }

        public static List<string> fillEmployee()
        {
            List<string> strList = new List<string>();
            var query =
                (from s in Program.context.Employees
                 select s.Name).ToList<string>();
            return query;
        }


        public static double getprice(string prodname)
        {
            var query =
                (from p in Program.context.Products
                 where p.Name == prodname
                 select p.SalePrice).First();
            return query;
        }

        public static List<double> getpriceList(List<string> names)
        {
            List<double> priceList = new List<double>();
            for (int i = 0; i < names.Count; i++)
            {
                priceList.Add(getprice(names[i]));
            }
            return priceList;
        }

        public static double getTotalPrice(List<string> prodNames, List<int> qtyList)
        {
            List<double> priceList = getpriceList(prodNames);
            double totalPrice = 0;

            for (int i = 0; i < priceList.Count; i++)
            {
                totalPrice += priceList[i] * qtyList[i];
            }
            return totalPrice;
        }


        public static int getCust_Id(string name)
        {
            var query =
                (from c in Program.context.Customers
                 where c.Name == name
                 select c.Id).First();
            return query;
        }

        public static int getStockId(string location)
        {
            var query =
                (from st in Program.context.Stocks
                 where st.Location == location
                 select st.Id).First();

            return query;
        }

        public static int getEmpId(string name)
        {
           
            var query =
                (from e in Program.context.Employees
                 where e.Name == name
                 select e.Id).First();
            return query;
        }

        public static int getprodid(string pName, string cName)
        {
            var query =
                (from p in Program.context.Products
                 where p.Name == pName && p.Company == cName
                 select p.Id).First();
            return query;
        }

        public static int getProdStockQty(string prodName)
        {
            var query =
                (from p in Program.context.Products
                 where p.Name == prodName
                 select p.Quantity).First();
            return query;
        }

        public static void MakeOrder(string Or_Type, int Emp_Id, string Cust_Name, string User_Name, DateTime SalesDate, string type, int prod_Num, int Invoice_Amount, float Invoice_Discount, float After_DIscount_Amount, int PaidAmount, int remainAmount)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            context.Create_Salles_Order_Proc(Or_Type, Emp_Id, Cust_Name, User_Name, SalesDate, type, prod_Num, Invoice_Amount, Invoice_Discount, After_DIscount_Amount, PaidAmount, remainAmount);
        }

        public static void MakeSalesDetails(int SalesOrderId, int productId, int quntity, DateTime expired, int Stock_Id)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            context.Insert_Sales_Order_Detalis_Proc(SalesOrderId, productId, quntity, expired, Stock_Id);

        }

        public static List<Object> getInvoiceDetails(int Id)
        {
            var query =
                (from p in Program.context.Sales_Order_Details
                 where p.Sales_Order_Id == Id
                 select new { p.Sales_Order_Id, p.Product.Name, p.Quantity, p.Product.SalePrice, p.ExpiredDate, CustomerName = p.Sales_Order.Customer.Name, TotalPrice = p.Sales_Order.InvoiceAmount, Discount = p.Sales_Order.InvoiceDiscount, AfterDiscount = p.Sales_Order.TotalAmount }).ToList<object>();
            return query;
        }


        public static List<object> Filter(Func<Product, bool> del)
        {
            return Program.context.Products.Where(del).Select(x => new { x.Id, x.Name, x.Company, x.Discription, x.SalePrice, x.Quantity }).ToList<object>();
        }


    }
}
