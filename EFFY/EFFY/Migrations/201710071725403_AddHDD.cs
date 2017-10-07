namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHDD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inernal hard disk",
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
                    })
                .PrimaryKey(t => t.InternalHDD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inernal hard disk");
        }
    }
}
