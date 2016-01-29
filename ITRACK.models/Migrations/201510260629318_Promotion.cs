namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Promotion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Promotions", "FromDesignation", c => c.String());
            AddColumn("dbo.Promotions", "ToDesignation", c => c.String());
            AddColumn("dbo.Promotions", "PromotedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Promotions", "JobDescription", c => c.String());
            DropColumn("dbo.Promotions", "Designation");
            DropColumn("dbo.Promotions", "fromDate");
            DropColumn("dbo.Promotions", "ToDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Promotions", "ToDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Promotions", "fromDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Promotions", "Designation", c => c.String());
            DropColumn("dbo.Promotions", "JobDescription");
            DropColumn("dbo.Promotions", "PromotedDate");
            DropColumn("dbo.Promotions", "ToDesignation");
            DropColumn("dbo.Promotions", "FromDesignation");
        }
    }
}
