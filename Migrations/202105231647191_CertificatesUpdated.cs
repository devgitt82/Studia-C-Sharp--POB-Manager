namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CertificatesUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certificates", "CoCPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Certificates", "CoCPath");
        }
    }
}
