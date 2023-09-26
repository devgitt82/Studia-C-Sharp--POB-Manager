namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminPropertiesToCrewMemberModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CrewMembers", "IsOnBoard", c => c.Boolean(nullable: false));
            AddColumn("dbo.CrewMembers", "PassportNo", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CrewMembers", "SeamansBookNo", c => c.String(maxLength: 255));
            AddColumn("dbo.CrewMembers", "JoinDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CrewMembers", "DisembarkDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CrewMembers", "DisembarkDate");
            DropColumn("dbo.CrewMembers", "JoinDate");
            DropColumn("dbo.CrewMembers", "SeamansBookNo");
            DropColumn("dbo.CrewMembers", "PassportNo");
            DropColumn("dbo.CrewMembers", "IsOnBoard");
        }
    }
}
