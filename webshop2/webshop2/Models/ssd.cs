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
    
    public partial class ssd
    {
        public int SSDId { get; set; }
        public string Brand { get; set; }
        public string Connection { get; set; }
        public Nullable<int> StorageCapacity { get; set; }
        public Nullable<int> AverageTimeBetweenFailures { get; set; }
        public string TypeOfMemory { get; set; }
        public string SSDController { get; set; }
        public Nullable<float> HardDiskFormat { get; set; }
        public Nullable<int> Max_ReadSpeed { get; set; }
        public Nullable<int> Min_ReadingSpeed { get; set; }
        public Nullable<int> Random_ReadingSpeed { get; set; }
        public Nullable<int> Random_WriteSpeed { get; set; }
        public Nullable<float> Width { get; set; }
        public Nullable<float> Depth { get; set; }
        public Nullable<float> Height { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
    }
}
