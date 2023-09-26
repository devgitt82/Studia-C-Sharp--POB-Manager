namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastcabinidpopulate : DbMigration
    {
        public override void Up()
        {
           Sql("UPDATE CrewMembers SET LastCabinId = 1");
        }
        
        public override void Down()
        {
        }
    }
}
