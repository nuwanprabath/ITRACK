namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VehicleRequisitions",
                c => new
                    {
                        VehicleRequisitionID = c.String(nullable: false, maxLength: 128),
                        RequestDate = c.String(),
                        RequestTime = c.String(),
                        RequestBy = c.String(),
                        Department = c.String(),
                        VehicleType = c.String(),
                        Purpose = c.String(),
                        DriverName = c.String(),
                        ContactNo = c.String(),
                        VehicleNo = c.String(),
                        SpeedDialNo = c.String(),
                        Payment = c.String(),
                        AssignToJob = c.String(),
                        TimeStart = c.String(),
                        TimeFinished = c.String(),
                        MyProperty = c.String(),
                        StartMeter = c.String(),
                        FinishedMeter = c.String(),
                        TravelledDistance = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleRequisitionID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleRequisitions", "CompanyID", "dbo.Companies");
            DropIndex("dbo.VehicleRequisitions", new[] { "CompanyID" });
            DropTable("dbo.VehicleRequisitions");
        }
    }
}
