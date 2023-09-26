namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastcabinid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "LastCabinId" });
            AlterColumn("dbo.CrewMembers", "LastCabinId", c => c.Short());
            CreateIndex("dbo.CrewMembers", "LastCabinId");
            AddForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "LastCabinId" });
            AlterColumn("dbo.CrewMembers", "LastCabinId", c => c.Short(nullable: false));
            CreateIndex("dbo.CrewMembers", "LastCabinId");
            AddForeignKey("dbo.CrewMembers", "LastCabinId", "dbo.Cabins", "Id", cascadeDelete: true);
        }
    }
}
