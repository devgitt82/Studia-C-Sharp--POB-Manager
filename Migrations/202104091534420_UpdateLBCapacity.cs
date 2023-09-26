namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLBCapacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lifeboats", "Capacity", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lifeboats", "Capacity");
        }
    }
}
