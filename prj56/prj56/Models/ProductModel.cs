using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("Product")]  //add foreign keys to all other tables
    public class Product
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string SubCategory { get; set; }
        public string ShippingTime { get; set; }

        [ForeignKey("Supplier")] //FK user
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }


    }
}