namespace EFTesting.Reports
{
    partial class rptCutS
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
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLineNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldColor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSize = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPcs1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 23.95833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 45F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrPivotGrid1.Appearance.TotalCell.BackColor = System.Drawing.Color.Gainsboro;
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrPivotGrid1.DataSource = this.bindingSource2;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldDate,
            this.fieldLineNo,
            this.fieldColor,
            this.fieldSize,
            this.fieldStyleNo,
            this.fieldPcs1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 144.1667F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1076.5F, 118.125F);
            this.xrPivotGrid1.AfterPrint += new System.EventHandler(this.xrPivotGrid1_AfterPrint);
            // 
            // fieldDate
            // 
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate.AreaIndex = 2;
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.ValueFormat.FormatString = "d";
            this.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldLineNo
            // 
            this.fieldLineNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLineNo.AreaIndex = 1;
            this.fieldLineNo.FieldName = "LineNo";
            this.fieldLineNo.Name = "fieldLineNo";
            this.fieldLineNo.Width = 75;
            // 
            // fieldColor
            // 
            this.fieldColor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldColor.AreaIndex = 3;
            this.fieldColor.FieldName = "Color";
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Width = 75;
            // 
            // fieldSize
            // 
            this.fieldSize.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSize.AreaIndex = 0;
            this.fieldSize.FieldName = "Size";
            this.fieldSize.Name = "fieldSize";
            this.fieldSize.Width = 71;
            // 
            // fieldStyleNo
            // 
            this.fieldStyleNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo.AreaIndex = 0;
            this.fieldStyleNo.FieldName = "StyleNo";
            this.fieldStyleNo.Name = "fieldStyleNo";
            // 
            // fieldPcs1
            // 
            this.fieldPcs1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPcs1.AreaIndex = 0;
            this.fieldPcs1.FieldName = "Pcs";
            this.fieldPcs1.Name = "fieldPcs1";
            this.fieldPcs1.Width = 50;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPageInfo1,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 286.875F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 59.04168F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(462.5F, 32.375F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "VOGUE TEX WELIGAMA";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(540.625F, 49.04167F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "CUTTING SUMMARY REPORT ";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 91.41666F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(261.4583F, 23F);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(EFTesting.ViewModel.CutReport);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 114.4167F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1076.5F, 14.66665F);
            // 
            // rptCutS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(30, 26, 45, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "14.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptCutS_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLineNo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldColor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSize;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPcs1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
    }
}
