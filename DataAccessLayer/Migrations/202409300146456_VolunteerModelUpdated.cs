namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VolunteerModelUpdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Volunteers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Volunteers", "Password", c => c.String(nullable: false));
        }
    }
}
