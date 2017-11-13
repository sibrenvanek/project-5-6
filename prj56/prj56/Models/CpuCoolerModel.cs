using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("CPUCooler")]
    public class CPUCooler
    {
        [Key]
        [Column("CPUCoolerId")]
        public int CPUCoolerId { get; set; }
        public string Brand { get; set; }
        public int FanConnections { get; set; }
        public string CoolingMethod { get; set; }
        public string Socket { get; set; }
        public int DiameterFan { get; set; }
        public int Min_RotationSpeed { get; set; }
        public int Max_RotationSpeed { get; set; }
        public float Min_SoundProduction { get; set; }
        public float Max_SoundProduction { get; set; }
        public int Heatpipes { get; set; }
        public float Weight { get; set; }
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