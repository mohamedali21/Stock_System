using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer.ViewModel
{
    class ReturnedInvoiceDetails
    {
        public int Product_Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
        
    }
}
