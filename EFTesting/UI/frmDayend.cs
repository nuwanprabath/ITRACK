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
using EFTesting.Reports;
using ITRACK.models;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmDayend : DevExpress.XtraEditors.XtraForm
    {
        public frmDayend()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            addDayendHeader();
            DateTime _now = Convert.ToDateTime(txtdate.Text);
            clsProductionSummary.DoDayend(lblStatus,progressPanel1,_now);
            
        }


        #region CRUD
        DayendHeader _header = new DayendHeader();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        DayendHeader AssignHeader() {

            try {
              

              foreach (var item in _CompanyRepository.GetAll().Where(x=> x.isDefaultCompany==true) ) {
                  _header.CompanyID = item.CompanyID;

                }

              _header.Date = DateTime.Now;
              _header.DayendBy = "Admin";
              DateTime _now = Convert.ToDateTime(txtdate.Text);
              _header.DayendHeaderID =Convert.ToString( _now.Year + _now.Month + _now.Day);
              _header.DayendTime =Convert.ToString( DateTime.Now);
              _header.ApprovedBy = "None";
              _header.ApprovedAt = "None";
              _header.Status = "Pending";

                return _header;
            }
            catch(Exception ex){
               
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        void addDayendHeader() {
            try {
                GenaricRepository<DayendHeader> _DayendHeaderRepository = new GenaricRepository<DayendHeader>(new ItrackContext());
                _DayendHeaderRepository.Add(AssignHeader());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }

        #endregion 

        private void frmDayend_Load(object sender, EventArgs e)
        {
            progressPanel1.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clsProductionSummary p = new clsProductionSummary();
            rptDayend _report = new rptDayend();


            Debug.WriteLine(p.GetDayendHeader(DateTime.Now).Count() + " Data Row Count");
            _report.DataSource = p.GetDayendHeader(DateTime.Now);

            ReportPrintTool tool = new ReportPrintTool(_report);
            tool.ShowPreview();
         //  p.AddIndividualProductionSummary(DateTime.Now);

         //  p.AddCuttingSummary(DateTime.Now);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            HourlyProduction _report = new HourlyProduction();
            
            ReportPrintTool tool = new ReportPrintTool(_report);
            tool.ShowPreview();
        }
    }
}