namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastCorrections : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE[dbo].[AspNetUserClaims] DROP CONSTRAINT[FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]");
            Sql("ALTER TABLE[dbo].[AspNetUserLogins] DROP CONSTRAINT[FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]");
            Sql("ALTER TABLE[dbo].[AspNetUserRoles] DROP CONSTRAINT[FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]");
            Sql("ALTER TABLE[dbo].[AspNetUserRoles] DROP CONSTRAINT[FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]");
            Sql("ALTER TABLE[dbo].[CrewMembers] DROP CONSTRAINT[FK_dbo.CrewMembers_dbo.MusterStations_MusterStationId]");
            Sql("ALTER TABLE[dbo].[CrewMembers] DROP CONSTRAINT[FK_dbo.CrewMembers_dbo.Cabins_CabinId]");
            Sql("ALTER TABLE[dbo].[CrewMembers] DROP CONSTRAINT[FK_dbo.CrewMembers_dbo.Cabins_LastCabinId]");
            Sql("ALTER TABLE[dbo].[Cabins] DROP CONSTRAINT[FK_dbo.Cabins_dbo.Lifeboats_LifeboatId]");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 7, [JoinDate] = '20210528 00:00:00.000', [DisembarkDate] = '20210605 00:00:00.000', [LastCabinId] = 7 WHERE[Id] = 1");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 5, [DisembarkDate] = '20210528 00:00:00.000', [LastCabinId] = 5 WHERE[Id] = 2");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = NULL, [IsOnBoard] = 0, [LastCabinId] = 66 WHERE[Id] = 3");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = NULL, [IsOnBoard] = 0, [JoinDate] = '20210502 00:00:00.000', [DisembarkDate] = '20210528 00:00:00.000', [LastCabinId] = 7 WHERE[Id] = 4");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 4, [LastCabinId] = 4 WHERE[Id] = 5");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = NULL, [IsOnBoard] = 0, [LastCabinId] = 20 WHERE[Id] = 6");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 3, [LastCabinId] = 3 WHERE[Id] = 7");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 1 WHERE[Id] = 8");
            Sql("UPDATE[dbo].[CrewMembers] SET[CabinId] = 6, [DisembarkDate] = '20210528 00:00:00.000', [LastCabinId] = 6 WHERE[Id] = 9");
            Sql("UPDATE[dbo].[CrewMembers] SET[FirstName] = N'Agnieszka', [CabinId] = 2, [DisembarkDate] = '20210528 00:00:00.000', [LastCabinId] = 2 WHERE[Id] = 10");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 1");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 2");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 3");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 4");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 5");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 6");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 7");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 8");
            Sql("UPDATE[dbo].[Cabins] SET[IsEmpty] = 0 WHERE[Id] = 52");
            Sql("SET IDENTITY_INSERT[dbo].[CrewMembers] ON");
            Sql("INSERT INTO[dbo].[CrewMembers]([Id], [FirstName], [LastName], [CabinId], [MusterStationId], [IsOnBoard], [PassportNo], [SeamansBookNo], [JoinDate], [DisembarkDate], [LastCabinId]) VALUES(11, N'Diego', N'Simeone', 8, 2, 1, N'ABD12345', N'AD234', '20210301 00:00:00.000', '20210528 00:00:00.000', 8)");
            Sql("INSERT INTO[dbo].[CrewMembers] ([Id], [FirstName], [LastName], [CabinId], [MusterStationId], [IsOnBoard], [PassportNo], [SeamansBookNo], [JoinDate], [DisembarkDate], [LastCabinId]) VALUES(20, N'Jinu', N'dcsfcds', 16, 4, 1, N'dsafdsafa', N'fdsafsafas', '20210619 00:00:00.000', '20210619 00:00:00.000', 16)");
            Sql("INSERT INTO[dbo].[CrewMembers] ([Id], [FirstName], [LastName], [CabinId], [MusterStationId], [IsOnBoard], [PassportNo], [SeamansBookNo], [JoinDate], [DisembarkDate], [LastCabinId]) VALUES(21, N'Maciej', N'Guzak', NULL, 4, 0, N'21321312', N'21312312', '20221016 00:00:00.000', '20221016 00:00:00.000', 10)");
            Sql("SET IDENTITY_INSERT[dbo].[CrewMembers] OFF");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'05fadde3-f588-4796-a518-8b2d552083ee', N'admin@statek.com', 0, N'ABpePlUFcFmb6W1P9L9ORRt3y4+9QiWQGQoVL9GeTAUXClq8pT9ofeom96RHmuDo8w==', N'ccfd3899-91c8-42d0-aae5-013a129365f1', NULL, 0, 0, NULL, 1, 0, N'admin@statek.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f0678a91-929f-4dd8-b068-0774e5837401', N'crew1@statek.com', 0, N'ADbT1Za4+zEwdJUK880bO4JZ1NBiIJ8N7mT0ZtAJo/O+AQqFl913LV1kYn79UUV8nw==', N'1b3de03e-4858-4214-9020-9d8134284bbd', NULL, 0, 0, NULL, 1, 0, N'crew1@statek.com')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'05fadde3-f588-4796-a518-8b2d552083ee', N'595ea1fd-47c3-43e2-9fd1-e9495df074c5')");
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'595ea1fd-47c3-43e2-9fd1-e9495df074c5', N'Administrator')");
            Sql("SET IDENTITY_INSERT[dbo].[Certificates] ON");
            Sql("INSERT INTO[dbo].[Certificates]([Id], [CrewMemberId], [CoCPath]) VALUES(25, 8, N'sampras.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(26, 2, N'maradonna.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(27, 7, N'agassi.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(28, 5, N'nadal.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(29, 9, N'graff.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(31, 4, N'djokovic.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(33, 6, N'hurkacz.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(34, 3, N'sabattini.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(35, 10, N'radwanska.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(39, 8, N'10.1.1.471.9487.pdf')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(44, 11, N'10.1.1.471.9487.pdf')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(48, 9, N'swiatek.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(49, 1, N'swiatek.jpg')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(50, 1, N'Cwiczenie2.pdf')");
            Sql("INSERT INTO[dbo].[Certificates] ([Id], [CrewMemberId], [CoCPath]) VALUES(52, 20, N'_Cwiczenie1_.pdf')");
            Sql("SET IDENTITY_INSERT[dbo].[Certificates] OFF");
            Sql("ALTER TABLE[dbo].[AspNetUserClaims] ADD CONSTRAINT[FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId]) REFERENCES[dbo].[AspNetUsers]([Id]) ON DELETE CASCADE");
            Sql("ALTER TABLE[dbo].[AspNetUserLogins] ADD CONSTRAINT[FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId]) REFERENCES[dbo].[AspNetUsers]([Id]) ON DELETE CASCADE");
            Sql("ALTER TABLE[dbo].[AspNetUserRoles] ADD CONSTRAINT[FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId]) REFERENCES[dbo].[AspNetRoles]([Id]) ON DELETE CASCADE");
            Sql("ALTER TABLE[dbo].[AspNetUserRoles] ADD CONSTRAINT[FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId]) REFERENCES[dbo].[AspNetUsers]([Id]) ON DELETE CASCADE");
            Sql("ALTER TABLE[dbo].[CrewMembers] ADD CONSTRAINT[FK_dbo.CrewMembers_dbo.MusterStations_MusterStationId] FOREIGN KEY([MusterStationId]) REFERENCES[dbo].[MusterStations]([Id]) ON DELETE CASCADE");
            Sql("ALTER TABLE[dbo].[CrewMembers] ADD CONSTRAINT[FK_dbo.CrewMembers_dbo.Cabins_CabinId] FOREIGN KEY([CabinId]) REFERENCES[dbo].[Cabins]([Id])");
            Sql("ALTER TABLE[dbo].[CrewMembers] ADD CONSTRAINT[FK_dbo.CrewMembers_dbo.Cabins_LastCabinId] FOREIGN KEY([LastCabinId]) REFERENCES[dbo].[Cabins]([Id])");
            Sql("ALTER TABLE[dbo].[Cabins] ADD CONSTRAINT[FK_dbo.Cabins_dbo.Lifeboats_LifeboatId] FOREIGN KEY([LifeboatId]) REFERENCES[dbo].[Lifeboats]([Id]) ON DELETE CASCADE");

        }

        public override void Down()
        {
        }
    }
}
