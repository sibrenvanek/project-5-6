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
        public int RAMId { get; set; }
        public string Brand { get; set; }
        public string CompositionOfMemory { get; set; }
        public string MemoryType { get; set; }
        public Nullable<int> Clockspeed { get; set; }
        public Nullable<int> CASlatency { get; set; }
        public Nullable<float> Voltage { get; set; }
        public Nullable<int> MemoryModuleCOnnection { get; set; }
        public string MemorySuitableFor { get; set; }
        public string ImagePath { get; set; }
    }
}