namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class S : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DailyProductions", "Qty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DailyProductions", "Qty", c => c.Double(nullable: false));
        }
    }
}
