namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEventVolData4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.VolenteerEvents", newName: "VolunteerEvents");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.VolunteerEvents", newName: "VolenteerEvents");
        }
    }
}
