//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshop2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.shoppingcart = new HashSet<shoppingcart>();
            this.wishlist = new HashSet<wishlist>();
            this.purchasehistory = new HashSet<purchasehistory>();
        }
    
        public int ID { get; set; }
        public Nullable<decimal> price { get; set; }
        public string imagepath { get; set; }
        public Nullable<int> stock { get; set; }
        public string Brand { get; set; }
        public string Supplier { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> PurchasedQuantity { get; set; }
    
        public virtual @case @case { get; set; }
        public virtual cpucooler cpucooler { get; set; }
        public virtual gpu gpu { get; set; }
        public virtual internalharddisk internalharddisk { get; set; }
        public virtual motherboard motherboard { get; set; }
        public virtual powersupply powersupply { get; set; }
        public virtual ram ram { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shoppingcart> shoppingcart { get; set; }
        public virtual ssd ssd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wishlist> wishlist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchasehistory> purchasehistory { get; set; }
    }
}
