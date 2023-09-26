namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCabin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cabins",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Number = c.Short(nullable: false),
                        Bunk = c.String(nullable: false),
                        LifeboatId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lifeboats", t => t.LifeboatId, cascadeDelete: true)
                .Index(t => t.LifeboatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cabins", "LifeboatId", "dbo.Lifeboats");
            DropIndex("dbo.Cabins", new[] { "LifeboatId" });
            DropTable("dbo.Cabins");
        }
    }
}
