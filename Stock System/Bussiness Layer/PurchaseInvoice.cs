using Stock_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class PurchaseInvoice
    {
        public static List<Product> fillProduct()
        {
            Stock_SystemEntities enti = new Stock_SystemEntities();
            return enti.Products.ToList();
        }

        public static List<string> fillSupplier()
        {
            List<string> strList = new List<string>();
            var query =
                (from s in Program.context.Suppliers
                 select s.Name).ToList<string>();
            return query;
            
        }

        public static List<string> fillEmps()
        {
            var query =
                (from e in Program.context.Employees
                 select e.Name).ToList<string>();

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

        public static double getprice ( string prodname)
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

        public static double getTotalPrice(List<string> prodNames,List<int> qtyList)
        {
            List<double> priceList = getpriceList(prodNames);
            double totalPrice = 0;

            for (int i = 0; i < priceList.Count; i++)
            {
                totalPrice += priceList[i] * qtyList[i];
            }
            return totalPrice;
        }

        public static int getSuppId(string suppName)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            var query =
                (from s in context.Suppliers
                 where s.Name == suppName
                 select s.Id).First();
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

        //public static void MakeOrder(string Or_Type, string User_Name, int Supplier_Id, int Invo_Num, DateTime Recive, DateTime Issued, string type, int prod_Num, int price)
        //{
        //    Stock_SystemEntities senti = new Stock_SystemEntities();
        //    Program.context.CreatePurchaseOrderProc2(Or_Type, User_Name, Supplier_Id, Invo_Num, Recive, Issued, type, prod_Num, price);
        //}

        public static void MakeOrder(string Or_Type, string User_Name, int Supplier_Id, int Invo_Num, DateTime Recive, DateTime Issued, string type, int prod_Num, int price, int paidAmount, int remainAmount)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            context.CreatePurchaseOrderProc2(Or_Type, User_Name, Supplier_Id, Invo_Num, Recive, Issued, type, prod_Num, price, paidAmount, remainAmount);
            //MessageBox.Show("Success");
            //this.Close();
        }

        public static int getPurchaseId(int invoiceNum)
        {
            var query =
                (from pur in Program.context.Purchase_Order
                 where pur.InvoiceNo == invoiceNum
                 select pur.Id).First();

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

        public static void MakeOrderDetails(int purchaseOrderId, int productId, int quntity, DateTime recive, int Stock_Id)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            context.Insert_Purchase_Order_Detalis_Proc(purchaseOrderId, productId, quntity, recive, Stock_Id);
        }



        //public static List<Object> getInvoiceDetails(int Id)
        //{
        //    var query =
        //        (from p in Program.context.Purchase_Order_Detalis
        //         where p.Pruchase_Order_Id == Id
        //         select new { p.Pruchase_Order_Id, p.Product.Name, p.Quantity, p.Product.SalePrice, p.ExpiredDate}).ToList<object>();
        //    return query;
        //}

        public static List<Object> getInvoiceDetails(int Id)
        {
            var query =
                (from p in Program.context.Purchase_Order_Detalis
                 where p.Pruchase_Order_Id == Id
                 select new { p.Pruchase_Order_Id, p.Product.Name, p.Quantity, p.Product.SalePrice, p.ExpiredDate, invoiceAmount = p.Purchase_Order.InvoiceAmount, paidAmountt = p.Purchase_Order.Paid_Amount, RemainAmount = p.Purchase_Order.Remain_Amount }).ToList<object>();
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

        public static List<object> Filter(Func<Product, bool> del)
        {
            return Program.context.Products.Where(del).Select(x => new { x.Id, x.Name, x.Company, x.Discription, x.SalePrice, x.Quantity }).ToList<object>();
        }


        public static bool IsAddedBefor(int invNum)
        {
            var query =
                (from p in Program.context.Purchase_Order
                 select p.InvoiceNo).ToList<int>();
            foreach (var item in query)
            {
                if (item == invNum)
                    return true;
            }
            return false;

        }





    }
}
