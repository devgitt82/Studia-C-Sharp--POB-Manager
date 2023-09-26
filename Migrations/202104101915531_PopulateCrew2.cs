namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCrew2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Gabriella','Sabatini',66,1)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Novak','Djokovic',67,2)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Rafael','Nadal',68,3)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Hubert','Hurkacz',69,4)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Andre','Agassi',70,5)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Pete','Sampras',71,1)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Steffi','Graff',72,2)");
            Sql("INSERT INTO CrewMembers (FirstName, LastName, CabinId, MusterStationId) VALUES ('Agniaeszka','Radwanska',73,3)");
        }
        
        public override void Down()
        {
        }
    }
}
