namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCase : DbMigration
    {
        public override void Up()
        {
            CreateTable
                ("dbo.case",
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
                    Weight = c.Decimal(nullable: false),
                    Width = c.Decimal(nullable: false),
                    Depth = c.Decimal(nullable: false),
                    Height = c.Decimal(nullable: false),
                    Color = c.String(unicode: false),
                    Material = c.String(unicode: false)

                })
                .PrimaryKey(t => t.CaseId);
               
        }
        
        public override void Down()
        {
            DropTable("dbo.case");
        }
    }
}
