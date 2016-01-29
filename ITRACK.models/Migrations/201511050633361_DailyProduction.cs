namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DailyProduction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyProductions",
                c => new
                    {
                        DailyProductionID = c.Int(nullable: false, identity: true),
                        PoNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        HourNo = c.Int(nullable: false),
                        LineNo = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        In = c.Double(nullable: false),
                        Out = c.Double(nullable: false),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DailyProductionID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyProductions", "StyleID", "dbo.Styles");
            DropIndex("dbo.DailyProductions", new[] { "StyleID" });
            DropTable("dbo.DailyProductions");
        }
    }
}
