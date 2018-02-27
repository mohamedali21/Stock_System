using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.VM
{
    class PurchaseOrderVM
    {
        public int Id { get; set; }
        public int InvoiceNo { get; set; }
        public System.DateTime RecivedDate { get; set; }
        public System.DateTime IssuedDate { get; set; }
        public string Type { get; set; }
        public int NumOfProducts { get; set; }
        public int InvoiceAmount { get; set; }
        public int Order_Id { get; set; }
        public string S_Name { get; set; }
    }
}
