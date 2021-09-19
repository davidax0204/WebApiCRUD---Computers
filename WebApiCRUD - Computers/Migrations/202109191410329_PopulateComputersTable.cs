namespace WebApiCRUD___Computers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComputersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Computers (ModelName, ManufacturerCompanyName, CPU, RAM, Memory, ScreenSize, Price) VALUES ('X100','Intel','i3',2,256,20,1000) SET IDENTITY_INSERT Computers OFF");
            
        }

        public override void Down()
        {
        }
    }
}
