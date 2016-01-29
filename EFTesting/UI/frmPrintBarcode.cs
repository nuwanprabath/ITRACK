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

namespace EFTesting.UI
{
    public partial class frmPrintBarcode : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintBarcode()
        {
            InitializeComponent();
        }

        public int CutNo { get; set; }
        public frmPrintBarcode(int _CutNo) {

            this.CutNo = _CutNo;
            InitializeComponent();
        }

        private void frmPrintBarcode_Load(object sender, EventArgs e)
        {
            RptbundleTicket report = new RptbundleTicket();
            OprationBarcodeList list = new OprationBarcodeList();
            report.SetDataSource(list.BarcodeList(15));

            this.crystalReportViewer1.ReportSource = report;
        }
    }
}