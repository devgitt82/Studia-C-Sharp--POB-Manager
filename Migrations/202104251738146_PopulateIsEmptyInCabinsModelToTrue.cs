namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateIsEmptyInCabinsModelToTrue : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Cabins SET IsEmpty = 'True'");
        }

        public override void Down()
        {
        }
    }
}
