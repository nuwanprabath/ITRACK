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
using ITRACK.models;
using EFTesting.ViewModel;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.Office.Utils;

namespace EFTesting.UI
{
    public partial class frmPoDeliveriesDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmPoDeliveriesDialog()
        {
            InitializeComponent();
        }


        List<PoDeliveries> lstPo = new List<PoDeliveries>();
        private List<PoDeliveries> GetReportData(DateTime _fromDate,DateTime _toDate,string _styleNo,int option)
        {

            try {
                GenaricRepository<PurchaseOrderItems> _PoRepo = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
                lstPo.Clear();
                if (option == 1)
                {
                    foreach (var item in _PoRepo.GetAll().ToList().Where(x=>x.PurchaseOrderHeader.StyleID==_styleNo))
                    {

                        GenaricRepository<CuttingItem> _CutRepo = new GenaricRepository<CuttingItem>(new ItrackContext());

                        var cut = from x in _CutRepo.GetAll()
                                  where x.Size == item.Size && x.Color == item.Color && x.PoNo == item.PurchaseOrderID
                                  select x;

                        int cutQty = 0;
                        if (cut.Count() > 0)
                        {

                            foreach (var i in cut)
                            {

                                cutQty = i.NoOfItem + cutQty;
                            }


                        }


                    // add item to list of POs
                        lstPo.Add(new PoDeliveries
                        {
                            Date = item.PurchaseOrderHeader.EndDate,
                            PoNo = item.PurchaseOrderID,
                            StyleNo = item.PurchaseOrderHeader.StyleID,
                            Color = item.Color,
                            Size = item.Size,
                            Pcs = item.Quantity,
                            CutQty = cutQty
                        });

                        cutQty = 0;

                    }
                }
                else
                {

                    foreach (var item in _PoRepo.GetAll().ToList())
                    {

                        GenaricRepository<CuttingItem> _CutRepo = new GenaricRepository<CuttingItem>(new ItrackContext());

                        var cut = from x in _CutRepo.GetAll()
                                  where x.Size == item.Size && x.Color == item.Color && x.PoNo == item.PurchaseOrderID
                                  select x;

                        int cutQty = 0;
                        if (cut.Count() > 0)
                        {

                            foreach (var i in cut)
                            {

                                cutQty = i.NoOfItem + cutQty;
                            }


                        }




                        lstPo.Add(new PoDeliveries
                        {
                            Date = item.PurchaseOrderHeader.EndDate,
                            PoNo = item.PurchaseOrderID,
                            StyleNo = item.PurchaseOrderHeader.StyleID,
                            Color = item.Color,
                            Size = item.Size,
                            Pcs = item.Quantity,
                            CutQty = cutQty
                        });

                        cutQty = 0;

                    }
                
                }
              




                Debug.WriteLine("No Of rows" + lstPo.Count);
                return lstPo;

            }
            catch(Exception){
                return lstPo;
            }
        
        }



        private void GenarateReport() {

            try {

                rptPoDiliveries report = new rptPoDiliveries();
                int option = 0;

                if (chkByStyle.Checked == true)
                {
                    option = 1;
                    report.DataSource = GetReportData(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txttoDate.Text), txtStyleNo.Text, option);
                }
                else
                {
                    option = 2;
                    report.DataSource = GetReportData(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txttoDate.Text), txtStyleNo.Text, option);
                }
               
                report.Landscape = true;

                if (chkFitToPage.Checked == true)
                {
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                }
                else 
                {
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 0;
                }
                
                ReportPrintTool tool = new ReportPrintTool(report);

                tool.ShowPreview();
            
            }
            catch(Exception ex){
            
            }
        
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            GenarateReport();
        }


        StyleVM SVM = new StyleVM();

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
           
            SVM.SearchStyle2(grdSearchStyle, txtStyleNo);
           
        }

        private void frmPoDeliveriesDialog_Load(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            txtStyleNo.Enabled = false;
        }

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtStyleNo.Text = gridView1.GetFocusedRowCellValue("StyleID").ToString();
                grdSearchStyle.Hide();


            }
        }

        private void txtStyleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchStyle.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchStyle.Hide();

            }
        }

        private void chkByStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByStyle.Checked == true)
            {
                txtStyleNo.Enabled = true;
            }
            else {
                txtStyleNo.Enabled = false;
            }
        }
    }
}