using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("Itnernal hard disk")]
    public class InternalHDD
    {
        [Key]
        [Column("Internal HDD")]
        public int InternalHDDId { get; set; }
        public string Brand { get; set; }
        public string StorageType { get; set; }
        public int HDDSpeed { get; set; }
        public int Cache { get; set; }
        public float HDDFormat { get; set; }
        public float Height { get; set; }
        public string internalHDDDiskcol { get; set; }

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