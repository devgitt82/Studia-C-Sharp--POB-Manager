namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLBCapacity : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Lifeboats SET Capacity = 120 WHERE Id=1");
            Sql("UPDATE Lifeboats SET Capacity = 120 WHERE Id=2");
            Sql("UPDATE Lifeboats SET Capacity = 120 WHERE Id=3");
            Sql("UPDATE Lifeboats SET Capacity = 120 WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
