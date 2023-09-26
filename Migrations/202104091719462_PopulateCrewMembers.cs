namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCrewMembers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Iga','Świątek',64,1)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Diego','Maradona',64,1)");
            
        }
        
        public override void Down()
        {
        }
    }
}
