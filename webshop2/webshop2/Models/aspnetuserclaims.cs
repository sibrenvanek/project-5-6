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
    
    public partial class aspnetuserclaims
    {
        public int id { get; set; }
        public Nullable<int> userid { get; set; }
        public string Claimtype { get; set; }
        public string Claimvalue { get; set; }
    
        public virtual aspnetusers aspnetusers { get; set; }
    }
}