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
using System.Xml.Serialization;
using System.Xml;
using ExcelDataReader;

namespace EFFY
{
    class Program
    {
        static List<string> ReadChat()
        {
            List<string> messages = new List<string>();
            int count=0;
            using(var db=new db_Entities())
            {
                var chat = db.Chats;
                int Count = chat.Count();
                if(Count != count)
                {
                    count = Count;
                    for (int i = 1; i <= Count; i++)
                    {
                        IQueryable<Chat> Chat = chat.Where(m => m.KeyId == i);
                        var message = Chat.First().content;
                        messages.Add(message);
                    }
                }
            }

            return messages;
        }
        static void Main(string[] args)
        {
            List<string> messages=new List<string>();
            bool test = true;
            bool first = true;
            while (test)
            {
                int messagecount = messages.Count();
                messages = ReadChat();
                if(first)
                {
                    first = false;
                    foreach (string message in messages)
                    {
                        Console.WriteLine(message);
                    }
                }
                else if (messages.Count != messagecount)
                {
                    Console.Clear();
                    foreach (string message in messages)
                    {
                        Console.WriteLine(message);
                    }
                }
            }
           
            /*
            using (var db = new db_Entities()) //connects to database
            {

                db.Database.CreateIfNotExists(); //creates database if it doesnt exist (don't remove)
                                                 // db.Blogs.Add(new Blog { Name = "Another Blog " }); example for adding entries to database



                
                db.Chats.Add(
                    new Chat
                    {
                        KeyId = 1
                        

                    }
                );


                //bool ChatStopped = false;
                //while(ChatStopped==false)
                //{
                //    foreach (var chatline in db.Chats)
                //    {
                //        Console.WriteLine(chatline.content);
                //    }
                //}

                Console.WriteLine("adding");

                db.SaveChanges(); //saves changes to database (call right after new DB entry)
                Console.WriteLine("added");


            }*/
            Console.ReadLine(); //discontinues the program so it doesnt exit
        }
    }

