namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        AwardID = c.Int(nullable: false, identity: true),
                        AwardName = c.String(),
                        AwardDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AwardID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        NicNo = c.String(),
                        EPFNo = c.String(),
                        ETFNo = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        Department = c.String(),
                        Designation = c.String(),
                        JobStatus = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        LandNo = c.String(),
                        EmailAddress = c.String(),
                        EmergencyContactNo = c.String(),
                        EmergencyContactPerson = c.String(),
                        Image = c.Binary(storeType: "image"),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        LocationCode = c.String(nullable: false, maxLength: 10),
                        CompanyName = c.String(),
                        CompanyAddress = c.String(),
                        TeleNo = c.String(),
                        FaxNo = c.String(),
                        isDefaultCompany = c.Boolean(nullable: false),
                        GroupID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CompanyID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        BuyerID = c.Int(nullable: false, identity: true),
                        BuyerName = c.String(),
                        BuyerShippingAddress = c.String(),
                        BuyerTeleNo = c.String(),
                        FaxNo = c.String(),
                        EmailAddress = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuyerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Styles",
                c => new
                    {
                        StyleID = c.String(nullable: false, maxLength: 128),
                        Article = c.String(),
                        Season = c.String(),
                        GarmantType = c.String(),
                        Status = c.String(),
                        Remark = c.String(),
                        FeedingRule = c.String(),
                        ForecastingRule = c.String(),
                        CompanyID = c.Int(nullable: false),
                        BuyerID = c.Int(nullable: false),
                        WorkflowID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StyleID)
                .ForeignKey("dbo.Buyers", t => t.BuyerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .ForeignKey("dbo.Workflows", t => t.WorkflowID)
                .Index(t => t.CompanyID)
                .Index(t => t.BuyerID)
                .Index(t => t.WorkflowID);
            
            CreateTable(
                "dbo.CuttingHeaders",
                c => new
                    {
                        CuttingHeaderID = c.String(nullable: false, maxLength: 128),
                        OrderQuantity = c.Int(nullable: false),
                        PlanQuantity = c.Int(nullable: false),
                        BundleSize = c.Int(nullable: false),
                        ItemType = c.String(),
                        Date = c.DateTime(nullable: false),
                        Remark = c.String(),
                        status = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CuttingHeaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.CuttingItems",
                c => new
                    {
                        CuttingItemID = c.Int(nullable: false, identity: true),
                        MarkerNo = c.String(),
                        FabricType = c.String(),
                        Date = c.DateTime(nullable: false),
                        MarkerLenth = c.Double(nullable: false),
                        MarkerWidth = c.Double(nullable: false),
                        LineNo = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Length = c.String(),
                        NoOfItem = c.Int(nullable: false),
                        NoOfLayer = c.Int(nullable: false),
                        NoOfPlysPlaned = c.Int(nullable: false),
                        NoOfPlysLayed = c.Int(nullable: false),
                        isGenaratedTags = c.Boolean(nullable: false),
                        GenaratedTime = c.String(),
                        isPrinted = c.Boolean(nullable: false),
                        PrinteTime = c.String(),
                        CuttingHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CuttingItemID)
                .ForeignKey("dbo.CuttingHeaders", t => t.CuttingHeaderID)
                .Index(t => t.CuttingHeaderID);
            
            CreateTable(
                "dbo.BundleHeaders",
                c => new
                    {
                        BundleHeaderID = c.Long(nullable: false, identity: true),
                        isBundleTagsGerated = c.Boolean(nullable: false),
                        BundleTagGenaratedBy = c.String(),
                        BundleTagGenaratedTime = c.String(),
                        isOprationTagGenated = c.Boolean(nullable: false),
                        OprationTagGeratedBy = c.String(),
                        OprationTagGenaratedTime = c.String(),
                        isCompleteGenarateTags = c.Boolean(nullable: false),
                        CuttingItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BundleHeaderID)
                .ForeignKey("dbo.CuttingItems", t => t.CuttingItemID)
                .Index(t => t.CuttingItemID);
            
            CreateTable(
                "dbo.DividingPlanHeaders",
                c => new
                    {
                        DividingPlanheaderID = c.Int(nullable: false, identity: true),
                        LineNo = c.String(),
                        TotalEmployee = c.Int(nullable: false),
                        Target = c.Int(nullable: false),
                        ProductionPerHour = c.Int(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DividingPlanheaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.FabricDetails",
                c => new
                    {
                        FabricDetailsID = c.Int(nullable: false, identity: true),
                        FabricType = c.String(),
                        FabricName = c.String(),
                        Color = c.String(),
                        PlanedConsumtion = c.Double(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FabricDetailsID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PurchaseOrderHeaders",
                c => new
                    {
                        PurchaseOrderHeaderID = c.String(nullable: false, maxLength: 128),
                        Article = c.String(),
                        Season = c.String(),
                        DeliveryTerms = c.String(),
                        PlaceWashingFactory = c.Boolean(nullable: false),
                        OrderPrice = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PurchaseOrderHeaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PurchaseOrderItems",
                c => new
                    {
                        PurchaseOrderID = c.String(nullable: false, maxLength: 128),
                        Color = c.String(nullable: false, maxLength: 128),
                        Size = c.String(nullable: false, maxLength: 128),
                        Length = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        PurchaseOrderHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PurchaseOrderID, t.Color, t.Size, t.Length })
                .ForeignKey("dbo.PurchaseOrderHeaders", t => t.PurchaseOrderHeaderID)
                .Index(t => t.PurchaseOrderHeaderID);
            
            CreateTable(
                "dbo.SketchDefinitions",
                c => new
                    {
                        SketchDefinitionID = c.Int(nullable: false, identity: true),
                        SketchName = c.String(),
                        Remark = c.String(),
                        ItemType = c.String(),
                        Image = c.Binary(storeType: "image"),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SketchDefinitionID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PartDefinitions",
                c => new
                    {
                        PartDefinitionID = c.Int(nullable: false, identity: true),
                        PartName = c.String(),
                        ItemType = c.String(),
                        Remark = c.String(),
                        SketchDefinitionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartDefinitionID)
                .ForeignKey("dbo.SketchDefinitions", t => t.SketchDefinitionID)
                .Index(t => t.SketchDefinitionID);
            
            CreateTable(
                "dbo.StyleOperations",
                c => new
                    {
                        StyleOperationID = c.Int(nullable: false, identity: true),
                        SMV = c.Double(nullable: false),
                        PartDefinitionID = c.String(),
                        PartDefinition_PartDefinitionID = c.Int(),
                    })
                .PrimaryKey(t => t.StyleOperationID)
                .ForeignKey("dbo.PartDefinitions", t => t.PartDefinition_PartDefinitionID)
                .Index(t => t.PartDefinition_PartDefinitionID);
            
            CreateTable(
                "dbo.Workflows",
                c => new
                    {
                        WorkflowID = c.Int(nullable: false, identity: true),
                        WorkflowName = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.WorkflowID);
            
            CreateTable(
                "dbo.WorkflowSetups",
                c => new
                    {
                        WorkflowSetupID = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        WorkflowID = c.Int(nullable: false),
                        Workstation_WorkstationID = c.Int(),
                    })
                .PrimaryKey(t => t.WorkflowSetupID)
                .ForeignKey("dbo.Workflows", t => t.WorkflowID)
                .ForeignKey("dbo.Workstations", t => t.Workstation_WorkstationID)
                .Index(t => t.WorkflowID)
                .Index(t => t.Workstation_WorkstationID);
            
            CreateTable(
                "dbo.Workstations",
                c => new
                    {
                        WorkstationID = c.Int(nullable: false, identity: true),
                        WorkstationName = c.String(),
                        Remark = c.String(),
                        Employee_EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.WorkstationID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.CustomeFieldSetups",
                c => new
                    {
                        CustomeFieldSetupID = c.Int(nullable: false, identity: true),
                        ItemType = c.String(),
                        CustomField1 = c.String(),
                        CustomField2 = c.String(),
                        CustomField3 = c.String(),
                        CustomField4 = c.String(),
                        CustomField5 = c.String(),
                        CustomField6 = c.String(),
                        CodeLength = c.Int(nullable: false),
                        ItemCodeGenerate = c.Boolean(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomeFieldSetupID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemsID = c.String(nullable: false, maxLength: 128),
                        ItemType = c.String(),
                        CustomFiled1 = c.String(),
                        CustomField2 = c.String(),
                        CustomField3 = c.String(),
                        CustomField4 = c.String(),
                        CustomField5 = c.String(),
                        CustomField6 = c.String(),
                        SupplierItemCode = c.String(),
                        Uom = c.String(),
                        Status = c.String(),
                        MaxQty = c.String(),
                        ReOrderQty = c.String(),
                        MinimumQty = c.String(),
                        BatchItem = c.Boolean(nullable: false),
                        ServiceItem = c.Boolean(nullable: false),
                        ShowInFrontEnd = c.Boolean(nullable: false),
                        Discount = c.Boolean(nullable: false),
                        CustomerReturnOrder = c.Boolean(nullable: false),
                        SerialItems = c.Boolean(nullable: false),
                        Image = c.Binary(storeType: "image"),
                        CustomeFieldSetupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemsID)
                .ForeignKey("dbo.CustomeFieldSetups", t => t.CustomeFieldSetupID)
                .Index(t => t.CustomeFieldSetupID);
            
            CreateTable(
                "dbo.PoItems",
                c => new
                    {
                        PoItemsID = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        Price = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        ItemsID = c.String(maxLength: 128),
                        POID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PoItemsID)
                .ForeignKey("dbo.Items", t => t.ItemsID)
                .ForeignKey("dbo.POes", t => t.POID)
                .Index(t => t.ItemsID)
                .Index(t => t.POID);
            
            CreateTable(
                "dbo.POes",
                c => new
                    {
                        POID = c.String(nullable: false, maxLength: 128),
                        SupplierMasterID = c.String(maxLength: 128),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                        CompanyCode = c.String(),
                        CompanyName = c.String(),
                        CompamyAddress = c.String(),
                        ReferenceNo = c.String(),
                        Date = c.String(),
                        PurchaseType = c.String(),
                        Currency = c.String(),
                        Country = c.String(),
                        ShippingType = c.String(),
                        DeliveryDate = c.String(),
                        port = c.String(),
                        ShippingDate = c.String(),
                        HandleBy = c.String(),
                        CreditTerms = c.String(),
                        ReturnPolicy = c.String(),
                        Qty = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .ForeignKey("dbo.SupplierMasters", t => t.SupplierMasterID)
                .Index(t => t.SupplierMasterID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.GRNs",
                c => new
                    {
                        GRNID = c.String(nullable: false, maxLength: 128),
                        LocationCode = c.String(),
                        POID = c.String(maxLength: 128),
                        PoDate = c.String(),
                        Date = c.String(),
                        Supplier = c.String(),
                        SupplierCode = c.String(),
                        SupplierInvoiceNo = c.String(),
                        InvoiceDate = c.String(),
                        ShipmentType = c.String(),
                        Currency = c.String(),
                        ExchangeRate = c.String(),
                    })
                .PrimaryKey(t => t.GRNID)
                .ForeignKey("dbo.POes", t => t.POID)
                .Index(t => t.POID);
            
            CreateTable(
                "dbo.SupplierMasters",
                c => new
                    {
                        SupplierMasterID = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                        SupplierType = c.String(),
                        SupplierAddress = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Status = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        TelephoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                        WebAddress = c.String(),
                        PosalCode = c.String(),
                        BankName = c.String(),
                        AccountNumber = c.String(),
                        ChequeType = c.String(),
                        Currency = c.String(),
                        CreditTerm = c.String(),
                        AccountName = c.String(),
                        Branch = c.String(),
                        BankAddress = c.String(),
                        SvatNo = c.String(),
                        CompanyID = c.Int(nullable: false),
                        POID = c.String(),
                    })
                .PrimaryKey(t => t.SupplierMasterID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupID = c.String(nullable: false, maxLength: 128),
                        GroupName = c.String(),
                        Address = c.String(),
                        TeleNo = c.String(),
                        FaxNo = c.String(),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.OperationPools",
                c => new
                    {
                        OperationPoolID = c.String(nullable: false, maxLength: 128),
                        OpationName = c.String(),
                        MachineType = c.String(),
                        SMV = c.Double(nullable: false),
                        SMVType = c.String(),
                        Remark = c.String(),
                        PartName = c.String(),
                        OprationRole = c.String(),
                        OprationGrade = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OperationPoolID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.RunningNoes",
                c => new
                    {
                        RunningNoID = c.String(nullable: false, maxLength: 128),
                        Code = c.String(),
                        Starting = c.Int(nullable: false),
                        Length = c.Int(nullable: false),
                        Prefix = c.String(),
                        Venue = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunningNoID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Werehouses",
                c => new
                    {
                        WerehouseID = c.Int(nullable: false, identity: true),
                        WerehouseName = c.String(),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WerehouseID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Racks",
                c => new
                    {
                        RackID = c.Int(nullable: false, identity: true),
                        RackName = c.String(),
                        Remark = c.String(),
                        WerehouseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RackID)
                .ForeignKey("dbo.Werehouses", t => t.WerehouseID)
                .Index(t => t.WerehouseID);
            
            CreateTable(
                "dbo.Bins",
                c => new
                    {
                        BinID = c.Int(nullable: false, identity: true),
                        BinName = c.String(),
                        Remark = c.String(),
                        RackID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BinID)
                .ForeignKey("dbo.Racks", t => t.RackID)
                .Index(t => t.RackID);
            
            CreateTable(
                "dbo.PastEmployeements",
                c => new
                    {
                        PastEmployeementID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Designation = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PastEmployeementID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        fromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PromotionID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                        UserStatus = c.String(),
                        Employee_EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.BundleDetails",
                c => new
                    {
                        BundleDetailsID = c.Int(nullable: false, identity: true),
                        SerailNo = c.String(),
                        NoOfItem = c.Long(nullable: false),
                        CutNo = c.Long(nullable: false),
                        IsPrintBundleSticker = c.Boolean(nullable: false),
                        BundleStickerPrintedBy = c.String(),
                        BundleStickerPrintedTime = c.String(),
                        isBundleTagsPrinted = c.Boolean(nullable: false),
                        BundleTagPrintedBy = c.String(),
                        BundleTagPrintedTime = c.String(),
                        isSuspended = c.Boolean(nullable: false),
                        BundleHeaderID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BundleDetailsID)
                .ForeignKey("dbo.BundleHeaders", t => t.BundleHeaderID)
                .Index(t => t.BundleHeaderID);
            
            CreateTable(
                "dbo.OprationBarcodes",
                c => new
                    {
                        OprationBarcodesID = c.String(nullable: false, maxLength: 128),
                        OprationNO = c.String(),
                        OparationName = c.String(),
                        OprationGrade = c.String(),
                        OprationRole = c.String(),
                        PartName = c.String(),
                        isOparationComplete = c.Boolean(nullable: false),
                        OprationComplteAt = c.DateTime(nullable: false),
                        EmployeeID = c.String(),
                        BundleDetailsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OprationBarcodesID)
                .ForeignKey("dbo.BundleDetails", t => t.BundleDetailsID)
                .Index(t => t.BundleDetailsID);
            
            CreateTable(
                "dbo.DividingPlanItems",
                c => new
                    {
                        DividingPlanItemID = c.Int(nullable: false, identity: true),
                        OprationNo = c.String(),
                        OprationName = c.String(),
                        SMVType = c.String(),
                        MachineType = c.String(),
                        PartName = c.String(),
                        SMV = c.Double(nullable: false),
                        DividingPlanHeaderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DividingPlanItemID)
                .ForeignKey("dbo.DividingPlanHeaders", t => t.DividingPlanHeaderID)
                .Index(t => t.DividingPlanHeaderID);
            
            CreateTable(
                "dbo.DividingPlanTemps",
                c => new
                    {
                        DividingPlanTempID = c.Int(nullable: false, identity: true),
                        LineNo = c.String(),
                        TotalEmployee = c.String(),
                        Target = c.String(),
                        ProductionPerHour = c.String(),
                        StyleID = c.String(),
                        OprationNo = c.String(),
                        OprationName = c.String(),
                        SMVType = c.String(),
                        MachineType = c.String(),
                        SMV = c.String(),
                        Selected = c.Boolean(nullable: false),
                        PartName = c.String(),
                    })
                .PrimaryKey(t => t.DividingPlanTempID);
            
            CreateTable(
                "dbo.TempOprations",
                c => new
                    {
                        TempOprationID = c.Int(nullable: false, identity: true),
                        OprationID = c.String(),
                        OparationName = c.String(),
                        MachineType = c.String(),
                        SMV = c.Double(nullable: false),
                        SMVType = c.String(),
                        Remark = c.String(),
                        PartName = c.String(),
                        OprationRole = c.String(),
                        OprationGrade = c.String(),
                    })
                .PrimaryKey(t => t.TempOprationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DividingPlanItems", "DividingPlanHeaderID", "dbo.DividingPlanHeaders");
            DropForeignKey("dbo.OprationBarcodes", "BundleDetailsID", "dbo.BundleDetails");
            DropForeignKey("dbo.BundleDetails", "BundleHeaderID", "dbo.BundleHeaders");
            DropForeignKey("dbo.Workstations", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Users", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Promotions", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.PastEmployeements", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Racks", "WerehouseID", "dbo.Werehouses");
            DropForeignKey("dbo.Bins", "RackID", "dbo.Racks");
            DropForeignKey("dbo.Werehouses", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.RunningNoes", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.OperationPools", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Companies", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.Employees", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.POes", "SupplierMasterID", "dbo.SupplierMasters");
            DropForeignKey("dbo.SupplierMasters", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.PoItems", "POID", "dbo.POes");
            DropForeignKey("dbo.GRNs", "POID", "dbo.POes");
            DropForeignKey("dbo.POes", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.PoItems", "ItemsID", "dbo.Items");
            DropForeignKey("dbo.Items", "CustomeFieldSetupID", "dbo.CustomeFieldSetups");
            DropForeignKey("dbo.CustomeFieldSetups", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.WorkflowSetups", "Workstation_WorkstationID", "dbo.Workstations");
            DropForeignKey("dbo.WorkflowSetups", "WorkflowID", "dbo.Workflows");
            DropForeignKey("dbo.Styles", "WorkflowID", "dbo.Workflows");
            DropForeignKey("dbo.StyleOperations", "PartDefinition_PartDefinitionID", "dbo.PartDefinitions");
            DropForeignKey("dbo.PartDefinitions", "SketchDefinitionID", "dbo.SketchDefinitions");
            DropForeignKey("dbo.SketchDefinitions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.PurchaseOrderHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.PurchaseOrderItems", "PurchaseOrderHeaderID", "dbo.PurchaseOrderHeaders");
            DropForeignKey("dbo.FabricDetails", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.DividingPlanHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.CuttingHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.CuttingItems", "CuttingHeaderID", "dbo.CuttingHeaders");
            DropForeignKey("dbo.BundleHeaders", "CuttingItemID", "dbo.CuttingItems");
            DropForeignKey("dbo.Styles", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Styles", "BuyerID", "dbo.Buyers");
            DropForeignKey("dbo.Buyers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Awards", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.DividingPlanItems", new[] { "DividingPlanHeaderID" });
            DropIndex("dbo.OprationBarcodes", new[] { "BundleDetailsID" });
            DropIndex("dbo.BundleDetails", new[] { "BundleHeaderID" });
            DropIndex("dbo.Users", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.Promotions", new[] { "EmployeeID" });
            DropIndex("dbo.PastEmployeements", new[] { "EmployeeID" });
            DropIndex("dbo.Bins", new[] { "RackID" });
            DropIndex("dbo.Racks", new[] { "WerehouseID" });
            DropIndex("dbo.Werehouses", new[] { "CompanyID" });
            DropIndex("dbo.RunningNoes", new[] { "CompanyID" });
            DropIndex("dbo.OperationPools", new[] { "CompanyID" });
            DropIndex("dbo.SupplierMasters", new[] { "CompanyID" });
            DropIndex("dbo.GRNs", new[] { "POID" });
            DropIndex("dbo.POes", new[] { "CompanyID" });
            DropIndex("dbo.POes", new[] { "SupplierMasterID" });
            DropIndex("dbo.PoItems", new[] { "POID" });
            DropIndex("dbo.PoItems", new[] { "ItemsID" });
            DropIndex("dbo.Items", new[] { "CustomeFieldSetupID" });
            DropIndex("dbo.CustomeFieldSetups", new[] { "CompanyID" });
            DropIndex("dbo.Workstations", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.WorkflowSetups", new[] { "Workstation_WorkstationID" });
            DropIndex("dbo.WorkflowSetups", new[] { "WorkflowID" });
            DropIndex("dbo.StyleOperations", new[] { "PartDefinition_PartDefinitionID" });
            DropIndex("dbo.PartDefinitions", new[] { "SketchDefinitionID" });
            DropIndex("dbo.SketchDefinitions", new[] { "StyleID" });
            DropIndex("dbo.PurchaseOrderItems", new[] { "PurchaseOrderHeaderID" });
            DropIndex("dbo.PurchaseOrderHeaders", new[] { "StyleID" });
            DropIndex("dbo.FabricDetails", new[] { "StyleID" });
            DropIndex("dbo.DividingPlanHeaders", new[] { "StyleID" });
            DropIndex("dbo.BundleHeaders", new[] { "CuttingItemID" });
            DropIndex("dbo.CuttingItems", new[] { "CuttingHeaderID" });
            DropIndex("dbo.CuttingHeaders", new[] { "StyleID" });
            DropIndex("dbo.Styles", new[] { "WorkflowID" });
            DropIndex("dbo.Styles", new[] { "BuyerID" });
            DropIndex("dbo.Styles", new[] { "CompanyID" });
            DropIndex("dbo.Buyers", new[] { "CompanyID" });
            DropIndex("dbo.Companies", new[] { "GroupID" });
            DropIndex("dbo.Employees", new[] { "CompanyID" });
            DropIndex("dbo.Awards", new[] { "EmployeeID" });
            DropTable("dbo.TempOprations");
            DropTable("dbo.DividingPlanTemps");
            DropTable("dbo.DividingPlanItems");
            DropTable("dbo.OprationBarcodes");
            DropTable("dbo.BundleDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Promotions");
            DropTable("dbo.PastEmployeements");
            DropTable("dbo.Bins");
            DropTable("dbo.Racks");
            DropTable("dbo.Werehouses");
            DropTable("dbo.RunningNoes");
            DropTable("dbo.OperationPools");
            DropTable("dbo.Groups");
            DropTable("dbo.SupplierMasters");
            DropTable("dbo.GRNs");
            DropTable("dbo.POes");
            DropTable("dbo.PoItems");
            DropTable("dbo.Items");
            DropTable("dbo.CustomeFieldSetups");
            DropTable("dbo.Workstations");
            DropTable("dbo.WorkflowSetups");
            DropTable("dbo.Workflows");
            DropTable("dbo.StyleOperations");
            DropTable("dbo.PartDefinitions");
            DropTable("dbo.SketchDefinitions");
            DropTable("dbo.PurchaseOrderItems");
            DropTable("dbo.PurchaseOrderHeaders");
            DropTable("dbo.FabricDetails");
            DropTable("dbo.DividingPlanHeaders");
            DropTable("dbo.BundleHeaders");
            DropTable("dbo.CuttingItems");
            DropTable("dbo.CuttingHeaders");
            DropTable("dbo.Styles");
            DropTable("dbo.Buyers");
            DropTable("dbo.Companies");
            DropTable("dbo.Employees");
            DropTable("dbo.Awards");
        }
    }
}
