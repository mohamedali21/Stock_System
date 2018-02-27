using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.VM
{
    class SalesOrderVM
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Type { get; set; }
        public int NumOfProducts { get; set; }
        public double InvoiceAmount { get; set; }
        public Nullable<double> InvoiceDiscount { get; set; }
        public double TotalAmount { get; set; }
        public int Order_Id { get; set; }
        public string CName { get; set; }
    }
}
