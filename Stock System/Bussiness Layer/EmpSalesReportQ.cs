using Stock_System.busniess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class EmpSalesReportQ
    {
        public static List<Emp_Sales_Reports> Display(string N_Id, DateTime startDate,DateTime endDate)
        {
            List<Emp_Sales_Reports> empsLsit = new List<Emp_Sales_Reports>();
            var empReturnedInvoices = Program.context.Emp_Returned_Sales_Invoices(N_Id, startDate, endDate).ToList();
            var empInvoices=Program.context.Emp_Sales_Invoices(N_Id, startDate, endDate).ToList();
            if(empInvoices==null)
            {
                return null;
            }
            foreach (var iItem in empInvoices)
            {
                if(empReturnedInvoices.Count == 0)
                {
                    Emp_Sales_Reports emp = new Emp_Sales_Reports
                    {
                        InvoiceDate = iItem.Date,
                        Invoice_Quantity = iItem.Invoice_Quantity,
                        Returned_Quantity = 0,
                        Sales_Total_Amount = iItem.Sales_Total_Amount,
                        Returned_Total_Price = 0,
                        AmountOfSales = "100%"
                    };
                    empsLsit.Add(emp);
                }
                else {
                    foreach (var rItem in empReturnedInvoices)
                    {
                        double amountOfSales = (((double)iItem.Invoice_Quantity - (double)rItem.Returned_Quantity) / (double)iItem.Invoice_Quantity) * 100;
                        if (iItem.Id == rItem.Id)
                        {
                            Emp_Sales_Reports emp = new Emp_Sales_Reports
                            {
                                InvoiceDate = iItem.Date,
                                Invoice_Quantity = iItem.Invoice_Quantity,
                                Returned_Quantity = rItem.Returned_Quantity,
                                Sales_Total_Amount = iItem.Sales_Total_Amount,
                                Returned_Total_Price = rItem.Returned_Total_Price,
                                AmountOfSales = (amountOfSales).ToString() + "%"
                            };
                            empsLsit.Add(emp);
                        }
                        else
                        {
                            Emp_Sales_Reports emp = new Emp_Sales_Reports
                            {
                                InvoiceDate = iItem.Date,
                                Invoice_Quantity = iItem.Invoice_Quantity,
                                Returned_Quantity = 0,
                                Sales_Total_Amount = iItem.Sales_Total_Amount,
                                Returned_Total_Price = 0,
                                AmountOfSales = "100%"
                            };
                            empsLsit.Add(emp);
                        }
                    }
                }
            }
            return empsLsit;
        }
        public static List<Employee> Emps()
        {
            return Program.context.Employees.Select(e => e).ToList(); ;
        }
    }
}
