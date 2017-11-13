using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("power supply")]
    public class PowerSupply
    {
        [Key]
        [Column("PowerSupplyId")]
        public int PowerSupplyId { get; set; }
        public string Brand { get; set; }
        public string VersionFormFactor { get; set; }
        public bool Modular { get; set; }
        public float DiameterFan { get; set; }
        public int Power { get; set; }
        public string Certification { get; set; }
        public int AverageLifespawn { get; set; }
        public int ATX20 { get; set; }
        public int CPUP8 { get; set; }
        public int CPUP4 { get; set; }
        public int CPUP4P4 { get; set; }
        public int PCIExpress6pin { get; set; }
        public int PCIExpress6pin2pin { get; set; }
        public int IDE { get; set; }
        public int SATA { get; set; }
        public int FDD { get; set; }
        public bool Currentspikes { get; set; }
        public bool Overvoltage { get; set; }
        public bool SurgeProtection { get; set; }
        public bool UnderPressure { get; set; }
        public bool Overload { get; set; }
        public bool ShortCircuit { get; set; }
        public bool OverheatingProtection { get; set; }
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