namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpNo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OprationBarcodes", "OpNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OprationBarcodes", "OpNo");
        }
    }
}
