namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMotherboard : DbMigration
    {
        public override void Up()
        {
            
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
                    })
                .PrimaryKey(t => t.MotherboardId);
            
            
        }
        
        public override void Down()
        {
            
            
            DropTable("dbo.motherboard");
        }
    }
}
