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
using ITRACK.Validator;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.ViewModel;

namespace EFTesting.UI
{
    public partial class frmRunningNo : DevExpress.XtraEditors.XtraForm
    {
        public frmRunningNo()
        {
            InitializeComponent();
        }


        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidRunningNo()
        {
            if (!validate.isPresent(txtCode, "Code"))
            {
                return false;
            }

            if (!validate.isPresent(txtLength, "Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtStarting, "Starting"))
            {
                return false;
            }

            if (!validate.isPresent(txtVenue, "Venue"))
            {
                return false;
            }
            return true;
        }


        #endregion

        #region CUID

        GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        RunningNo _RunningNo = new RunningNo();
        Company _Company = new Company();

        private RunningNo AssingRunningNo()
        {

            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            _RunningNo.RunningNoID = _RunningNo.Venue;
            _RunningNo.CompanyID = _Company.CompanyID;
            _RunningNo.Venue = txtVenue.Text;
            _RunningNo.Starting = Convert.ToInt32(txtStarting.Text);
            _RunningNo.Length = Convert.ToInt32(txtLength.Text);
            _RunningNo.Prefix = txtPrefix.Text;
            _RunningNo.Code = txtCode.Text;

            return _RunningNo;
        }


        private void AddField()
        {
            try
            {
                _RunningNoRepo.Add(AssingRunningNo());
            }

            catch (Exception ex)
            {

            }
        }
           
        #endregion

        private void GenateCode()
        {

            try
            {
                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x=>x.Venue == txtVenue.Text))
                {
                    Debug.WriteLine(item.Starting + item.Venue);


                }
            }
            catch (Exception ex)
            {


            }

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            Genarate();
        }

        private void frmRunningNo_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidRunningNo() == true)
            {
                AddField();
            }
        }

        private void txtVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenateCode();
        }


        clsRuningNoEngine No = new  clsRuningNoEngine();

        RunningNo RunningNoEngine = new RunningNo();


        private void Genarate() {

            RunningNoEngine.Prefix = txtPrefix.Text;
            if (txtLength.Text != "")
            {
                RunningNoEngine.Length = Convert.ToInt16( txtLength.Text);

            }
            else
            {
                RunningNoEngine.Length = 0;

            }

            if (txtStarting.Text != "")
            {
                RunningNoEngine.Starting = Convert.ToInt16( txtStarting.Text);

            }
            else
            {
                RunningNoEngine.Starting = 0;

            }
           
            

          txtCode.Text =  No.GenarateNo(RunningNoEngine, 0);

        
        }

        private void txtStarting_EditValueChanged(object sender, EventArgs e)
        {
            Genarate();
        }

        private void txtPrefix_EditValueChanged(object sender, EventArgs e)
        {
            Genarate();
        }
    }
}