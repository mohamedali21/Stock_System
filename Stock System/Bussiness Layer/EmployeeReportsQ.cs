using Stock_System.Bussiness_Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace Stock_System.Bussiness_Layer
{
    class EmployeeReportsQ
    {

        static List<Order> EmpOrders(int empID)
        {
           
            return (from o in Program.context.Orders
                              where o.Emp_Id == empID && o.Type=="Sales"
                              select o).ToList();
            
        }
        //static double CountInvoicesAmount(int orderId,int empId)
        //{
        //    double totalAmount = 0;
        //    foreach (var item in EmpOrders(empId))
        //    {
        //        totalAmount += Program.context.Sales_Order.Where(os => os.Order_Id == item.Id).Select(os => os.TotalAmount).FirstOrDefault();
        //    }

        //    return totalAmount;   
        //}
        public static List<EmpReport> DisplayAll(DateTime startDate,DateTime endDate)
        {
            List<EmpReport> list = new List<EmpReport>();
           
            return null;
        }
        public static List<Emp_Invoices_Result> filter(Func<Emp_Invoices_Result,bool>del,DateTime startDate, DateTime endDate)
        {
            return Program.context.Emp_Invoices(startDate, endDate).ToList().Where(del).Select(x=>x).ToList();
        }
    }
}
