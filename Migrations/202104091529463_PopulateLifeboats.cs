namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLifeboats : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Lifeboats (Id,Number) VALUES (1,1)");
            Sql("INSERT INTO Lifeboats (Id,Number) VALUES (2,2)");
            Sql("INSERT INTO Lifeboats (Id,Number) VALUES (3,3)");
            Sql("INSERT INTO Lifeboats (Id,Number) VALUES (4,4)");
        }
        
        public override void Down()
        {
        }
    }
}
