namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVolunteerData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Volunteers", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Volunteers", "Skills");
            DropColumn("dbo.Volunteers", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Volunteers", "Status", c => c.String());
            AddColumn("dbo.Volunteers", "Skills", c => c.String());
            DropColumn("dbo.Volunteers", "Password");
        }
    }
}
