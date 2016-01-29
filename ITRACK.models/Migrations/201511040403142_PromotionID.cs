namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromotionID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndividualProductionDetails",
                c => new
                    {
                        IndividualProductionDetailsID = c.String(nullable: false, maxLength: 128),
                        StyleNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        HourNo = c.Int(nullable: false),
                        WorkstationNo = c.Int(nullable: false),
                        OperationNo = c.String(),
                        OperationName = c.String(),
                        Pcs = c.Int(nullable: false),
                        SMV = c.Double(nullable: false),
                        SAH = c.Double(nullable: false),
                        Efficiency = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IndividualProductionDetailsID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
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
            DropForeignKey("dbo.IndividualProductionDetails", "CompanyID", "dbo.Companies");
            DropIndex("dbo.IndividualProductionDetails", new[] { "CompanyID" });
            DropColumn("dbo.Promotions", "JobDescription");
            DropColumn("dbo.Promotions", "PromotedDate");
            DropColumn("dbo.Promotions", "ToDesignation");
            DropColumn("dbo.Promotions", "FromDesignation");
            DropTable("dbo.IndividualProductionDetails");
        }
    }
}
