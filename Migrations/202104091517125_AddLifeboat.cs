namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLifeboat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lifeboats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Number = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lifeboats");
        }
    }
}
