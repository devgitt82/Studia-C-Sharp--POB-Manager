namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUsersAndRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'05fadde3-f588-4796-a518-8b2d552083ee', N'admin@statek.com', 0, N'ABpePlUFcFmb6W1P9L9ORRt3y4+9QiWQGQoVL9GeTAUXClq8pT9ofeom96RHmuDo8w==', N'ccfd3899-91c8-42d0-aae5-013a129365f1', NULL, 0, 0, NULL, 1, 0, N'admin@statek.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f0678a91-929f-4dd8-b068-0774e5837401', N'crew1@statek.com', 0, N'ADbT1Za4+zEwdJUK880bO4JZ1NBiIJ8N7mT0ZtAJo/O+AQqFl913LV1kYn79UUV8nw==', N'1b3de03e-4858-4214-9020-9d8134284bbd', NULL, 0, 0, NULL, 1, 0, N'crew1@statek.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'595ea1fd-47c3-43e2-9fd1-e9495df074c5', N'Administrator')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'05fadde3-f588-4796-a518-8b2d552083ee', N'595ea1fd-47c3-43e2-9fd1-e9495df074c5')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
