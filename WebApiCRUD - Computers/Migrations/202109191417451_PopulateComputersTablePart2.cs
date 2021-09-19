namespace WebApiCRUD___Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComputersTablePart2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('X200','Intel','i3',2,256,20,1000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('X300','Intel','i5',4,512,22,2000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('X400','Intel','i7',8,1024,24,3000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('X500','Intel','i9',16,2048,26,4000)");
        }

        public override void Down()
        {
        }
    }
}
