namespace EFFY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.product2",
                c => new
                    {
                        id_product = c.Int(nullable: false, identity: true),
                        productname = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id_product);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.product2");
        }
    }
}
