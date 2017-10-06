using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using MySql.Data.Entity;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace EFFY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var c = new Customer
            {
                id_customer=1,
                customername = "custname3",
                nit = "whatsanit2",
                address = "9999tx2"
            };
            var p = new Product2
            {
                id_product = 1,
                productname = "producttestname1"
            };
            
            using (var db = new db_Entities())
            {

                db.Database.CreateIfNotExists();


                db.Products.Add(p);
                foreach(var prod in db.Products)
                {
                    Console.WriteLine(prod.id_product + " " + prod.productname);
                }

                
                db.Customers.Add(c);
                var Customers = db.Customers.ToList();
                foreach (var cust in Customers)
                {
                    Console.WriteLine("printing customer name here");
                    Console.WriteLine(cust.id_customer + " " + cust.customername + " " + cust.address);
                    
                }


                db.Blogs.Add(new Blog { Name = "Another Blog " });
                db.SaveChanges();

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }

            }
            Console.ReadLine();
        }
    }
    
    public partial class db_Entities : DbContext,IDisposable //db context
    {
        public db_Entities() : base(nameOrConnectionString: "nametest") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Customer>().MapToStoredProcedures();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product2> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }


    [Table("customer")] //customer table
    public class Customer
    {
        [Key]
        [Column("id_customer")]
        public int id_customer { get; set; }

        public string customername { get; set; }

        public string nit { get; set; }

        public string address { get; set; }
    }
    [Table("product2")]
    public class Product2
    {
        [Key]
        [Column("id_product")]
        public int id_product { get; set; }
        public string productname { get; set; }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

}
