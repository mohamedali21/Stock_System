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
    
    public partial class Purchase_Returned_Cheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase_Returned_Cheque()
        {
            this.Purchase_Returned_Cheque_Details = new HashSet<Purchase_Returned_Cheque_Details>();
        }
    
        public int Id { get; set; }
        public int NumOfPriducts { get; set; }
        public System.DateTime Date { get; set; }
        public int Purchase_Id { get; set; }
    
        public virtual Purchase_Order Purchase_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Returned_Cheque_Details> Purchase_Returned_Cheque_Details { get; set; }
    }
}
