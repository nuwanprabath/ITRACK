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

namespace EFTesting.UI
{
    public partial class frmVechileReqForm : DevExpress.XtraEditors.XtraForm
    {
        public frmVechileReqForm()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation
        public bool isValidVehicleRequisitionForm()
        {
            if (!validate.isPresent(txtRequestDate, "Request Date"))
            {
                return false;
            }

            if (!validate.isPresent(txtRequestTime, "Request Time"))
            {
                return false;
            }

            if (!validate.isPresent(txtRequestBy, "Request By"))
            {
                return false;
            }

            if (!validate.isPresent(txtDepartment, "Department"))
            {
                return false;
            }

            if (!validate.isPresent(memPurpose, "Purpose"))
            {
                return false;
            }

            if (!validate.isPresent(cmbVehicleType, "Vehicle Type"))
            {
                return false;
            }

            return true;
        }

        #endregion

        #region CRUD

        GenaricRepository<VehicleRequisition> _VehicleRequestionRepo = new GenaricRepository<VehicleRequisition>(new ItrackContext());
        VehicleRequisition _VehicleRequisition = new VehicleRequisition();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());

        private VehicleRequisition AssingVehicleRequisition()
        {

            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _VehicleRequisition.CompanyID = item.CompanyID;

            }

            _VehicleRequisition.VehicleRequisitionID = "0000001";
            _VehicleRequisition.RequestDate = txtRequestDate.Text;
            _VehicleRequisition.RequestTime = txtRequestTime.Text;
            _VehicleRequisition.RequestBy = txtRequestBy.Text;
            _VehicleRequisition.Department = txtDepartment.Text;
            _VehicleRequisition.Purpose = memPurpose.Text;
            _VehicleRequisition.VehicleType = cmbVehicleType.Text;
            _VehicleRequisition.DriverName = txtDriverName.Text;
            _VehicleRequisition.ContactNo = txtContactNo.Text;
            _VehicleRequisition.VehicleNo = txtVehicleNo.Text;
            _VehicleRequisition.SpeedDialNo = txtSpeedDialNo.Text;
            _VehicleRequisition.Payment = txtPayment.Text;
            _VehicleRequisition.AssignToJob = txtAssignToJob.Text;
            _VehicleRequisition.TimeStart = txtTimeStart.Text;
            _VehicleRequisition.TimeFinished = txtTimeFinished.Text;
            _VehicleRequisition.StartMeter = txtStartMeter.Text;
            _VehicleRequisition.FinishedMeter = txtFinishedMeter.Text;
            _VehicleRequisition.TravelledDistance = txtTravelledDistance.Text;

            return _VehicleRequisition;
        }

        private void AddField()
        {
            try
            {

                GenaricRepository<VehicleRequisition> _VehicleRequestionRepo = new GenaricRepository<VehicleRequisition>(new ItrackContext());
                _VehicleRequestionRepo.Add(AssingVehicleRequisition());

            }
            catch (Exception ex)
            {

            }
        }


        void getVehicleRequisition(string ID)
        {
            try
            {
                foreach (var item in getVehicleRequisitionID(ID))
                {
                    lblRequestNo.Text = item.VehicleRequisitionID;
                    txtRequestDate.Text = item.RequestDate;
                    txtRequestTime.Text = item.RequestTime;
                    txtRequestBy.Text = item.RequestBy;
                    txtDepartment.Text = item.Department;
                    memPurpose.Text = item.Purpose;
                    cmbVehicleType.Text = item.VehicleType;
                    txtDriverName.Text = item.DriverName;
                    txtContactNo.Text = item.ContactNo;
                    txtVehicleNo.Text = item.VehicleNo;
                    txtSpeedDialNo.Text = item.SpeedDialNo;
                    txtPayment.Text = item.Payment;
                    txtAssignToJob.Text = item.AssignToJob;
                    txtTimeStart.Text = item.TimeStart;
                    txtTimeFinished.Text = item.TimeFinished;
                    txtStartMeter.Text = item.StartMeter;
                    txtFinishedMeter.Text = item.FinishedMeter;
                    txtTravelledDistance.Text = item.TravelledDistance;


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<VehicleRequisition> getVehicleRequisitionID(string ID)
        {
            try
            {
                return _VehicleRequestionRepo.GetAll().Where(u => u.VehicleRequisitionID == ID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        #endregion




        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVechileReqForm1_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (isValidVehicleRequisitionForm() == true)
            {
                AddField();
            }
        }

    }
}