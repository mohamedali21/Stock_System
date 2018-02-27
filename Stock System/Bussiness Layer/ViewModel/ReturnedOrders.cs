using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer.ViewModel
{
    class ReturnedOrders
    {
        public int Id { get; set; }
        public int InvoiceID { get; set; }
        public int NumOfProducts { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double TotalAmount { get; set; }
    }
}
