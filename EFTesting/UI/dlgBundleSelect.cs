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
using EFTesting.Reports;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class dlgBundleSelect : DevExpress.XtraEditors.XtraForm
    {
        public dlgBundleSelect()
        {
            InitializeComponent();
        }



        void GenarateReport(string _styleNo,int _from,int _to)
        {
            try {
                GenaricRepository<OprationBarcodes> _ItemRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());

                var items = from item in _ItemRepo.GetAll().ToList()
                            where item.StyleNo == _styleNo && item.BundleDetails.BundleNo >= _from && item.BundleDetails.BundleNo < _to && item.isOparationComplete==true
                            select item;

                BundleWiseProduction lbl = new BundleWiseProduction();
                lbl.DataSource = items;
                ReportPrintTool tool = new ReportPrintTool(lbl);
                tool.ShowPreview();


            }
            catch(Exception ex){
            
            }
        
        
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GenarateReport(txtStyleNo.Text, Convert.ToInt16(txtFrom.Text), Convert.ToInt16(txtTo.Text));
        }
    }
}