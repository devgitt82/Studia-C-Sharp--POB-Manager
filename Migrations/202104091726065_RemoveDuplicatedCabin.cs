namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDuplicatedCabin : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Cabins WHERE Id=81");
        }
        
        public override void Down()
        {
        }
    }
}
