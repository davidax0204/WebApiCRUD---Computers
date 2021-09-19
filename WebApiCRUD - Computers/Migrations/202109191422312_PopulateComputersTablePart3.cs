namespace WebApiCRUD___Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComputersTablePart3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('M100','AMD','m3',2,256,20,750)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('M200','AMD','m3',2,256,20,1500)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('M300','AMD','m5',4,512,22,2500)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('M400','AMD','m7',8,1024,24,3500)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('M500','AMD','m9',16,2048,26,5000)");
        }
        
        public override void Down()
        {
        }
    }
}
