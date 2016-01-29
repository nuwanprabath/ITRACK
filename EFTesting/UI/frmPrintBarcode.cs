using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EFTesting.Reports.Report;
using EFTesting.Reports;
using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmPrintBarcode : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintBarcode()
        {
            InitializeComponent();
        }

        public int CutNo { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public int Options { get; set; }

        public frmPrintBarcode pBarocde { get; set; }

        public frmPrintBarcode(frmPrintBarcode _barcode) {
            try 
            {
                InitializeComponent();
                splashScreenManager1.ShowWaitForm();
                this.pBarocde = _barcode;
                sBundleTicket report = new sBundleTicket();
                rptBarcodeList s = new rptBarcodeList();
                OprationBarcodeList list = new OprationBarcodeList();

               //report.SetDataSource(list.StickerBarcodeList(pBarocde.Options, pBarocde.CutNo, pBarocde.From, pBarocde.To));

               //this.crystalReportViewer1.ReportSource = report;

                BarcodeLabel lbl = new BarcodeLabel();
                lbl.DataSource = list.StickerBarcodeList(pBarocde.Options, pBarocde.CutNo, pBarocde.From, pBarocde.To);
                ReportPrintTool tool = new ReportPrintTool(lbl);
                tool.ShowPreview();


                splashScreenManager1.CloseWaitForm();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.Message);
            }
           
          
          
        }

        public frmPrintBarcode(int _option,int _cutId,int _from , int _to)
        {

            this.CutNo = _cutId;
            this.From = _from;
            this.To = _to;
            this.Options = _option;
            InitializeComponent();
        }

        private void frmPrintBarcode_Load(object sender, EventArgs e)
        {

             
        }
    }
}