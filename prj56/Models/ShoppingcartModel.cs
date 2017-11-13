using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        [Column("ShippingCartId")]
        public int ShippingCardId { get; set; }
        public int Amount { get; set; }


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