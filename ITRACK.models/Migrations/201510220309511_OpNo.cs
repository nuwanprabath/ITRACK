namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OprationBarcodes", "WorkstationNo", c => c.Int(nullable: false));
            AddColumn("dbo.DividingPlanItems", "WorkstationNo", c => c.Int(nullable: false));
            AddColumn("dbo.DividingPlanItems", "OpNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DividingPlanItems", "OpNo");
            DropColumn("dbo.DividingPlanItems", "WorkstationNo");
            DropColumn("dbo.OprationBarcodes", "WorkstationNo");
        }
    }
}
