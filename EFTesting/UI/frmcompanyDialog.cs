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
using System.Linq.Expressions;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmcompanyDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmcompanyDialog()
        {
            InitializeComponent();
        }

        protected Company Company { get; set; }
        protected frmCompany _CompanyUi { get; set; }
        public frmcompanyDialog(Company _company,frmCompany _comUi) {
            this.Company = _company;
            this._CompanyUi = _comUi;
            InitializeComponent();
            initlizedControlValues();
        }

// each insiliztion goes here 
#region Inilization 
        
        GenaricRepository<Group> _genaricrepository = new GenaricRepository<Group>(new ItrackContext());
        GenaricRepository<Company> _genaricrepositorycompany = new GenaricRepository<Company>(new ItrackContext());
        
        Group _group = new Group();
        CompanyVM Cvm = new CompanyVM();
        Validator Validator = new Validator();


        void initlizedControlValues() {
            try {
                if (Company.CompanyName != "") {
               
                    txtCompanyName.Text = Company.CompanyName;
                    txtAddress.Text = Company.CompanyAddress;
                    txtFaxNo.Text = Company.FaxNo;
                    txtLocationCode.Text = Company.LocationCode;
                    txtTeleNo.Text = Company.TeleNo;
                    txtGroupID.Text = Company.GroupID;

                    if (Company.isDefaultCompany == true)
                    {
                        isDefualtCompany.Checked = true;
                    }
                    else
                    {
                        isDefualtCompany.Checked = false;
                    }
                }
                
                   
                    grdGroup.Hide();
                    btnAdd.Enabled = false;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
#endregion

// all CRUD oprations 
#region COMPANYCRUD


        //search group by Group ID and group Name 
        void SerchGroup() {
            try {
              
               
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Group), "s");
                Expression nameProperty = Expression.Property(argParam, "GroupName");
                Expression namespaceProperty = Expression.Property(argParam, "GroupID");

                var val1 = Expression.Constant(txtGroupID.Text);
                var val2 = Expression.Constant(txtGroupID.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty,"Contains",null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Group, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _genaricrepository.SearchFor(lambda1).ToList() select new { item.GroupID, item.GroupName, item.TeleNo, item.FaxNo, item.Address };
               
                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdGroup.Show();
                    grdGroup.DataSource = selected;
                }
                else {
                    grdGroup.DataSource = null;
                }

             

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0009", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


         Company AssignCompany() {
            try {
                Company _company = new Company();
               _company.GroupID = txtGroupID.Text;
               _company.CompanyName=txtCompanyName.Text;
               _company.LocationCode = txtLocationCode.Text;
               _company.CompanyAddress = txtAddress.Text;
               _company.TeleNo = txtTeleNo.Text;
               _company.FaxNo = txtFaxNo.Text;
            
               if (isDefualtCompany.Checked == true)
               {
                   _company.isDefaultCompany = true;
               }
               else {
                   _company.isDefaultCompany = false;
               }

               return _company;
            
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0009", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        void addCompany() {

            try {
                _genaricrepositorycompany.Add(AssignCompany());
                
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0010", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      async  void  editCompany()
        {

            try
            {
                GenaricRepository<Company> _genaricrepositorycompanynew = new GenaricRepository<Company>(new ItrackContext());
                await _genaricrepositorycompanynew.EditAsync(AssignCompany());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0011", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async  void GetCompany()
        {

            try {
               
                var datasource = from item in await _genaricrepositorycompany.GetAllData() select new { item.CompanyID,item.CompanyName,item.LocationCode,item.TeleNo,item.FaxNo,item.CompanyAddress };
                grdGroup.DataSource = datasource;
            
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0012", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

// all Events 
 #region Events 

        private void frmcompanyDialog_Load(object sender, EventArgs e)
        {
            //initlizedControlValues();
            grdGroup.Hide();
           
        }

        private void txtGroupID_EditValueChanged(object sender, EventArgs e)
        {
            SerchGroup();
        }

        private void txtGroupID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdGroup.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdGroup.Hide();

            }
        }

        private void grdGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                txtGroupID.Text = gridView1.GetFocusedRowCellValue("GroupID").ToString();
                grdGroup.Hide();



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isDefualtCompany.Checked == true)
            {
                if (isValidCompany() == true && Cvm.isExistingDefualtCompany() == false)
                {
                    addCompany();
                }
            }
            else {
                if (isValidCompany() == true )
                {
                    addCompany();
                }
            
            }
          
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
          

            if (isDefualtCompany.Checked == true)
            {
                if (isValidCompany() == true && Cvm.isExistingDefualtCompany() == false)
                {
                    editCompany();
                }
            }
            else
            {
                if (isValidCompany() == true)
                {
                    editCompany();
                }

            }
           
        }

        private void frmcompanyDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_CompanyUi.GetGroup();
            //_CompanyUi.GetCompany();
        }

 #endregion

#region Validation
        public bool isValidCompany()
        {
           

            if (!Validator.isPresent(txtGroupID, "Group ID"))
            {
                return false;
            }

            if (!Validator.isPresent(txtLocationCode, "Location Code"))
            {
                return false;
            }

            if (!Validator.isPresent(txtCompanyName, "Company Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtTeleNo, "Telephone No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFaxNo, "Fax No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtAddress, "Address"))
            {
                return false;
            }
          return true;
        }



#endregion



    }
}