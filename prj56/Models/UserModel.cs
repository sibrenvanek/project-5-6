using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string Adress { get; set; }
        public string Username { get; set; }
        public string DateOfBirth { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }


    }
}