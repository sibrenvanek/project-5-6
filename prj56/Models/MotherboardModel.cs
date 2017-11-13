using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("motherboard")]
    public class Motherboard
    {
        [Key]
        [Column("MotherboardId")]
        public int MotherboardId { get; set; }
        public string Brand { get; set; }
        public string FormatMotherboard { get; set; }
        public int Socket { get; set; }
        public string Chipset { get; set; }
        public int ClockSpeedMemoryModule { get; set; }
        public int Max_AmountOfMemory { get; set; }
        public int MemoryLockedTotal { get; set; }
        public string Memory { get; set; }
        public int PCIx16 { get; set; }
        public int PCIx8 { get; set; }
        public int PCIx4 { get; set; }
        public int PCIx2 { get; set; }
        public int PCILocks { get; set; }
        public int PICMini { get; set; }
        public int EthernetPorts { get; set; }
        public bool BuiltInWiFi { get; set; }
        public bool Bluetooth { get; set; }
        public bool FireWire { get; set; }
        public int USB2Ports { get; set; }
        public int USB3Ports { get; set; }
        public bool Thunderbolt { get; set; }
        public bool PS2 { get; set; }
        public int SATA300 { get; set; }
        public int SATA600 { get; set; }
        public int mSATA { get; set; }
        public int M2Connections { get; set; }
        public string RAID { get; set; }
        public int SpeakerChannels { get; set; }
        public bool OpticalConnection { get; set; }
        public string AudioProcessor { get; set; }
        public bool VGAPort { get; set; }
        public bool DVIPort { get; set; }
        public bool HDMIPort { get; set; }
        public bool DisplayPort { get; set; }
        public string Chipsetcooler { get; set; }
        public int CasefanConnections { get; set; }
        public bool UEFIBIOS { get; set; }
        public bool NVIDEASLI { get; set; }
        public bool CrossfireX { get; set; }
        public bool KillerNIC { get; set; }
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