using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("gpu")]
    public class GPU
    {
        [Key]
        [Column("GPUId")]
        public int GPUId { get; set; }
        public string Brand { get; set; }
        public string BusType { get; set; }
        public int FreeLocksRequired { get; set; }
        public bool LowProfile { get; set; }
        public string Resolution { get; set; }
        public string Manufacturer { get; set; }
        public string TypeOfGPU { get; set; }
        public int Clockspeed { get; set; }
        public int TurboFrequency { get; set; }
        public int StreamProcessors { get; set; }
        public string CoolingMethod { get; set; }
        public int VideoMemory { get; set; }
        public string TypeOfMemory { get; set; }
        public int ClockSpeedMemoryModule { get; set; }
        public int BandwithMemoryBus { get; set; }
        public bool VGAPort { get; set; }
        public int DVIOutputs { get; set; }
        public int HDMIOutputs { get; set; }
        public int DisplayPorts { get; set; }
        public int MaxPowerConsumption { get; set; }
        public int MinRequiredFeed { get; set; }
        public string PowerConnectors { get; set; }
        public float DirectX { get; set; }
        public float OpenGL { get; set; }
        public bool AMDCrossfireX { get; set; }
        public bool NVIDEASLI { get; set; }
        public bool HDCP { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }
}