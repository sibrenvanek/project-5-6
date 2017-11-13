using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("SSD")]
    public class SSD
    {
        [Key]
        [Column("SSDId")]
        public int SSDId { get; set; }
        public string Brand { get; set; }
        public string Connection { get; set; }
        public int StorageCapacity { get; set; }
        public int AverageTimeBetweenFailures { get; set; }
        public string TypeOfMemory { get; set; }
        public string SSDController { get; set; }
        public float HardDiskFormat { get; set; }
        public int Max_ReadingSpeed { get; set; }
        public int Min_ReadingSpeed { get; set; }
        public int Random_ReadingSpeed { get; set; }
        public int Random_WriteSpeed { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }

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