    public partial class db_Entities : DbContext, IDisposable //db context
    {
        public db_Entities() : base(nameOrConnectionString: "nametest") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Customer>().MapToStoredProcedures();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Case> Cases { get; set; }//Migrated
        public DbSet<CPUCooler> CpuCoolers { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<InternalHDD> HDDs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<SSD> SSDs { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; } //<- not yet migrated , FK
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Chat> Chats { get; set; }
        



        
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

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

    [Table("CPUCooler")]
    public class CPUCooler
    {
        [Key]
        [Column("CPUCoolerId")]
        public int CPUCoolerId { get; set; }
        public string Brand { get; set; }
        public int FanConnections { get; set; }
        public string CoolingMethod { get; set; }
        public string Socket { get; set; }
        public int DiameterFan { get; set; }
        public int Min_RotationSpeed { get; set; }
        public int Max_RotationSpeed { get; set; }
        public float Min_SoundProduction { get; set; }
        public float Max_SoundProduction { get; set; }
        public int Heatpipes { get; set; }
        public float Weight { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

    [Table("gpu")]
    public class GPU
    {
        [Key]
        [Column("GPUId")]
        public int GPUId { get; set; }
        public string Brand { get; set; }
        public string BusType { get; set; }
        public int FreeLocksRequired { get; set; }
        public bool LowProfile { get; set; }
        public string Resolution { get; set; }
        public string Manufacturer { get; set; }
        public string TypeOfGPU { get; set; }
        public int Clockspeed { get; set; }
        public int TurboFrequency { get; set; }
        public int StreamProcessors { get; set; }
        public string CoolingMethod { get; set; }
        public int VideoMemory { get; set; }
        public string TypeOfMemory { get; set; }
        public int ClockSpeedMemoryModule { get; set; }
        public int BandwithMemoryBus { get; set; }
        public bool VGAPort { get; set; }
        public int DVIOutputs { get; set; }
        public int HDMIOutputs { get; set; }
        public int DisplayPorts { get; set; }
        public int MaxPowerConsumption { get; set; }
        public int MinRequiredFeed { get; set; }
        public string PowerConnectors { get; set; }
        public float DirectX { get; set; }
        public float OpenGL { get; set; }
        public bool AMDCrossfireX { get; set; }
        public bool NVIDEASLI { get; set; }
        public bool HDCP { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

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

    [Table("motherboard")]
    public class Motherboard
    {
        [Key]
        [Column("MotherboardId")]
        public int MotherboardId { get; set; }
        public string Brand { get; set; }
        public string FormatMotherboard { get; set; }
        public int Socket { get; set; }
        public string Chipset { get; set; }
        public int ClockSpeedMemoryModule { get; set; }
        public int Max_AmountOfMemory { get; set; }
        public int MemoryLockedTotal { get; set; }
        public string Memory { get; set; }
        public int PCIx16 { get; set; }
        public int PCIx8 { get; set; }
        public int PCIx4 { get; set; }
        public int PCIx2 { get; set; }
        public int PCILocks { get; set; }
        public int PICMini { get; set; }
        public int EthernetPorts { get; set; }
        public bool BuiltInWiFi { get; set; }
        public bool Bluetooth { get; set; }
        public bool FireWire { get; set; }
        public int USB2Ports { get; set; }
        public int USB3Ports { get; set; }
        public bool Thunderbolt { get; set; }
        public bool PS2 { get; set; }
        public int SATA300 { get; set; }
        public int SATA600 { get; set; }
        public int mSATA { get; set; }
        public int M2Connections { get; set; }
        public string RAID { get; set; }
        public int SpeakerChannels { get; set; }
        public bool OpticalConnection { get; set; }
        public string AudioProcessor { get; set; }
        public bool VGAPort { get; set; }
        public bool DVIPort { get; set; }
        public bool HDMIPort { get; set; }
        public bool DisplayPort { get; set; }
        public string Chipsetcooler { get; set; }
        public int CasefanConnections { get; set; }
        public bool UEFIBIOS { get; set; }
        public bool NVIDEASLI { get; set; }
        public bool CrossfireX { get; set; }
        public bool KillerNIC { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

    [Table("power supply")]
    public class PowerSupply
    {
        [Key]
        [Column("PowerSupplyId")]
        public int PowerSupplyId { get; set; }
        public string Brand { get; set; }
        public string VersionFormFactor { get; set; }
        public bool Modular { get; set; }
        public float DiameterFan { get; set; }
        public int Power { get; set; }
        public string Certification { get; set; }
        public int AverageLifespawn { get; set; }
        public int ATX20 { get; set; }
        public int CPUP8 { get; set; }
        public int CPUP4 { get; set; }
        public int CPUP4P4 { get; set; }
        public int PCIExpress6pin { get; set; }
        public int PCIExpress6pin2pin { get; set; }
        public int IDE { get; set; }
        public int SATA { get; set; }
        public int FDD { get; set; }
        public bool Currentspikes { get; set; }
        public bool Overvoltage { get; set; }
        public bool SurgeProtection { get; set; }
        public bool UnderPressure { get; set; }
        public bool Overload { get; set; }
        public bool ShortCircuit { get; set; }
        public bool OverheatingProtection { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }
    }

    [Table("ram")]
    public class RAM
    {
        [Key]
        [Column("RAMId")]
        public int RAMId { get; set; }
        public string Brand { get; set; }
        public string CompositionOfMemory { get; set; }
        public string MemoryType { get; set; }
        public int Clockspeed { get; set; }
        public int CASlatency { get; set; }
        public float Voltage { get; set; }
        public int MemoryModuleConnection { get; set; }
        public string MemorySuitableFor { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

    [Table("SSD")]
    public class SSD
    {
        [Key]
        [Column("SSDId")]
        public int SSDId { get; set; }
        public string Brand { get; set; }
        public string Connection { get; set; }
        public int StorageCapacity { get; set; }
        public int AverageTimeBetweenFailures { get; set; }
        public string TypeOfMemory { get; set; }
        public string SSDController { get; set; }
        public float HardDiskFormat { get; set; }
        public int Max_ReadingSpeed { get; set; }
        public int Min_ReadingSpeed { get; set; }
        public int Random_ReadingSpeed { get; set; }
        public int Random_WriteSpeed { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("Supplier")] //FK supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<User> Suppliers { get; set; }

    }

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

    [Table("Wishlist")] 
    public class Wishlist
    {
        [Key]
        [Column("WishlistId")]
        public int WishlistId { get; set; }
        public int Quantity { get; set; }


        [ForeignKey("User")] //FK user
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<User> Users { get; set; }

        [ForeignKey("Product")] //Foreign key 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

        
    }

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
