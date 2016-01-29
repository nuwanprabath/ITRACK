namespace EFTesting.Reports
{
    partial class rptHProduction
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fieldStyleNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldOperationNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldOperationName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEmployeeId1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEmployeeName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLineNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldHour1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPcs1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23.875F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 93.50002F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel3.Text = "Tele - 0412240451 / 0412240452          Email - Info@voguetex.com";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 23.54167F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(651.0417F, 46.95834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "HOURLY INDIVIDUAL PRODUCTION REPORT";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 70.50002F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel2.Text = "VOGUE TEX WELIGAMA";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldStyleNo1,
            this.fieldDate1,
            this.fieldOperationNo1,
            this.fieldOperationName1,
            this.fieldEmployeeId1,
            this.fieldEmployeeName1,
            this.fieldLineNo1,
            this.fieldHour1,
            this.fieldPcs1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 145.4167F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1068F, 123.75F);
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
            this.xrPivotGrid1,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3});
            this.ReportHeader.HeightF = 291.6667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // fieldStyleNo1
            // 
            this.fieldStyleNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo1.AreaIndex = 0;
            this.fieldStyleNo1.Caption = "Style No";
            this.fieldStyleNo1.FieldName = "StyleNo";
            this.fieldStyleNo1.Name = "fieldStyleNo1";
            this.fieldStyleNo1.Width = 60;
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate1.AreaIndex = 1;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.Name = "fieldDate1";
            this.fieldDate1.ValueFormat.FormatString = "d";
            this.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldDate1.Width = 60;
            // 
            // fieldOperationNo1
            // 
            this.fieldOperationNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOperationNo1.AreaIndex = 3;
            this.fieldOperationNo1.Caption = "Operation No";
            this.fieldOperationNo1.FieldName = "OperationNo";
            this.fieldOperationNo1.Name = "fieldOperationNo1";
            this.fieldOperationNo1.Width = 75;
            // 
            // fieldOperationName1
            // 
            this.fieldOperationName1.AreaIndex = 0;
            this.fieldOperationName1.Caption = "Operation Name";
            this.fieldOperationName1.FieldName = "OperationName";
            this.fieldOperationName1.Name = "fieldOperationName1";
            // 
            // fieldEmployeeId1
            // 
            this.fieldEmployeeId1.AreaIndex = 1;
            this.fieldEmployeeId1.Caption = "Employee Id";
            this.fieldEmployeeId1.FieldName = "EmployeeId";
            this.fieldEmployeeId1.Name = "fieldEmployeeId1";
            // 
            // fieldEmployeeName1
            // 
            this.fieldEmployeeName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEmployeeName1.AreaIndex = 4;
            this.fieldEmployeeName1.Caption = "Employee Name";
            this.fieldEmployeeName1.FieldName = "EmployeeName";
            this.fieldEmployeeName1.Name = "fieldEmployeeName1";
            // 
            // fieldLineNo1
            // 
            this.fieldLineNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLineNo1.AreaIndex = 2;
            this.fieldLineNo1.Caption = "Line No";
            this.fieldLineNo1.FieldName = "LineNo";
            this.fieldLineNo1.Name = "fieldLineNo1";
            this.fieldLineNo1.Width = 60;
            // 
            // fieldHour1
            // 
            this.fieldHour1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldHour1.AreaIndex = 0;
            this.fieldHour1.Caption = "Hour";
            this.fieldHour1.FieldName = "Hour";
            this.fieldHour1.Name = "fieldHour1";
            this.fieldHour1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            this.fieldHour1.Width = 60;
            // 
            // fieldPcs1
            // 
            this.fieldPcs1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPcs1.AreaIndex = 0;
            this.fieldPcs1.Caption = "Pcs";
            this.fieldPcs1.FieldName = "Pcs";
            this.fieldPcs1.Name = "fieldPcs1";
            this.fieldPcs1.Width = 45;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.ViewModel.HourlyProductionList);
            // 
            // rptHProduction
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(14, 18, 24, 100);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "14.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptHProduction_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOperationNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOperationName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEmployeeId1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEmployeeName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLineNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHour1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPcs1;
    }
}
