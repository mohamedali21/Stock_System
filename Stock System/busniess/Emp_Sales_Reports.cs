using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.busniess
{
    class Emp_Sales_Reports
    {
        public DateTime InvoiceDate { get; set; }
        public double Sales_Total_Amount { get; set; }
        public Nullable<int> Invoice_Quantity { get; set; }
        public Nullable<int> Returned_Quantity { get; set; }
        public Nullable<double> Returned_Total_Price { get; set; }
        public string AmountOfSales { get; set; }

    }
}
