namespace MyShip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCabins2 : DbMigration
    {
        public override void Up()
        {
            //4 MEN CABINS
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (101,'B',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (101,'C',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (101,'D',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (102,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (102,'B',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (102,'C',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (102,'D',1)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (103,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (103,'B',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (103,'C',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (103,'D',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (104,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (104,'B',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (104,'C',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (104,'D',3)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (105,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (105,'B',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (105,'C',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (105,'D',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (106,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (106,'B',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (106,'C',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (106,'D',2)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (107,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (107,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (107,'C',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (107,'D',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (108,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (108,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (108,'C',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (108,'D',4)");
            //2 MEN CABINS
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (201,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (201,'B',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (202,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (202,'B',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (203,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (203,'B',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (204,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (204,'B',1)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (205,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (205,'B',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (206,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (206,'B',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (207,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (207,'B',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (208,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (208,'B',3)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (209,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (209,'B',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (210,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (210,'B',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (211,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (211,'B',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (212,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (212,'B',2)");

            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (213,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (213,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (214,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (214,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (215,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (215,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (216,'B',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (216,'B',4)");
            //SINGLE CABINS
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (301,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (302,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (303,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (304,'A',1)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (305,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (306,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (307,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (308,'A',2)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (309,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (310,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (311,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (312,'A',3)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (313,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (314,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (315,'A',4)");
            Sql("INSERT INTO Cabins (Number,Bunk,LifeboatId) VALUES (316,'A',4)");
        }
        
        public override void Down()
        {
        }
    }
}
