using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            //using (var db = new db_Entities())
            //{
                
            //    foreach (var customer in db.Customer)
            //    {
            //        Console.WriteLine("customer name" + customer.customername);
            //        foreach (var cust in db.Customer.Where(a => customer.id == 1))
            //        {
            //            Console.WriteLine("Found customer with name" + customer.customername);
            //        }
            //    }
            //}

            using (var db = new db_Entities())
            {
                Customer c = new Customer
                {
                    id_customer = 2,
                    customername = "custname2",
                    nit = "whatsanit",
                    address = "9999tx"
                };

                
                //db.Customer.Add(c);
                //db.SaveChanges();

                Console.WriteLine("Connection established");

                var customers = db.Customer.ToList();
                foreach (var cust in customers)
                {
                    Console.WriteLine("printing customer name here");
                    Console.WriteLine(cust.id_customer + " " + cust.customername + " " + cust.address);
                    
                }

            }
            Console.ReadLine();
        }
    }
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("id_customer")]
        public int id_customer { get; set; }

        public string customername { get; set; }

        public string nit { get; set; }

        public string address { get; set; }
    }
    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "nametest") { }
        
        
        public DbSet<Customer> Customer { get; set; }
    }
}
