namespace EFTesting.Reports
{
    partial class rptPoDiliveries
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
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fieldColor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCutQty = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPcs = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPoNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSize = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 52F;
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
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPageInfo1,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 341.6667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "{0:d/M/yyyy h:mm tt}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 140.625F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(326.0417F, 23F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 117.625F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel3.Text = "FOB DATE VS CUT QTY ORDERED BY PO";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 82.04168F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel4.Text = "Tele - 0412240451 / 0412240452          Email - Info@voguetex.com";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.04169F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel2.Text = "VOGUE TEX WELIGAMA";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(673.9583F, 37.58334F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "CUTTING SUMMARY VS FOB DATE";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldColor,
            this.fieldCutQty,
            this.fieldDate,
            this.fieldPcs,
            this.fieldPoNo,
            this.fieldSize,
            this.fieldStyleNo});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 194.7916F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1060F, 136.875F);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.ViewModel.PoDeliveries);
            // 
            // fieldColor
            // 
            this.fieldColor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldColor.AreaIndex = 3;
            this.fieldColor.FieldName = "Color";
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Width = 50;
            // 
            // fieldCutQty
            // 
            this.fieldCutQty.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCutQty.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCutQty.AreaIndex = 1;
            this.fieldCutQty.FieldName = "CutQty";
            this.fieldCutQty.Name = "fieldCutQty";
            this.fieldCutQty.Width = 60;
            // 
            // fieldDate
            // 
            this.fieldDate.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.Caption = "FOB Date";
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.ValueFormat.FormatString = "d";
            this.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldPcs
            // 
            this.fieldPcs.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldPcs.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldPcs.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPcs.AreaIndex = 0;
            this.fieldPcs.Caption = "O Qty";
            this.fieldPcs.FieldName = "Pcs";
            this.fieldPcs.Name = "fieldPcs";
            this.fieldPcs.Width = 60;
            // 
            // fieldPoNo
            // 
            this.fieldPoNo.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldPoNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPoNo.AreaIndex = 2;
            this.fieldPoNo.FieldName = "PoNo";
            this.fieldPoNo.Name = "fieldPoNo";
            this.fieldPoNo.Width = 60;
            // 
            // fieldSize
            // 
            this.fieldSize.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSize.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSize.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSize.AreaIndex = 0;
            this.fieldSize.FieldName = "Size";
            this.fieldSize.Name = "fieldSize";
            this.fieldSize.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            this.fieldSize.Width = 45;
            // 
            // fieldStyleNo
            // 
            this.fieldStyleNo.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldStyleNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo.AreaIndex = 1;
            this.fieldStyleNo.FieldName = "StyleNo";
            this.fieldStyleNo.Name = "fieldStyleNo";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 36.04169F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(548.9583F, 23F);
            // 
            // rptPoDiliveries
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(64, 35, 52, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "14.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptPoDiliveries_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldColor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCutQty;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPcs;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPoNo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSize;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
    }
}
