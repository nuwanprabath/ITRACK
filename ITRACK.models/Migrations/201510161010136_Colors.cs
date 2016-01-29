namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Colors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PoItems", "Colors", c => c.String());
            AddColumn("dbo.PoItems", "Width", c => c.String());
            AddColumn("dbo.PoItems", "Unit", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PoItems", "Unit");
            DropColumn("dbo.PoItems", "Width");
            DropColumn("dbo.PoItems", "Colors");
        }
    }
}
