namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPoNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuttingItems", "PoNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CuttingItems", "PoNo");
        }
    }
}
