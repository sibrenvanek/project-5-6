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
    
    public partial class ram
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string CompositionOfMemory { get; set; }
        public string MemoryType { get; set; }
        public Nullable<int> Clockspeed { get; set; }
        public Nullable<int> CASlatency { get; set; }
        public Nullable<float> Voltage { get; set; }
        public Nullable<int> MemoryModuleConnection { get; set; }
        public string MemorySuitableFor { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Ramsize { get; set; }
        public Nullable<int> minprice { get; set; }
        public Nullable<int> maxprice { get; set; }
        public Nullable<int> minsize { get; set; }
        public Nullable<int> maxsize { get; set; }
        public string ramtype { get; set; }
        public string brand { get; set; }
    
        public virtual product product { get; set; }
    }
}
