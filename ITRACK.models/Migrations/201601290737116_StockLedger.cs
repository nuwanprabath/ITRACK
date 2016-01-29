namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockLedger : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockLedgers",
                c => new
                    {
                        TransactionID = c.String(nullable: false, maxLength: 128),
                        ItemCode = c.String(),
                        ItemType = c.String(),
                        Category = c.String(),
                        TransactionType = c.String(),
                        DocNo = c.String(),
                        TransactionTime = c.DateTime(nullable: false),
                        TransactionBy = c.String(),
                        Qty = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .Index(t => t.Company_CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockLedgers", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.StockLedgers", new[] { "Company_CompanyID" });
            DropTable("dbo.StockLedgers");
        }
    }
}
