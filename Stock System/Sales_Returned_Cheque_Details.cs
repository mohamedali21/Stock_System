//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales_Returned_Cheque_Details
    {
        public int Product_Id { get; set; }
        public int Sales_Returned_Cheque_Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sales_Returned_Cheque Sales_Returned_Cheque { get; set; }
    }
}
