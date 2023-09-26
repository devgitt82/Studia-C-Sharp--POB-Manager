namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsEmptyToCabinModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cabins", "IsEmpty", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cabins", "IsEmpty");
        }
    }
}
