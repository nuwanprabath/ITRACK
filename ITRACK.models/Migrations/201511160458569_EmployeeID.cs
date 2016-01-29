namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.IndividualProductionDetails");
            AddColumn("dbo.IndividualProductionDetails", "EmployeeID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.IndividualProductionDetails", "StyleNo", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.IndividualProductionDetails", "OperationNo", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.IndividualProductionDetails", new[] { "EmployeeID", "StyleNo", "Date", "HourNo", "OperationNo" });
            DropColumn("dbo.IndividualProductionDetails", "IndividualProductionDetailsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IndividualProductionDetails", "IndividualProductionDetailsID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.IndividualProductionDetails");
            AlterColumn("dbo.IndividualProductionDetails", "OperationNo", c => c.String());
            AlterColumn("dbo.IndividualProductionDetails", "StyleNo", c => c.String());
            DropColumn("dbo.IndividualProductionDetails", "EmployeeID");
            AddPrimaryKey("dbo.IndividualProductionDetails", "IndividualProductionDetailsID");
        }
    }
}
