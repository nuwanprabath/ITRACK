namespace EFTesting.Reports
{
    partial class HourlyProductionByOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyProductionByOperation));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldWorkstationNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEmployeeID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldOperationNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldOperationName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldHourNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEarnSAH1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEfficiency = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPCS1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 15.62497F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldWorkstationNo1,
            this.fieldEmployeeID1,
            this.fieldName1,
            this.fieldOperationNo1,
            this.fieldOperationName1,
            this.fieldHourNo1,
            this.fieldEarnSAH1,
            this.fieldEfficiency,
            this.fieldPCS1,
            this.fieldDate,
            this.fieldStyleNo});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 90.20834F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(864.25F, 145.8333F);
            // 
            // fieldWorkstationNo1
            // 
            this.fieldWorkstationNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWorkstationNo1.AreaIndex = 2;
            this.fieldWorkstationNo1.Caption = "W No";
            this.fieldWorkstationNo1.FieldName = "WorkstationNo";
            this.fieldWorkstationNo1.Name = "fieldWorkstationNo1";
            this.fieldWorkstationNo1.Width = 60;
            // 
            // fieldEmployeeID1
            // 
            this.fieldEmployeeID1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEmployeeID1.AreaIndex = 3;
            this.fieldEmployeeID1.Caption = "Employee ID";
            this.fieldEmployeeID1.FieldName = "EmployeeID";
            this.fieldEmployeeID1.Name = "fieldEmployeeID1";
            // 
            // fieldName1
            // 
            this.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldName1.AreaIndex = 4;
            this.fieldName1.Caption = "Name";
            this.fieldName1.FieldName = "Name";
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldOperationNo1
            // 
            this.fieldOperationNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOperationNo1.AreaIndex = 5;
            this.fieldOperationNo1.Caption = "Operation No";
            this.fieldOperationNo1.FieldName = "OperationNo";
            this.fieldOperationNo1.Name = "fieldOperationNo1";
            // 
            // fieldOperationName1
            // 
            this.fieldOperationName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOperationName1.AreaIndex = 6;
            this.fieldOperationName1.Caption = "Operation Name";
            this.fieldOperationName1.FieldName = "OperationName";
            this.fieldOperationName1.Name = "fieldOperationName1";
            this.fieldOperationName1.Width = 200;
            // 
            // fieldHourNo1
            // 
            this.fieldHourNo1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldHourNo1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldHourNo1.AreaIndex = 0;
            this.fieldHourNo1.Caption = "Hour No";
            this.fieldHourNo1.FieldName = "HourNo";
            this.fieldHourNo1.Name = "fieldHourNo1";
            this.fieldHourNo1.Width = 40;
            // 
            // fieldEarnSAH1
            // 
            this.fieldEarnSAH1.AreaIndex = 0;
            this.fieldEarnSAH1.Caption = "Earn SAH";
            this.fieldEarnSAH1.FieldName = "EarnSAH";
            this.fieldEarnSAH1.Name = "fieldEarnSAH1";
            // 
            // fieldEfficiency
            // 
            this.fieldEfficiency.AreaIndex = 1;
            this.fieldEfficiency.Caption = "EFF";
            this.fieldEfficiency.CellFormat.FormatString = "{}%";
            this.fieldEfficiency.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldEfficiency.FieldName = "Efficiency";
            this.fieldEfficiency.Name = "fieldEfficiency";
            this.fieldEfficiency.ValueFormat.FormatString = "{}%";
            this.fieldEfficiency.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldEfficiency.Width = 40;
            // 
            // fieldPCS1
            // 
            this.fieldPCS1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldPCS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPCS1.AreaIndex = 0;
            this.fieldPCS1.Caption = "PCS";
            this.fieldPCS1.FieldName = "PCS";
            this.fieldPCS1.Name = "fieldPCS1";
            this.fieldPCS1.Width = 40;
            // 
            // fieldDate
            // 
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate.AreaIndex = 1;
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            // 
            // fieldStyleNo
            // 
            this.fieldStyleNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo.AreaIndex = 0;
            this.fieldStyleNo.FieldName = "StyleNo";
            this.fieldStyleNo.Name = "fieldStyleNo";
            // 
            // TopMargin
            // 
            this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.TopMargin.HeightF = 26.4583F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseFont = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(143.75F, 39.375F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(579.1667F, 22.08333F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "HOURLY INDIVIDUAL PRODUCTION REPORT ";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(143.75F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(579.1667F, 29.375F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "HOURLY INDIVIDUAL PRODUCTION REPORT ";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPivotGrid1,
            this.xrLabel1,
            this.xrLabel2});
            this.ReportHeader.HeightF = 265.625F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(119.7917F, 61.45834F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.Reports.HourlyIndividualProduction);
            // 
            // HourlyProductionByOperation
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(46, 11, 26, 100);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldWorkstationNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEmployeeID1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOperationNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOperationName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHourNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEarnSAH1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEfficiency;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPCS1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
