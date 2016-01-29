namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScaningTimeSchadual : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScaningTimeSchaduals",
                c => new
                    {
                        ScaningTimeSchadualID = c.Int(nullable: false, identity: true),
                        ScaningTime = c.DateTime(nullable: false),
                        HourNO = c.Int(nullable: false),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScaningTimeSchadualID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScaningTimeSchaduals", "CompanyID", "dbo.Companies");
            DropIndex("dbo.ScaningTimeSchaduals", new[] { "CompanyID" });
            DropTable("dbo.ScaningTimeSchaduals");
        }
    }
}
