using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj56.Models
{

    [Table("chat")]
    public class Chat
    {
        [Key]
        [Column("KeyId")]
        public int KeyId { get; set; }

        //public User User1 { get; set; }

        //public User User2 { get; set; }
        public string content { get; set; }
        //[Key]
        //[Column("MessageId")]
        //public int MessageId { get; set; }

        public bool ChatStopped { get; set; } = false;


        public Chat()
        {
            //WriteChat();

        }
        public void WriteChat()
        {
            content = Console.ReadLine();

        }

    }
}