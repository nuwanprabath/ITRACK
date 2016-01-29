namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenaratedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BundleHeaders", "GenaratedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BundleHeaders", "GenaratedDate");
        }
    }
}
