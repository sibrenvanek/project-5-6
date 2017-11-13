using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("case")]
    public class Case //migrated Column for Cases
    {
        [Key]
        [Column("CaseId")]
        public int CaseId { get; set; }
        public string Brand { get; set; }
        public string ComputerHousing { get; set; }
        public string FormatMotherboard { get; set; }
        public int USB2 { get; set; }
        public int USB3 { get; set; }
        public int Bays35 { get; set; }
        public int Bays25 { get; set; }
        public int Bays525 { get; set; }
        public int ExtensionLocks { get; set; }
        public int Max_Length_Videocard { get; set; }
        public int Fanpositions { get; set; }
        public int FrontFan { get; set; }
        public int RearSideFan { get; set; }
        public int SideFan { get; set; }
        public int TopSideLock { get; set; }
        public int BottomSideLock { get; set; }
        public int FanSupplied { get; set; }
        public int MaximumAltitudeProcessor { get; set; }
        public string LocationPowersupply { get; set; }
        public bool PanelDoor { get; set; }
        public bool NoiseReduction { get; set; }
        public bool DustFilter { get; set; }
        public bool FanController { get; set; }
        public bool SoundProofingMats { get; set; }
        public float Weight { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }

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