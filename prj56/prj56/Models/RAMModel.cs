using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("ram")]
    public class RAM
    {
        [Key]
        [Column("RAMId")]
        public int RAMId { get; set; }
        public string Brand { get; set; }
        public string CompositionOfMemory { get; set; }
        public string MemoryType { get; set; }
        public int Clockspeed { get; set; }
        public int CASlatency { get; set; }
        public float Voltage { get; set; }
        public int MemoryModuleConnection { get; set; }
        public string MemorySuitableFor { get; set; }

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