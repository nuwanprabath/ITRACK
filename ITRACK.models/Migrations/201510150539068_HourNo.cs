namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HourNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OprationBarcodes", "HourNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OprationBarcodes", "HourNo");
        }
    }
}
