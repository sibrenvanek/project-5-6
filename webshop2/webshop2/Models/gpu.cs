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
    
    public partial class gpu
    {
        public int GPUId { get; set; }
        public string Brand { get; set; }
        public string BusType { get; set; }
        public Nullable<int> FreeLocksReuired { get; set; }
        public Nullable<sbyte> LowProfile { get; set; }
        public string Resotlution { get; set; }
        public string Manufacturer { get; set; }
        public string TypeOfGPU { get; set; }
        public Nullable<int> Clockspeed { get; set; }
        public Nullable<int> Turbofrequency { get; set; }
        public Nullable<int> StreamProcessors { get; set; }
        public string CoolingMethod { get; set; }
        public Nullable<int> VideoMemory { get; set; }
        public string TypeOfMemory { get; set; }
        public Nullable<int> ClockspeedMemoryModule { get; set; }
        public Nullable<int> BandwithMemoryBus { get; set; }
        public Nullable<int> VGAport { get; set; }
        public Nullable<int> DVIOutputs { get; set; }
        public Nullable<int> HDMIOutputs { get; set; }
        public Nullable<int> DisplayPorts { get; set; }
        public Nullable<int> MaxPowerConsumption { get; set; }
        public Nullable<int> MinRequiredFeed { get; set; }
        public string PowerConnectors { get; set; }
        public Nullable<float> Directx { get; set; }
        public Nullable<float> OpenGL { get; set; }
        public Nullable<sbyte> AMDCrossfireX { get; set; }
        public Nullable<sbyte> NVIDEASLI { get; set; }
        public Nullable<sbyte> HDCP { get; set; }
        public Nullable<float> Width { get; set; }
        public Nullable<float> Depth { get; set; }
        public Nullable<float> Height { get; set; }
    }
}
