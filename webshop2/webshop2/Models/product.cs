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
        public int ProductId { get; set; }
        public string productname { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> count { get; set; }
    }
}
