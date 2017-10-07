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

                //foreach (var prod in db.Products) //example for printing out products
                //{
                //    Console.WriteLine(prod.id_product + " " + prod.productname);
                //}
                //foreach (var cust in db.Customers) //example for printing out customers
                //{
                //    Console.WriteLine("printing customer name here");
                //    Console.WriteLine(cust.id_customer + " " + cust.customername + " " + cust.address);
                //}
                
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
        public DbSet<CPUCooler>CpuCoolers { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<InternalHDD> HDDs { get; set; }
        public DbSet<Motherboard>Motherboards { get; set; }



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
    }

    [Table("Inernal hard disk")]
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

    }
    

}
