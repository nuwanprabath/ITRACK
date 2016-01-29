namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PoItems", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PoItems", "Description");
        }
    }
}
