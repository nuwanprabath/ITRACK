namespace EFTesting.Reports
{
    partial class rptDailiyProByHour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDailiyProByHour));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldStyleNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPoNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldHourNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLineNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldColor1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSize1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldType1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 26.04167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 26.12502F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 38.62502F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(167.7083F, 90.75001F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(192.2917F, 96.58335F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(457.2917F, 32.79167F);
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Industrial Estate,Weligama \r\nUdukawa ";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel62
            // 
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(192.2917F, 73.58337F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(368.75F, 22.99999F);
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            this.xrLabel62.Text = "Vogue Tex Weligama ";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(192.2917F, 38.62502F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(500.125F, 34.95834F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "HOURLY PRODUCTION REPORT";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldStyleNo1,
            this.fieldPoNo1,
            this.fieldDate1,
            this.fieldHourNo1,
            this.fieldLineNo1,
            this.fieldColor1,
            this.fieldSize1,
            this.fieldType1,
            this.fieldQty1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 170.2083F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1003.792F, 147.9167F);
            // 
            // fieldStyleNo1
            // 
            this.fieldStyleNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo1.AreaIndex = 0;
            this.fieldStyleNo1.Caption = "Style No";
            this.fieldStyleNo1.FieldName = "StyleNo";
            this.fieldStyleNo1.Name = "fieldStyleNo1";
            // 
            // fieldPoNo1
            // 
            this.fieldPoNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPoNo1.AreaIndex = 1;
            this.fieldPoNo1.Caption = "Po No";
            this.fieldPoNo1.FieldName = "PoNo";
            this.fieldPoNo1.Name = "fieldPoNo1";
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate1.AreaIndex = 2;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.Name = "fieldDate1";
            // 
            // fieldHourNo1
            // 
            this.fieldHourNo1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldHourNo1.AreaIndex = 0;
            this.fieldHourNo1.Caption = "Hour No";
            this.fieldHourNo1.FieldName = "HourNo";
            this.fieldHourNo1.Name = "fieldHourNo1";
            this.fieldHourNo1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldHourNo1.Width = 50;
            // 
            // fieldLineNo1
            // 
            this.fieldLineNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLineNo1.AreaIndex = 3;
            this.fieldLineNo1.Caption = "Line No";
            this.fieldLineNo1.FieldName = "LineNo";
            this.fieldLineNo1.Name = "fieldLineNo1";
            // 
            // fieldColor1
            // 
            this.fieldColor1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldColor1.AreaIndex = 4;
            this.fieldColor1.Caption = "Color";
            this.fieldColor1.FieldName = "Color";
            this.fieldColor1.Name = "fieldColor1";
            // 
            // fieldSize1
            // 
            this.fieldSize1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSize1.AreaIndex = 5;
            this.fieldSize1.Caption = "Size";
            this.fieldSize1.FieldName = "Size";
            this.fieldSize1.Name = "fieldSize1";
            // 
            // fieldType1
            // 
            this.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldType1.AreaIndex = 1;
            this.fieldType1.Caption = "Type";
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            this.fieldType1.Width = 50;
            // 
            // fieldQty1
            // 
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 0;
            this.fieldQty1.Caption = "Qty";
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
            this.fieldQty1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
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
            this.xrPictureBox1,
            this.xrLabel62,
            this.xrLabel9,
            this.xrLabel4});
            this.ReportHeader.HeightF = 328.125F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.Reports.dailyProductionByHour);
            // 
            // rptDailiyProByHour
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(33, 33, 26, 100);
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
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPoNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHourNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLineNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldColor1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSize1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldType1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQty1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel62;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
