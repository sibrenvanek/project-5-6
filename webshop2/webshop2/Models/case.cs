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
    
    public partial class @case
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string ComputerHousing { get; set; }
        public string FormatMotherboard { get; set; }
        public Nullable<int> USB2 { get; set; }
        public Nullable<int> USB3 { get; set; }
        public Nullable<int> Bays35 { get; set; }
        public Nullable<int> Bays25 { get; set; }
        public Nullable<int> Bays525 { get; set; }
        public Nullable<int> ExtensionLocks { get; set; }
        public Nullable<int> Max_Length_Videocard { get; set; }
        public Nullable<int> fanpositions { get; set; }
        public Nullable<int> FrontFan { get; set; }
        public Nullable<int> RearSideFan { get; set; }
        public Nullable<int> SideFan { get; set; }
        public Nullable<int> TopSideLock { get; set; }
        public Nullable<int> FanSupplied { get; set; }
        public Nullable<int> MaximumAltitutdeOricessir { get; set; }
        public string LocationPowerSupply { get; set; }
        public string PanelDoor { get; set; }
        public string NoiseReduction { get; set; }
        public string DustFilter { get; set; }
        public string FanController { get; set; }
        public string SoundProofingMats { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Depth { get; set; }
        public Nullable<int> Height { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Name { get; set; }
    
        public virtual product product { get; set; }
    }
}
