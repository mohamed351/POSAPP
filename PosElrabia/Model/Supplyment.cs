//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PosElrabia.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplyment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplyment()
        {
            this.SupplymentDetails = new HashSet<SupplymentDetail>();
        }
    
        public int ID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int SupplierID { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplymentDetail> SupplymentDetails { get; set; }
    }
}