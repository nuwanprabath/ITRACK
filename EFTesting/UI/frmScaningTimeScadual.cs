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
using DevExpress.Office.Utils;

namespace EFTesting.UI
{
    public partial class frmScaningTimeScadual : DevExpress.XtraEditors.XtraForm
    {
        public frmScaningTimeScadual()
        {
            InitializeComponent();
        }

        #region CRUD 
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());


        ScaningTimeSchadual Time = new ScaningTimeSchadual();

        ScaningTimeSchadual AssignValues() {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    Time.CompanyID = item.CompanyID;

                }

                Time.ScaningTime = txtScaningTime.Text;
                Time.HourNO = Convert.ToInt16(txtHourNo.Text);
                Time.Remark = txtRemark.Text;

                return Time;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }


        void AddTimeScadual() {
            try {
                GenaricRepository<ScaningTimeSchadual> _ScaningRepository = new GenaricRepository<ScaningTimeSchadual>(new ItrackContext());
                _ScaningRepository.Add(AssignValues());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        #endregion 


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTimeScadual();
        }

        private void frmScaningTimeScadual_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
        }
    }
}