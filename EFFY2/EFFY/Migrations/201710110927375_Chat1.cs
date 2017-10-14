namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chat1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.case",
                c => new
                    {
                        CaseId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        ComputerHousing = c.String(unicode: false),
                        FormatMotherboard = c.String(unicode: false),
                        USB2 = c.Int(nullable: false),
                        USB3 = c.Int(nullable: false),
                        Bays35 = c.Int(nullable: false),
                        Bays25 = c.Int(nullable: false),
                        Bays525 = c.Int(nullable: false),
                        ExtensionLocks = c.Int(nullable: false),
                        Max_Length_Videocard = c.Int(nullable: false),
                        Fanpositions = c.Int(nullable: false),
                        FrontFan = c.Int(nullable: false),
                        RearSideFan = c.Int(nullable: false),
                        SideFan = c.Int(nullable: false),
                        TopSideLock = c.Int(nullable: false),
                        BottomSideLock = c.Int(nullable: false),
                        FanSupplied = c.Int(nullable: false),
                        MaximumAltitudeProcessor = c.Int(nullable: false),
                        LocationPowersupply = c.String(unicode: false),
                        PanelDoor = c.Boolean(nullable: false),
                        NoiseReduction = c.Boolean(nullable: false),
                        DustFilter = c.Boolean(nullable: false),
                        FanController = c.Boolean(nullable: false),
                        SoundProofingMats = c.Boolean(nullable: false),
                        Weight = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        Color = c.String(unicode: false),
                        Material = c.String(unicode: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CaseId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Stock = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Name = c.String(unicode: false),
                        Category = c.Int(nullable: false),
                        SubCategory = c.String(unicode: false),
                        ShippingTime = c.String(unicode: false),
                        SupplierId = c.Int(nullable: false),
                        Case_CaseId = c.Int(),
                        CPUCooler_CPUCoolerId = c.Int(),
                        GPU_GPUId = c.Int(),
                        InternalHDD_InternalHDDId = c.Int(),
                        Motherboard_MotherboardId = c.Int(),
                        PowerSupply_PowerSupplyId = c.Int(),
                        RAM_RAMId = c.Int(),
                        SSD_SSDId = c.Int(),
                        Wishlist_WishlistId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.case", t => t.Case_CaseId)
                .ForeignKey("dbo.CPUCooler", t => t.CPUCooler_CPUCoolerId)
                .ForeignKey("dbo.gpu", t => t.GPU_GPUId)
                .ForeignKey("dbo.Itnernal hard disk", t => t.InternalHDD_InternalHDDId)
                .ForeignKey("dbo.motherboard", t => t.Motherboard_MotherboardId)
                .ForeignKey("dbo.power supply", t => t.PowerSupply_PowerSupplyId)
                .ForeignKey("dbo.ram", t => t.RAM_RAMId)
                .ForeignKey("dbo.SSD", t => t.SSD_SSDId)
                .ForeignKey("dbo.Wishlist", t => t.Wishlist_WishlistId)
                .Index(t => t.SupplierId)
                .Index(t => t.Case_CaseId)
                .Index(t => t.CPUCooler_CPUCoolerId)
                .Index(t => t.GPU_GPUId)
                .Index(t => t.InternalHDD_InternalHDDId)
                .Index(t => t.Motherboard_MotherboardId)
                .Index(t => t.PowerSupply_PowerSupplyId)
                .Index(t => t.RAM_RAMId)
                .Index(t => t.SSD_SSDId)
                .Index(t => t.Wishlist_WishlistId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        City = c.String(unicode: false),
                        Street = c.String(unicode: false),
                        Housenumber = c.String(unicode: false),
                        KvKNumber = c.Int(nullable: false),
                        ShippingTime = c.String(unicode: false),
                        Email = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Adress = c.String(unicode: false),
                        Username = c.String(unicode: false),
                        DateOfBirth = c.String(unicode: false),
                        UserType = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Product_ProductId = c.Int(),
                        Case_CaseId = c.Int(),
                        CPUCooler_CPUCoolerId = c.Int(),
                        GPU_GPUId = c.Int(),
                        InternalHDD_InternalHDDId = c.Int(),
                        Motherboard_MotherboardId = c.Int(),
                        PowerSupply_PowerSupplyId = c.Int(),
                        RAM_RAMId = c.Int(),
                        SSD_SSDId = c.Int(),
                        Wishlist_WishlistId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Product", t => t.Product_ProductId)
                .ForeignKey("dbo.case", t => t.Case_CaseId)
                .ForeignKey("dbo.CPUCooler", t => t.CPUCooler_CPUCoolerId)
                .ForeignKey("dbo.gpu", t => t.GPU_GPUId)
                .ForeignKey("dbo.Itnernal hard disk", t => t.InternalHDD_InternalHDDId)
                .ForeignKey("dbo.motherboard", t => t.Motherboard_MotherboardId)
                .ForeignKey("dbo.power supply", t => t.PowerSupply_PowerSupplyId)
                .ForeignKey("dbo.ram", t => t.RAM_RAMId)
                .ForeignKey("dbo.SSD", t => t.SSD_SSDId)
                .ForeignKey("dbo.Wishlist", t => t.Wishlist_WishlistId)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Case_CaseId)
                .Index(t => t.CPUCooler_CPUCoolerId)
                .Index(t => t.GPU_GPUId)
                .Index(t => t.InternalHDD_InternalHDDId)
                .Index(t => t.Motherboard_MotherboardId)
                .Index(t => t.PowerSupply_PowerSupplyId)
                .Index(t => t.RAM_RAMId)
                .Index(t => t.SSD_SSDId)
                .Index(t => t.Wishlist_WishlistId);
            
            CreateTable(
                "dbo.chat",
                c => new
                    {
                        KeyId = c.Int(nullable: false, identity: true),
                        content = c.String(unicode: false),
                        ChatStopped = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KeyId);
            
            CreateTable(
                "dbo.CPUCooler",
                c => new
                    {
                        CPUCoolerId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        FanConnections = c.Int(nullable: false),
                        CoolingMethod = c.String(unicode: false),
                        Socket = c.String(unicode: false),
                        DiameterFan = c.Int(nullable: false),
                        Min_RotationSpeed = c.Int(nullable: false),
                        Max_RotationSpeed = c.Int(nullable: false),
                        Min_SoundProduction = c.Single(nullable: false),
                        Max_SoundProduction = c.Single(nullable: false),
                        Heatpipes = c.Int(nullable: false),
                        Weight = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CPUCoolerId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.gpu",
                c => new
                    {
                        GPUId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        BusType = c.String(unicode: false),
                        FreeLocksRequired = c.Int(nullable: false),
                        LowProfile = c.Boolean(nullable: false),
                        Resolution = c.String(unicode: false),
                        Manufacturer = c.String(unicode: false),
                        TypeOfGPU = c.String(unicode: false),
                        Clockspeed = c.Int(nullable: false),
                        TurboFrequency = c.Int(nullable: false),
                        StreamProcessors = c.Int(nullable: false),
                        CoolingMethod = c.String(unicode: false),
                        VideoMemory = c.Int(nullable: false),
                        TypeOfMemory = c.String(unicode: false),
                        ClockSpeedMemoryModule = c.Int(nullable: false),
                        BandwithMemoryBus = c.Int(nullable: false),
                        VGAPort = c.Boolean(nullable: false),
                        DVIOutputs = c.Int(nullable: false),
                        HDMIOutputs = c.Int(nullable: false),
                        DisplayPorts = c.Int(nullable: false),
                        MaxPowerConsumption = c.Int(nullable: false),
                        MinRequiredFeed = c.Int(nullable: false),
                        PowerConnectors = c.String(unicode: false),
                        DirectX = c.Single(nullable: false),
                        OpenGL = c.Single(nullable: false),
                        AMDCrossfireX = c.Boolean(nullable: false),
                        NVIDEASLI = c.Boolean(nullable: false),
                        HDCP = c.Boolean(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GPUId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Itnernal hard disk",
                c => new
                    {
                        InternalHDD = c.Int(name: "Internal HDD", nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        StorageType = c.String(unicode: false),
                        HDDSpeed = c.Int(nullable: false),
                        Cache = c.Int(nullable: false),
                        HDDFormat = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        internalHDDDiskcol = c.String(unicode: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InternalHDD)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.motherboard",
                c => new
                    {
                        MotherboardId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        FormatMotherboard = c.String(unicode: false),
                        Socket = c.Int(nullable: false),
                        Chipset = c.String(unicode: false),
                        ClockSpeedMemoryModule = c.Int(nullable: false),
                        Max_AmountOfMemory = c.Int(nullable: false),
                        MemoryLockedTotal = c.Int(nullable: false),
                        Memory = c.String(unicode: false),
                        PCIx16 = c.Int(nullable: false),
                        PCIx8 = c.Int(nullable: false),
                        PCIx4 = c.Int(nullable: false),
                        PCIx2 = c.Int(nullable: false),
                        PCILocks = c.Int(nullable: false),
                        PICMini = c.Int(nullable: false),
                        EthernetPorts = c.Int(nullable: false),
                        BuiltInWiFi = c.Boolean(nullable: false),
                        Bluetooth = c.Boolean(nullable: false),
                        FireWire = c.Boolean(nullable: false),
                        USB2Ports = c.Int(nullable: false),
                        USB3Ports = c.Int(nullable: false),
                        Thunderbolt = c.Boolean(nullable: false),
                        PS2 = c.Boolean(nullable: false),
                        SATA300 = c.Int(nullable: false),
                        SATA600 = c.Int(nullable: false),
                        mSATA = c.Int(nullable: false),
                        M2Connections = c.Int(nullable: false),
                        RAID = c.String(unicode: false),
                        SpeakerChannels = c.Int(nullable: false),
                        OpticalConnection = c.Boolean(nullable: false),
                        AudioProcessor = c.String(unicode: false),
                        VGAPort = c.Boolean(nullable: false),
                        DVIPort = c.Boolean(nullable: false),
                        HDMIPort = c.Boolean(nullable: false),
                        DisplayPort = c.Boolean(nullable: false),
                        Chipsetcooler = c.String(unicode: false),
                        CasefanConnections = c.Int(nullable: false),
                        UEFIBIOS = c.Boolean(nullable: false),
                        NVIDEASLI = c.Boolean(nullable: false),
                        CrossfireX = c.Boolean(nullable: false),
                        KillerNIC = c.Boolean(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MotherboardId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.power supply",
                c => new
                    {
                        PowerSupplyId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        VersionFormFactor = c.String(unicode: false),
                        Modular = c.Boolean(nullable: false),
                        DiameterFan = c.Single(nullable: false),
                        Power = c.Int(nullable: false),
                        Certification = c.String(unicode: false),
                        AverageLifespawn = c.Int(nullable: false),
                        ATX20 = c.Int(nullable: false),
                        CPUP8 = c.Int(nullable: false),
                        CPUP4 = c.Int(nullable: false),
                        CPUP4P4 = c.Int(nullable: false),
                        PCIExpress6pin = c.Int(nullable: false),
                        PCIExpress6pin2pin = c.Int(nullable: false),
                        IDE = c.Int(nullable: false),
                        SATA = c.Int(nullable: false),
                        FDD = c.Int(nullable: false),
                        Currentspikes = c.Boolean(nullable: false),
                        Overvoltage = c.Boolean(nullable: false),
                        SurgeProtection = c.Boolean(nullable: false),
                        UnderPressure = c.Boolean(nullable: false),
                        Overload = c.Boolean(nullable: false),
                        ShortCircuit = c.Boolean(nullable: false),
                        OverheatingProtection = c.Boolean(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PowerSupplyId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ram",
                c => new
                    {
                        RAMId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        CompositionOfMemory = c.String(unicode: false),
                        MemoryType = c.String(unicode: false),
                        Clockspeed = c.Int(nullable: false),
                        CASlatency = c.Int(nullable: false),
                        Voltage = c.Single(nullable: false),
                        MemoryModuleConnection = c.Int(nullable: false),
                        MemorySuitableFor = c.String(unicode: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RAMId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.SSD",
                c => new
                    {
                        SSDId = c.Int(nullable: false, identity: true),
                        Brand = c.String(unicode: false),
                        Connection = c.String(unicode: false),
                        StorageCapacity = c.Int(nullable: false),
                        AverageTimeBetweenFailures = c.Int(nullable: false),
                        TypeOfMemory = c.String(unicode: false),
                        SSDController = c.String(unicode: false),
                        HardDiskFormat = c.Single(nullable: false),
                        Max_ReadingSpeed = c.Int(nullable: false),
                        Min_ReadingSpeed = c.Int(nullable: false),
                        Random_ReadingSpeed = c.Int(nullable: false),
                        Random_WriteSpeed = c.Int(nullable: false),
                        Width = c.Single(nullable: false),
                        Depth = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        Color = c.String(unicode: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SSDId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Wishlist",
                c => new
                    {
                        WishlistId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WishlistId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.user", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.user", "Wishlist_WishlistId", "dbo.Wishlist");
            DropForeignKey("dbo.Wishlist", "UserId", "dbo.user");
            DropForeignKey("dbo.Product", "Wishlist_WishlistId", "dbo.Wishlist");
            DropForeignKey("dbo.Wishlist", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "SSD_SSDId", "dbo.SSD");
            DropForeignKey("dbo.SSD", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "SSD_SSDId", "dbo.SSD");
            DropForeignKey("dbo.SSD", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "RAM_RAMId", "dbo.ram");
            DropForeignKey("dbo.ram", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "RAM_RAMId", "dbo.ram");
            DropForeignKey("dbo.ram", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "PowerSupply_PowerSupplyId", "dbo.power supply");
            DropForeignKey("dbo.power supply", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "PowerSupply_PowerSupplyId", "dbo.power supply");
            DropForeignKey("dbo.power supply", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "Motherboard_MotherboardId", "dbo.motherboard");
            DropForeignKey("dbo.motherboard", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "Motherboard_MotherboardId", "dbo.motherboard");
            DropForeignKey("dbo.motherboard", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "InternalHDD_InternalHDDId", "dbo.Itnernal hard disk");
            DropForeignKey("dbo.Itnernal hard disk", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "InternalHDD_InternalHDDId", "dbo.Itnernal hard disk");
            DropForeignKey("dbo.Itnernal hard disk", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "GPU_GPUId", "dbo.gpu");
            DropForeignKey("dbo.gpu", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "GPU_GPUId", "dbo.gpu");
            DropForeignKey("dbo.gpu", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "CPUCooler_CPUCoolerId", "dbo.CPUCooler");
            DropForeignKey("dbo.CPUCooler", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "CPUCooler_CPUCoolerId", "dbo.CPUCooler");
            DropForeignKey("dbo.CPUCooler", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "Case_CaseId", "dbo.case");
            DropForeignKey("dbo.case", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Product", "Case_CaseId", "dbo.case");
            DropForeignKey("dbo.case", "ProductId", "dbo.Product");
            DropForeignKey("dbo.user", "Product_ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "SupplierId", "dbo.Supplier");
            DropIndex("dbo.Wishlist", new[] { "ProductId" });
            DropIndex("dbo.Wishlist", new[] { "UserId" });
            DropIndex("dbo.SSD", new[] { "SupplierId" });
            DropIndex("dbo.SSD", new[] { "ProductId" });
            DropIndex("dbo.ram", new[] { "SupplierId" });
            DropIndex("dbo.ram", new[] { "ProductId" });
            DropIndex("dbo.power supply", new[] { "SupplierId" });
            DropIndex("dbo.power supply", new[] { "ProductId" });
            DropIndex("dbo.motherboard", new[] { "SupplierId" });
            DropIndex("dbo.motherboard", new[] { "ProductId" });
            DropIndex("dbo.Itnernal hard disk", new[] { "SupplierId" });
            DropIndex("dbo.Itnernal hard disk", new[] { "ProductId" });
            DropIndex("dbo.gpu", new[] { "SupplierId" });
            DropIndex("dbo.gpu", new[] { "ProductId" });
            DropIndex("dbo.CPUCooler", new[] { "SupplierId" });
            DropIndex("dbo.CPUCooler", new[] { "ProductId" });
            DropIndex("dbo.user", new[] { "Wishlist_WishlistId" });
            DropIndex("dbo.user", new[] { "SSD_SSDId" });
            DropIndex("dbo.user", new[] { "RAM_RAMId" });
            DropIndex("dbo.user", new[] { "PowerSupply_PowerSupplyId" });
            DropIndex("dbo.user", new[] { "Motherboard_MotherboardId" });
            DropIndex("dbo.user", new[] { "InternalHDD_InternalHDDId" });
            DropIndex("dbo.user", new[] { "GPU_GPUId" });
            DropIndex("dbo.user", new[] { "CPUCooler_CPUCoolerId" });
            DropIndex("dbo.user", new[] { "Case_CaseId" });
            DropIndex("dbo.user", new[] { "Product_ProductId" });
            DropIndex("dbo.Product", new[] { "Wishlist_WishlistId" });
            DropIndex("dbo.Product", new[] { "SSD_SSDId" });
            DropIndex("dbo.Product", new[] { "RAM_RAMId" });
            DropIndex("dbo.Product", new[] { "PowerSupply_PowerSupplyId" });
            DropIndex("dbo.Product", new[] { "Motherboard_MotherboardId" });
            DropIndex("dbo.Product", new[] { "InternalHDD_InternalHDDId" });
            DropIndex("dbo.Product", new[] { "GPU_GPUId" });
            DropIndex("dbo.Product", new[] { "CPUCooler_CPUCoolerId" });
            DropIndex("dbo.Product", new[] { "Case_CaseId" });
            DropIndex("dbo.Product", new[] { "SupplierId" });
            DropIndex("dbo.case", new[] { "SupplierId" });
            DropIndex("dbo.case", new[] { "ProductId" });
            DropTable("dbo.Wishlist");
            DropTable("dbo.SSD");
            DropTable("dbo.ram");
            DropTable("dbo.power supply");
            DropTable("dbo.motherboard");
            DropTable("dbo.Itnernal hard disk");
            DropTable("dbo.gpu");
            DropTable("dbo.CPUCooler");
            DropTable("dbo.chat");
            DropTable("dbo.user");
            DropTable("dbo.Supplier");
            DropTable("dbo.Product");
            DropTable("dbo.case");
        }
    }
}
