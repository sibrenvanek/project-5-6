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
            
            
            
            using (var db = new db_Entities()) //connects to database
            {

                db.Database.CreateIfNotExists(); //creates database if it doesnt exist (don't remove)
                                                 // db.Blogs.Add(new Blog { Name = "Another Blog " }); example for adding entries to database


                db.Cases.Add(
                    new Case
                    {
                        CaseId = 1,
                        Brand = "Brandtest",
                        ComputerHousing = "testHousing",
                        FormatMotherboard = "testformat",
                        USB2 = 500,
                        USB3 = 5000,
                        Bays35 = 654,
                        Bays25 = 687,
                        Bays525 = 64897,
                        ExtensionLocks = 354,
                        Max_Length_Videocard = 654,
                        Fanpositions = 54654,
                        FrontFan = 654,
                        RearSideFan = 6987,
                        SideFan = 1,
                        TopSideLock = 68468,
                        BottomSideLock = 68684,
                        FanSupplied = 68464,
                        MaximumAltitudeProcessor = 328,
                        LocationPowersupply = "very far",
                        PanelDoor = true,
                        NoiseReduction = false,
                        DustFilter = true,
                        FanController = true,
                        SoundProofingMats = false,
                        Weight = 500000,
                        Width = 6000,
                        Depth = 500123,
                        Height = 53465,
                        Color = "Rainbow",
                        Material = "Unicorn Horns"
                    });
                db.SaveChanges(); //saves changes to database (call right after new DB entry)

                foreach (var cas in db.Cases)
                {
                    Console.WriteLine(cas.Color + cas.Material + cas.CaseId);
                }

                foreach (var prod in db.Products) //example for printing out products
                {
                    Console.WriteLine(prod.id_product + " " + prod.productname);
                }
                foreach (var cust in db.Customers) //example for printing out customers
                {
                    Console.WriteLine("printing customer name here");
                    Console.WriteLine(cust.id_customer + " " + cust.customername + " " + cust.address);
                }
                
            }
            Console.ReadLine(); //discontinues the program so it doesnt exit
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
        public DbSet<Case> Cases { get; set; }//Migrated




        public DbSet<Customer> Customers { get; set; } //example
        public DbSet<Product2> Products { get; set; } //example
        public DbSet<Blog> Blogs { get; set; } //example
    }
    [Table("case")]
    public class Case //migrated Column for Cases
    {
        [Key]
        [Column("CaseId")]
        public int CaseId { get; set; }
        public string Brand { get; set; }
        public string ComputerHousing { get; set; }
        public string FormatMotherboard { get; set; }
        public int USB2 { get; set; }
        public int USB3 { get; set; }
        public int Bays35 { get; set; }
        public int Bays25 { get; set; }
        public int Bays525 { get; set; }
        public int ExtensionLocks { get; set; }
        public int Max_Length_Videocard { get; set; }
        public int Fanpositions { get; set; }
        public int FrontFan { get; set; }
        public int RearSideFan { get; set; }
        public int SideFan { get; set; }
        public int TopSideLock { get; set; }
        public int BottomSideLock { get; set; }
        public int FanSupplied { get; set; }
        public int MaximumAltitudeProcessor { get; set; }
        public string LocationPowersupply { get; set; }
        public bool PanelDoor { get; set; }
        public bool NoiseReduction { get; set; }
        public bool DustFilter { get; set; }
        public bool FanController { get; set; }
        public bool SoundProofingMats { get; set; }
        public float Weight { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
            
    }








    [Table("customer")] //customer table example
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
    public class Product2 //example
    {
        [Key]
        [Column("id_product")]
        public int id_product { get; set; }
        public string productname { get; set; }
    }

    public class Blog //example
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
    public class Post //example
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

}
