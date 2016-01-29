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
using ITRACK.Validator;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;

namespace EFTesting.UI
{
    public partial class EmployeeMaster : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeMaster()
        {
            InitializeComponent();
        }

        #region Declarattion

        Validator Validator = new Validator();
        Employee _Employee = new Employee();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<Employee> _EmployeeRepository = new GenaricRepository<Employee>(new ItrackContext());
        GenaricRepository<Employee> _EmployeeRepositoryEdit = new GenaricRepository<Employee>(new ItrackContext());

        #endregion

        #region valitation
        public bool isValidEmployeeMaster()
        {


            if (!Validator.isPresent(txtEmployeeID, "Employee ID"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFullName, "Full Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtDateOfBirth, "Date Of Birth"))
            {
                return false;
            }

            if (!Validator.isPresent(txtNIC, "NIC No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEPFNo, "EPF No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtETFNo, "ETF No"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbDepartment, "Department"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbDesignation, "Designation"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbJobStatus, "Job Status"))
            {
                return false;
            }

            //if (!Validator.isPresent(rdoMeritalStatus, "Merital Status"))
            //{
            //    return false;
            //}

            //if (!Validator.isPresent(rdoGender, "Gender"))
            //{
            //    return false;
            //}

            if (!Validator.isPresent(txtEmail, "E-mail Address"))
            {
                return false;
            }

            if (!Validator.isPresent(txtMobileNo, "Mobile No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmgNo, "Emergency No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmgContactPerson, "Emergency Contact Person"))
            {
                return false;
            }

            return true;
        }

        #endregion


        #region CRUD
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private Employee AssignEmployee() {
            try {

                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Employee.CompanyID = item.CompanyID;

                }
                _Employee.EmployeeID = txtEmployeeID.Text;
                _Employee.FullName = txtFullName.Text;
                _Employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                _Employee.NicNo = txtNIC.Text;
                _Employee.EPFNo = txtEPFNo.Text;
                _Employee.ETFNo = txtETFNo.Text;
                _Employee.Department = cmbDepartment.Text;
                _Employee.Designation = cmbDesignation.Text;
                _Employee.JobStatus = cmbJobStatus.Text;

                _Employee.Gender = rdoGender.Text;

                _Employee.MaritalStatus = rdoMeritalStatus.Text;

                _Employee.MobileNo = txtMobileNo.Text;
                _Employee.LandNo = txtLandNo.Text;
                _Employee.EmailAddress = txtEmail.Text;
                _Employee.EmergencyContactNo = txtEmgNo.Text;
                _Employee.EmergencyContactPerson = txtEmgContactPerson.Text;
                _Employee.Address = memoAddress.Text;
                _Employee.Image = imageToByteArray(imgprofile.Image);


                

                return _Employee;
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        private void AddEmployee()
        {
            try
            {
                GenaricRepository<Employee> _EmployeeRepo = new GenaricRepository<Employee>(new ItrackContext());
                _EmployeeRepo.Add(AssignEmployee());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditEmployee()
        {
            try
            {
                _EmployeeRepositoryEdit.Edit(AssignEmployee());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchEmployee()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Employee), "s");
                Expression nameProperty = Expression.Property(argParam, "EmployeeID");
                Expression namespaceProperty = Expression.Property(argParam, "FullName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Employee, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _EmployeeRepository.SearchFor(lambda1).ToList() select new { item.EmployeeID,item.FullName,item.EPFNo,item.ETFNo,item.Designation };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearch.Show();
                    btnClose.Show();

                    grdSearch.DataSource = selected;
                }
                else
                {
                    grdSearch.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void getEmployeeFeild(string ID)
        {
            try
            {

                foreach (var employee in GetEmployeeByID(ID))
                {
                    txtEmployeeID.Text = employee.EmployeeID;
                    txtFullName.Text = employee.FullName;
                    lblName.Text = employee.FullName;
                    txtNIC.Text = employee.NicNo;
                    txtEPFNo.Text = employee.EPFNo;
                    txtETFNo.Text = employee.ETFNo;
                    cmbDepartment.Text = employee.Department;
                    lblDepartment.Text = employee.Department;
                    cmbDesignation.Text = employee.Designation;
                    cmbJobStatus.Text = employee.JobStatus;
                    txtDateOfBirth.Text = Convert.ToString(employee.DateOfBirth);

                    byte[] picture = employee.Image;
                    imgprofile.Image = Image.FromStream(new MemoryStream(picture));
                    imgprofile.Refresh();

                    txtEmail.Text = employee.EmailAddress;
                    txtMobileNo.Text = employee.MobileNo;
                    txtLandNo.Text = employee.LandNo;
                    txtEmgContactPerson.Text = employee.EmergencyContactPerson;
                    txtEmgNo.Text = employee.EmergencyContactNo;
                    memoAddress.Text = employee.Address;




                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Clear()
        {
            try
            {


                    txtEmployeeID.Text = "";
                    txtFullName.Text = "";
                    lblName.Text = "";
                    txtNIC.Text = "";
                    txtEPFNo.Text = "";
                    txtETFNo.Text = "";
                    cmbDepartment.Text = "";
                    lblDepartment.Text = "";
                    cmbDesignation.Text = "";
                    cmbJobStatus.Text = "";
                    txtDateOfBirth.Text = "";

                    imgprofile.Image = null;

                    txtEmail.Text = "";
                    txtMobileNo.Text = "";
                    txtLandNo.Text = "";
                    txtEmgContactPerson.Text = "";
                    txtEmgNo.Text = "";
                    memoAddress.Text = "";






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Employee> GetEmployeeByID(string ID)
        {
            try
            {
                return _EmployeeRepository.GetAll().Where(u => u.EmployeeID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }



        private void GetPromotion(string Id)
        {
            try
            {
              GenaricRepository<Promotion> _PromotionRepository = new GenaricRepository<Promotion>(new ItrackContext());
              var selected =   _PromotionRepository.GetAll().Where(x => x.EmployeeID == Id).ToList();

              grdPromotion.DataSource = from item in selected select new { item.PromotionID,  item.FromDesignation, item.ToDesignation, item.PromotedDate, item.JobDescription, item.Remark };
              gridView1.Columns["PromotionID"].Visible = false;
            }
            catch(Exception ex){
            
            }
        }

        Promotion Promotion = new Promotion();
        private void GetPromotionDetails (string _empId){
            try
            {
              int Id =  Convert.ToInt16(gridView1.GetFocusedRowCellValue("PromotionID").ToString());
                GenaricRepository<Promotion> _PromotionRepository = new GenaricRepository<Promotion>(new ItrackContext());

               var result =   _PromotionRepository.GetAll().Where(x => x.EmployeeID == _empId).ToList();

               foreach (var item in result.Where(x => x.PromotionID == Id))
               {
                    
                    Promotion.EmployeeID = item.EmployeeID;
                    Promotion.PromotionID = item.PromotionID;
                    Promotion.FromDesignation = item.FromDesignation;
                    Promotion.ToDesignation = item.ToDesignation;
                    Promotion.JobDescription = item.JobDescription;
                    Promotion.Remark = item.Remark;
                    Promotion.PromotedDate = item.PromotedDate;
                }
               
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        #endregion


        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeMaster_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtSearchBox.Hide();
            btnClose.Hide();
            grdSearch.Hide();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmPromotion promotion = new frmPromotion(txtEmployeeID.Text);
            promotion.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmAward award = new frmAward();
            award.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidEmployeeMaster() == true)
            {
                AddEmployee();
            }
                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isValidEmployeeMaster() == true)
            {
                EditEmployee();
            }
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            _Employee.EmployeeID = gridView3.GetFocusedRowCellValue("EmployeeID").ToString();
            getEmployeeFeild(_Employee.EmployeeID);
            GetPromotion(_Employee.EmployeeID);
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            txtEmployeeID.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GetPromotionDetails(txtEmployeeID.Text);
            frmPromotion promotion = new frmPromotion(Promotion,this);
            promotion.ShowDialog();
        }

       
    }
}
