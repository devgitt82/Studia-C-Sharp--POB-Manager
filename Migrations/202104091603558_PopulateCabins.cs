namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCabins : DbMigration
    {
        public override void Up()
        {
            //4 MEN CABINS
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (101,'A',1)");
            
            
            
        }
        
        public override void Down()
        {
        }
    }
}
