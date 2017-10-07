namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        id_customer = c.Int(nullable: false, identity: true),
                        customername = c.String(unicode: false),
                        nit = c.String(unicode: false),
                        address = c.String(unicode: false)
                    })
                    .PrimaryKey(t => t.id_customer);
        }
        
        public override void Down()
        {
            DropTable("dbo.customer");
        }
    }
}
