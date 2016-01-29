namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyProductions", "Type", c => c.String());
            AddColumn("dbo.DailyProductions", "Qty", c => c.Double(nullable: false));
            DropColumn("dbo.DailyProductions", "In");
            DropColumn("dbo.DailyProductions", "Out");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DailyProductions", "Out", c => c.Double(nullable: false));
            AddColumn("dbo.DailyProductions", "In", c => c.Double(nullable: false));
            DropColumn("dbo.DailyProductions", "Qty");
            DropColumn("dbo.DailyProductions", "Type");
        }
    }
}
