using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("PurchaseHistory")]
    public class PurchaseHistory
    {
        [Key]
        [Column("DateOfPurchase")]
        public int DateOfPurchase { get; set; }


        [ForeignKey("User")] //FK user
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<User> Users { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}