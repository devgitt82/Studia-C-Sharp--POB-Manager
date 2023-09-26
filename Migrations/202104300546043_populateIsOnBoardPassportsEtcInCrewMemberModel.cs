namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateIsOnBoardPassportsEtcInCrewMemberModel : DbMigration
    {
        public override void Up()
        {
           
            Sql($"UPDATE Crewmembers SET IsOnBoard = 'true', JoinDate = '2021-04-02' WHERE Id < 11");
            for (int i =0; i<10; i++)
            { 
                Sql($"UPDATE Crewmembers SET PassportNo = '12345{i}' WHERE id = {i + 1}");
                Sql($"UPDATE Crewmembers SET SeamansBookNo = 'AABB12345{i}'  WHERE id = {i+1}");
            }
            Sql($"UPDATE Crewmembers SET DisembarkDate = '2021-04-02' WHERE Id > 10");
            for (int i = 11; i < 19; i++)
            {
                Sql($"UPDATE Crewmembers SET PassportNo = '2234{i}' WHERE id = {i}");
                Sql($"UPDATE Crewmembers SET SeamansBookNo = 'CCBB12345{i}'  WHERE id = {i + 1}");
            }

        }
        
        public override void Down()
        {
        }
    }
}
