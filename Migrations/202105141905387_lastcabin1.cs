namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastcabin1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CrewMembers", "CabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "CabinId" });
            AlterColumn("dbo.CrewMembers", "CabinId", c => c.Short());
            CreateIndex("dbo.CrewMembers", "CabinId");
            AddForeignKey("dbo.CrewMembers", "CabinId", "dbo.Cabins", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrewMembers", "CabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "CabinId" });
            AlterColumn("dbo.CrewMembers", "CabinId", c => c.Short(nullable: false));
            CreateIndex("dbo.CrewMembers", "CabinId");
            AddForeignKey("dbo.CrewMembers", "CabinId", "dbo.Cabins", "Id", cascadeDelete: true);
        }
    }
}
