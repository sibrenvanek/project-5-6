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
    
    public partial class powersupply
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string VersionFormFactor { get; set; }
        public Nullable<sbyte> Modular { get; set; }
        public Nullable<float> DiameterFan { get; set; }
        public Nullable<int> Power { get; set; }
        public string Certification { get; set; }
        public Nullable<int> AverageLifespan { get; set; }
        public Nullable<float> Width { get; set; }
        public Nullable<float> Depth { get; set; }
        public Nullable<float> Height { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Name { get; set; }
    
        public virtual product product { get; set; }
    }
}
