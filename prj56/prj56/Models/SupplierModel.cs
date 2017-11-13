using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [Column("SupplierId")]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }
        public int KvKNumber { get; set; }
        public string ShippingTime { get; set; }
        public string Email { get; set; }



    }
}