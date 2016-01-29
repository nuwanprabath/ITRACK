namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GrnItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrnItems",
                c => new
                    {
                        GrnItemsID = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        Description = c.String(),
                        Color = c.String(),
                        Width = c.String(),
                        Unit = c.String(),
                        Qty = c.Double(nullable: false),
                        ReceivedQty = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        ReceivedPrice = c.Double(nullable: false),
                        LineDiscount = c.Double(nullable: false),
                        waistadeQty = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        GRNID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GrnItemsID)
                .ForeignKey("dbo.GRNs", t => t.GRNID)
                .Index(t => t.GRNID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GrnItems", "GRNID", "dbo.GRNs");
            DropIndex("dbo.GrnItems", new[] { "GRNID" });
            DropTable("dbo.GrnItems");
        }
    }
}
