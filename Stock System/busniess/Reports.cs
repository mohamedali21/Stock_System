using stock.VM;
using Stock_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.busniess
{
    class Reports
    {
        static public List<EmployeeVM> EmpLogs()
        {
            List<EmployeeVM> emplist = new List<VM.EmployeeVM>();
            EmployeeVM emp;
            var query =
                from e in Program.context.Employees
                select e;
            foreach (var item in query)
            {
                emp = new VM.EmployeeVM();
                emp.Id = item.Id;
                emp.N_Id = item.N_Id;
                emp.Name = item.Name;
                emp.phone = item.phone;
                emp.JobTitle = item.JobTitle;
                item.Address = item.Address;
                emp.HireDate = item.HireDate;
                emplist.Add(emp);
            }
            return emplist;
        }

        public static List<PurchaseOrderVM> purchaseReport()
        {
           
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            Plist = convert();
            return Plist;
        }

        public static List<PurchaseOrderVM> selectedReport(int num)
        {
            List<PurchaseOrderVM> plist = new List<PurchaseOrderVM>();
            switch (num)
            {
                case 1:
                    plist = getLastDayList(0);
                    break;
                case 6:
                    plist = getLastDayList(6);
                    break;
                case 30:
                    plist = getLastDayList(30);
                    break;
                case 365:
                    plist = getLastDayList(365);
                    break;
                default:
                    plist = getLastDayList(0);
                    break;
            }
            return plist;
        }
        public static List<PurchaseOrderVM> getLastDayList(int num)
        {
            Stock_SystemEntities contex = new Stock_SystemEntities();
            DateTime nowDay = DateTime.Today.AddDays(-num);
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            List<PurchaseOrderVM> newList = new List<VM.PurchaseOrderVM>();
            Plist = convert();
            foreach (var item in Plist)
            {
                if (item.RecivedDate >= nowDay)
                    newList.Add(item);
            }
            return newList;
        }

        public static List<PurchaseOrderVM> Interval(DateTime fromDate, DateTime toDate)
        {
            Stock_SystemEntities context = new Stock_SystemEntities();
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            List<PurchaseOrderVM> newList = new List<VM.PurchaseOrderVM>();
            Plist = convert();
            foreach (var item in Plist)
            {
                if (item.RecivedDate >= fromDate && item.RecivedDate <= toDate)
                    newList.Add(item);
            }
            return newList;
        }

        public static List<PurchaseOrderVM> PurchaseBySuppName(string suppName)
        {
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            List<PurchaseOrderVM> newList = new List<VM.PurchaseOrderVM>();
            Plist = convert();
            foreach (var item in Plist)
            {
                if (item.S_Name.ToLower().Contains(suppName.ToLower()))
                    newList.Add(item);
            }
            return newList;
        }

        

        public static List<PurchaseOrderVM> BySuppNameInterval(string suppName,DateTime from, DateTime to)
        {
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            List<PurchaseOrderVM> newList = new List<VM.PurchaseOrderVM>();
            Plist = convert();
            foreach (var item in Plist)
            {
                if (item.S_Name.ToLower().Contains(suppName.ToLower()) && item.RecivedDate >= from && item.RecivedDate <= to)
                    newList.Add(item);
            }
            return newList;
        }
        public static List<PurchaseOrderVM> convert()
        {
            List<PurchaseOrderVM> Plist = new List<PurchaseOrderVM>();
            PurchaseOrderVM pOrderVM;
            var query =
            from p in Program.context.Purchase_Order
            from s in Program.context.Suppliers
            where p.Supplier_Id == s.Id
            select new { p.Id, p.Order_Id, p.InvoiceNo, p.RecivedDate, p.IssuedDate, p.Type, p.NumOfProducts, p.InvoiceAmount, s.Name };
            foreach (var item in query)
            {
                pOrderVM = new PurchaseOrderVM();
                pOrderVM.Id += item.Id;
                pOrderVM.Order_Id = item.Order_Id;
                pOrderVM.InvoiceNo = item.InvoiceNo;
                pOrderVM.RecivedDate = item.RecivedDate;
                pOrderVM.IssuedDate = item.IssuedDate;
                pOrderVM.Type = item.Type;
                pOrderVM.NumOfProducts = item.NumOfProducts;
                pOrderVM.InvoiceAmount = item.InvoiceAmount;
                pOrderVM.S_Name = item.Name;
                Plist.Add(pOrderVM);
            }
            return Plist;
        }

        public static int getTotalAmount(List<int> invoiceAmountList)
        {
            int totalAmount = 0;
            foreach (int item in invoiceAmountList)
            {
                totalAmount += item;
            }
            return totalAmount;
        }


        public static List<SalesOrderVM> convertToSOrderVM()
        {
            List<SalesOrderVM> Plist = new List<SalesOrderVM>();
            SalesOrderVM pOrderVM;
            var query =
            from p in Program.context.Sales_Order
            from s in Program.context.Customers
            where p.Customer_Id == s.Id
            select new { p.Id,p.Date,  p.Type, p.NumOfProducts, p.InvoiceAmount, p.InvoiceDiscount, p.TotalAmount, s.Name };
            foreach (var item in query)
            {
                pOrderVM = new SalesOrderVM();
                pOrderVM.Id = item.Id;
                pOrderVM.Date = item.Date;
                pOrderVM.Type = item.Type;
                pOrderVM.NumOfProducts = item.NumOfProducts;
                pOrderVM.InvoiceAmount = item.InvoiceAmount;
                pOrderVM.InvoiceDiscount = item.InvoiceDiscount;
                pOrderVM.TotalAmount = item.TotalAmount;
                pOrderVM.CName = item.Name;
                
                Plist.Add(pOrderVM);
            }
            return Plist;
        }
        public static List<SalesOrderVM> SalesReport()
        {

            List<SalesOrderVM> Plist = new List<SalesOrderVM>();
            Plist = convertToSOrderVM();
            return Plist;
        }

        public static float getTotalSales(List<float> invoiceAmountList)
        {
            float totalAmount = 0;
            foreach (int item in invoiceAmountList)
            {
                totalAmount += item;
            }
            return totalAmount;
        }

        public static List<SalesOrderVM> selectedSalesReport(int num)
        {
            List<SalesOrderVM> plist = new List<SalesOrderVM>();
            switch (num)
            {
                case 1:
                    plist = getLastDaySales(0);
                    break;
                case 6:
                    plist = getLastDaySales(6);
                    break;
                case 30:
                    plist = getLastDaySales(30);
                    break;
                case 365:
                    plist = getLastDaySales(365);
                    break;
                default:
                    plist = getLastDaySales(0);
                    break;
            }
            return plist;
        }


        public static List<SalesOrderVM> getLastDaySales(int num)
        {
            DateTime nowDay = DateTime.Today.AddDays(-num);
            List<SalesOrderVM> Plist = new List<SalesOrderVM>();
            List<SalesOrderVM> newList = new List<SalesOrderVM>();
            Plist = convertToSOrderVM();
            foreach (var item in Plist)
            {
                if (item.Date >= nowDay)
                    newList.Add(item);
            }
            return newList;
        }


        public static List<SalesOrderVM> ByCustNameInterval(string custName, DateTime from, DateTime to)
        {
            List<SalesOrderVM> Plist = new List<SalesOrderVM>();
            List<SalesOrderVM> newList = new List<VM.SalesOrderVM>();
            Plist = convertToSOrderVM();
            foreach (var item in Plist)
            {
                if (item.CName.ToLower().Contains(custName.ToLower()) && item.Date >= from && item.Date <= to)
                    newList.Add(item);
            }
            return newList;
        }


        public static List<SalesOrderVM> SalesByCustName(string custName)
        {
            List<SalesOrderVM> Plist = new List<SalesOrderVM>();
            List<SalesOrderVM> newList = new List<SalesOrderVM>();
            Plist = convertToSOrderVM();
            foreach (var item in Plist)
            {
                if (item.CName.ToLower().Contains(custName.ToLower()))
                    newList.Add(item);
            }
            return newList;
        }

    }
}
