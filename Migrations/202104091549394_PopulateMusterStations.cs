namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMusterStations : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MusterStations (Id,Location) VALUES (1,'Bridge')");
            Sql("INSERT INTO MusterStations (Id,Location) VALUES (2,'Engine Room')");
            Sql("INSERT INTO MusterStations (Id,Location) VALUES (3,'Main Deck')");
            Sql("INSERT INTO MusterStations (Id,Location) VALUES (4,'Fire Team 1')");
            Sql("INSERT INTO MusterStations (Id,Location) VALUES (5,'Fire Team 2')");
        }
        
        public override void Down()
        {
        }
    }
}
