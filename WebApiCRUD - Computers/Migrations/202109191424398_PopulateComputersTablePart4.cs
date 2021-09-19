namespace WebApiCRUD___Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComputersTablePart4 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('A100','Apple','a3',8,256,20,2000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('A200','Apple','a3',4,256,20,4000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('A300','Apple','a5',8,512,22,6000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('A400','Apple','a7',16,1024,24,8000)");
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('A500','Apple','a9',32,2048,26,10000)");
        }
        
        public override void Down()
        {
        }
    }
}
