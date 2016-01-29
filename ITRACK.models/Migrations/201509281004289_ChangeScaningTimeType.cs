namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeScaningTimeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScaningTimeSchaduals", "ScaningTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScaningTimeSchaduals", "ScaningTime", c => c.DateTime(nullable: false));
        }
    }
}
