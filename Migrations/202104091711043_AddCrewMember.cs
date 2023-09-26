namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCrewMember : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CrewMembers",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        CabinId = c.Short(nullable: true),
                        MusterStationId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cabins", t => t.CabinId, cascadeDelete: true)
                .ForeignKey("dbo.MusterStations", t => t.MusterStationId, cascadeDelete: true)
                .Index(t => t.CabinId)
                .Index(t => t.MusterStationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrewMembers", "MusterStationId", "dbo.MusterStations");
            DropForeignKey("dbo.CrewMembers", "CabinId", "dbo.Cabins");
            DropIndex("dbo.CrewMembers", new[] { "MusterStationId" });
            DropIndex("dbo.CrewMembers", new[] { "CabinId" });
            DropTable("dbo.CrewMembers");
        }
    }
}
