namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateOccupiedCabinsToIsEmptyToFalse : DbMigration
    {
        public override void Up()
        {
            Sql(@"MERGE Cabins AS Cab USING (SELECT * FROM CrewMembers) AS Crew on Cab.Id = Crew.CabinId WHEN MATCHED THEN UPDATE SET Cab.IsEmpty='False';");

        }

        public override void Down()
        {
        }
    }
}
