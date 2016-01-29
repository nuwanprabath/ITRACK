namespace EFTesting.Reports
{
    partial class rptBarcodeList
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Barcode1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Barcode2 = new DevExpress.XtraReports.UI.XRLabel();
            this.BundleNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.OprationNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line4 = new DevExpress.XtraReports.UI.XRLine();
            this.NoOfPts1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text5 = new DevExpress.XtraReports.UI.XRLabel();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupNamePartName1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupNameBundleNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text1 = new DevExpress.XtraReports.UI.XRLabel();
            this.StyleNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line2 = new DevExpress.XtraReports.UI.XRLine();
            this.Size1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text6 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Barcode1,
            this.Barcode2,
            this.BundleNo1,
            this.OprationNo1,
            this.Text4,
            this.Line4,
            this.NoOfPts1,
            this.Text5});
            this.Detail.HeightF = 58F;
            this.Detail.Name = "Detail";
            // 
            // Barcode1
            // 
            this.Barcode1.BackColor = System.Drawing.Color.White;
            this.Barcode1.BorderColor = System.Drawing.Color.Black;
            this.Barcode1.CanGrow = false;
            this.Barcode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.Barcode")});
            this.Barcode1.Font = new System.Drawing.Font("Code39AzaleaNarrow3", 17F);
            this.Barcode1.ForeColor = System.Drawing.Color.Black;
            this.Barcode1.LocationFloat = new DevExpress.Utils.PointFloat(4F, 16F);
            this.Barcode1.Name = "Barcode1";
            this.Barcode1.SizeF = new System.Drawing.SizeF(89F, 28F);
            this.Barcode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Barcode2
            // 
            this.Barcode2.BackColor = System.Drawing.Color.White;
            this.Barcode2.BorderColor = System.Drawing.Color.Black;
            this.Barcode2.CanGrow = false;
            this.Barcode2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.Barcode")});
            this.Barcode2.Font = new System.Drawing.Font("Arial", 7F);
            this.Barcode2.ForeColor = System.Drawing.Color.Black;
            this.Barcode2.LocationFloat = new DevExpress.Utils.PointFloat(41F, 2F);
            this.Barcode2.Name = "Barcode2";
            this.Barcode2.SizeF = new System.Drawing.SizeF(54F, 9F);
            this.Barcode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // BundleNo1
            // 
            this.BundleNo1.BackColor = System.Drawing.Color.White;
            this.BundleNo1.BorderColor = System.Drawing.Color.Black;
            this.BundleNo1.CanGrow = false;
            this.BundleNo1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.BundleNo")});
            this.BundleNo1.Font = new System.Drawing.Font("Arial", 7F);
            this.BundleNo1.ForeColor = System.Drawing.Color.Black;
            this.BundleNo1.LocationFloat = new DevExpress.Utils.PointFloat(27F, 38F);
            this.BundleNo1.Name = "BundleNo1";
            this.BundleNo1.SizeF = new System.Drawing.SizeF(20F, 15F);
            this.BundleNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // OprationNo1
            // 
            this.OprationNo1.BackColor = System.Drawing.Color.White;
            this.OprationNo1.BorderColor = System.Drawing.Color.Black;
            this.OprationNo1.CanGrow = false;
            this.OprationNo1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.OprationNo")});
            this.OprationNo1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.OprationNo1.ForeColor = System.Drawing.Color.Black;
            this.OprationNo1.LocationFloat = new DevExpress.Utils.PointFloat(56F, 38F);
            this.OprationNo1.Name = "OprationNo1";
            this.OprationNo1.SizeF = new System.Drawing.SizeF(41F, 15F);
            this.OprationNo1.StylePriority.UseFont = false;
            this.OprationNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text4
            // 
            this.Text4.BackColor = System.Drawing.Color.White;
            this.Text4.BorderColor = System.Drawing.Color.Black;
            this.Text4.CanGrow = false;
            this.Text4.Font = new System.Drawing.Font("Arial", 7F);
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.LocationFloat = new DevExpress.Utils.PointFloat(4F, 39F);
            this.Text4.Name = "Text4";
            this.Text4.SizeF = new System.Drawing.SizeF(26F, 15F);
            this.Text4.Text = "BNO";
            this.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.White;
            this.Line4.BorderColor = System.Drawing.Color.Black;
            this.Line4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Line4.ForeColor = System.Drawing.Color.Black;
            this.Line4.LocationFloat = new DevExpress.Utils.PointFloat(4F, 56F);
            this.Line4.Name = "Line4";
            this.Line4.SizeF = new System.Drawing.SizeF(795F, 2F);
            // 
            // NoOfPts1
            // 
            this.NoOfPts1.BackColor = System.Drawing.Color.White;
            this.NoOfPts1.BorderColor = System.Drawing.Color.Black;
            this.NoOfPts1.CanGrow = false;
            this.NoOfPts1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.NoOfPts")});
            this.NoOfPts1.Font = new System.Drawing.Font("Arial", 7F);
            this.NoOfPts1.ForeColor = System.Drawing.Color.Black;
            this.NoOfPts1.LocationFloat = new DevExpress.Utils.PointFloat(28F, 2F);
            this.NoOfPts1.Name = "NoOfPts1";
            this.NoOfPts1.SizeF = new System.Drawing.SizeF(13F, 12F);
            this.NoOfPts1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text5
            // 
            this.Text5.BackColor = System.Drawing.Color.White;
            this.Text5.BorderColor = System.Drawing.Color.Black;
            this.Text5.CanGrow = false;
            this.Text5.Font = new System.Drawing.Font("Arial", 10F);
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
            this.Text5.Name = "Text5";
            this.Text5.SizeF = new System.Drawing.SizeF(21F, 16F);
            this.Text5.Text = "pcs";
            this.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "barcodeList", new System.Data.Common.DataColumnMapping[0])});
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.CommandText = "SELECT * FROM barcodeList";
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BundleTicket";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("BundleNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.GroupNamePartName1,
            this.Text3,
            this.GroupNameBundleNo1,
            this.Text1,
            this.StyleNo1,
            this.Line2,
            this.Size1,
            this.Text6});
            this.GroupHeader2.Expanded = false;
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PartName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.HeightF = 46F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupNamePartName1
            // 
            this.GroupNamePartName1.BackColor = System.Drawing.Color.White;
            this.GroupNamePartName1.BorderColor = System.Drawing.Color.Black;
            this.GroupNamePartName1.CanGrow = false;
            this.GroupNamePartName1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.PartName")});
            this.GroupNamePartName1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GroupNamePartName1.ForeColor = System.Drawing.Color.Black;
            this.GroupNamePartName1.LocationFloat = new DevExpress.Utils.PointFloat(30F, 13F);
            this.GroupNamePartName1.Name = "GroupNamePartName1";
            this.GroupNamePartName1.SizeF = new System.Drawing.SizeF(177F, 22F);
            this.GroupNamePartName1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.White;
            this.Text3.BorderColor = System.Drawing.Color.Black;
            this.Text3.CanGrow = false;
            this.Text3.Font = new System.Drawing.Font("Arial", 9F);
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.LocationFloat = new DevExpress.Utils.PointFloat(404F, 11F);
            this.Text3.Name = "Text3";
            this.Text3.SizeF = new System.Drawing.SizeF(83F, 15F);
            this.Text3.Text = "BUNDLE NO\t\t";
            this.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupNameBundleNo1
            // 
            this.GroupNameBundleNo1.BackColor = System.Drawing.Color.White;
            this.GroupNameBundleNo1.BorderColor = System.Drawing.Color.Black;
            this.GroupNameBundleNo1.CanGrow = false;
            this.GroupNameBundleNo1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.BundleNo")});
            this.GroupNameBundleNo1.Font = new System.Drawing.Font("Arial", 8F);
            this.GroupNameBundleNo1.ForeColor = System.Drawing.Color.Black;
            this.GroupNameBundleNo1.LocationFloat = new DevExpress.Utils.PointFloat(494F, 11F);
            this.GroupNameBundleNo1.Name = "GroupNameBundleNo1";
            this.GroupNameBundleNo1.SizeF = new System.Drawing.SizeF(133F, 15F);
            this.GroupNameBundleNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.White;
            this.Text1.BorderColor = System.Drawing.Color.Black;
            this.Text1.CanGrow = false;
            this.Text1.Font = new System.Drawing.Font("Arial", 9F);
            this.Text1.ForeColor = System.Drawing.Color.Black;
            this.Text1.LocationFloat = new DevExpress.Utils.PointFloat(221F, 12F);
            this.Text1.Name = "Text1";
            this.Text1.SizeF = new System.Drawing.SizeF(69F, 15F);
            this.Text1.Text = "STYLE NO\t\t";
            this.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // StyleNo1
            // 
            this.StyleNo1.BackColor = System.Drawing.Color.White;
            this.StyleNo1.BorderColor = System.Drawing.Color.Black;
            this.StyleNo1.CanGrow = false;
            this.StyleNo1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.StyleNo")});
            this.StyleNo1.Font = new System.Drawing.Font("Arial", 8F);
            this.StyleNo1.ForeColor = System.Drawing.Color.Black;
            this.StyleNo1.LocationFloat = new DevExpress.Utils.PointFloat(305F, 12F);
            this.StyleNo1.Name = "StyleNo1";
            this.StyleNo1.SizeF = new System.Drawing.SizeF(88F, 15F);
            this.StyleNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.White;
            this.Line2.BorderColor = System.Drawing.Color.Black;
            this.Line2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Line2.ForeColor = System.Drawing.Color.Black;
            this.Line2.LocationFloat = new DevExpress.Utils.PointFloat(1F, 44F);
            this.Line2.Name = "Line2";
            this.Line2.SizeF = new System.Drawing.SizeF(795F, 2F);
            // 
            // Size1
            // 
            this.Size1.BackColor = System.Drawing.Color.White;
            this.Size1.BorderColor = System.Drawing.Color.Black;
            this.Size1.CanGrow = false;
            this.Size1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "barcodeList.Size")});
            this.Size1.Font = new System.Drawing.Font("Arial", 10F);
            this.Size1.ForeColor = System.Drawing.Color.Black;
            this.Size1.LocationFloat = new DevExpress.Utils.PointFloat(695F, 10F);
            this.Size1.Name = "Size1";
            this.Size1.SizeF = new System.Drawing.SizeF(77F, 15F);
            this.Size1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text6
            // 
            this.Text6.BackColor = System.Drawing.Color.White;
            this.Text6.BorderColor = System.Drawing.Color.Black;
            this.Text6.CanGrow = false;
            this.Text6.Font = new System.Drawing.Font("Arial", 9F);
            this.Text6.ForeColor = System.Drawing.Color.Black;
            this.Text6.LocationFloat = new DevExpress.Utils.PointFloat(647F, 10F);
            this.Text6.Name = "Text6";
            this.Text6.SizeF = new System.Drawing.SizeF(39F, 15F);
            this.Text6.Text = "SIZE\t";
            this.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.HeightF = 15F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 4F;
            this.GroupFooter2.Level = 1;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Expanded = false;
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 41F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 41F;
            this.PageFooter.Name = "PageFooter";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 40F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 16F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // rptBarcodeList
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupFooter2,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.DataAdapter = this.oleDbDataAdapter1;
            this.Margins = new System.Drawing.Printing.Margins(35, 16, 40, 16);
            this.PageHeight = 1099;
            this.PageWidth = 849;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel Barcode1;
        private DevExpress.XtraReports.UI.XRLabel Barcode2;
        private DevExpress.XtraReports.UI.XRLabel BundleNo1;
        private DevExpress.XtraReports.UI.XRLabel OprationNo1;
        private DevExpress.XtraReports.UI.XRLabel Text4;
        private DevExpress.XtraReports.UI.XRLine Line4;
        private DevExpress.XtraReports.UI.XRLabel NoOfPts1;
        private DevExpress.XtraReports.UI.XRLabel Text5;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel GroupNamePartName1;
        private DevExpress.XtraReports.UI.XRLabel Text3;
        private DevExpress.XtraReports.UI.XRLabel GroupNameBundleNo1;
        private DevExpress.XtraReports.UI.XRLabel Text1;
        private DevExpress.XtraReports.UI.XRLabel StyleNo1;
        private DevExpress.XtraReports.UI.XRLine Line2;
        private DevExpress.XtraReports.UI.XRLabel Size1;
        private DevExpress.XtraReports.UI.XRLabel Text6;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;

    }
}
