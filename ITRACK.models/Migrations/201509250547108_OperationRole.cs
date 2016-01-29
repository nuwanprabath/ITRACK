namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OperationRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DividingPlanItems", "OperationRole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DividingPlanItems", "OperationRole");
        }
    }
}
