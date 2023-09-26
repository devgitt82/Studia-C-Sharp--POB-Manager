namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastcabin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CrewMembers", "LastCabinId", c => c.Short(nullable: true));
            CreateIndex("dbo.CrewMembers", "LastCabinId");
            AddForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "LastCabinId" });
            DropColumn("dbo.CrewMembers", "LastCabinId");
        }
    }
}
