namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGPU : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.GPUId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.gpu");
        }
    }
}
