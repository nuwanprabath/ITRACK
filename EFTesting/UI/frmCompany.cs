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
namespace EFTesting.UI
{
    public partial class frmCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }
       
 #region Declarations
        GenaricRepository<Group> _genaricrepository = new GenaricRepository<Group>(new ItrackContext());
        GenaricRepository<Company> _genaricrepositorycompany = new GenaricRepository<Company>(new ItrackContext());
        Validator Validator = new Validator();
        #endregion

 #region GROUP CRUD

        void Clear() {
            try {
            
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        //assign group properties and return new group object 
        private Group AssignGroup() {
            Group _group = new Group();
            _group.GroupID = txtGroupID.Text;
            _group.GroupName = txtGroupName.Text;
            _group.TeleNo = txtTeleNo.Text;
            _group.FaxNo = txtFaxNo.Text;
            _group.Address = txtAddress.Text;
            return _group;
        } 

        //add vew group to database 
      private  void addGroup() {

          try {
             
              _genaricrepository.Add(AssignGroup());
              
          }
          catch(Exception ex){
              Debug.WriteLine(ex.Message);
              MessageBox.Show( ex.Message, "Error - C-0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }


        // edit existing group 
      private  void EditGroup()
      {

          try
          {
           
              GenaricRepository<Group> _repository = new GenaricRepository<Group>(new ItrackContext());
              _repository.Edit(AssignGroup());

          }
          catch (Exception ex)
          {
              Debug.WriteLine(ex.Message);
              MessageBox.Show(ex.Message, "Error - C-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

      }

      private async void DeleteGroup()
      {

          try
          {

              GenaricRepository<Group> _repository = new GenaricRepository<Group>(new ItrackContext());
              await  _repository.DeleteAsync(AssignGroup());

          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

      }

        // get all group 
      public async void GetGroup()
      {
          try {

        //    var datasource =   from item in _genaricrepository.GetAll().ToList() select new { item.GroupID, item.GroupName, item.TeleNo, item.FaxNo, item.Address };
              var datasource = from item in await _genaricrepository.GetAllData() select new { item.GroupID, item.GroupName, item.TeleNo, item.FaxNo, item.Address };
              grdGroup.DataSource = datasource;
          }
          catch(Exception ex){
              MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      
      }


      public async void GetCompany()
      {

          try
          {

              var datasource = from item in await _genaricrepositorycompany.GetAllData() select new { item.CompanyID,item.Group.GroupName, item.CompanyName, item.LocationCode, item.TeleNo, item.FaxNo, item.CompanyAddress,item.isDefaultCompany };
              grdCompany.DataSource = datasource;

          }
          catch (Exception ex)
          {
              Debug.WriteLine(ex.Message);
          }
      }

      private List<Group> GetGroupByID(string ID)
      {
          try
          {
             return _genaricrepository.GetAll().Where(u => u.GroupID == ID).ToList();
             
             
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return null;
             
          }

      }

      private List<Company> GetCompanyByID(int ID)
      {
          try
          {
              return _genaricrepositorycompany.GetAll().Where(u => u.CompanyID == ID).ToList();


          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return null;

          }

      }

        // get selected object values to form controls 
      void getGroupFeild(string ID) {
          try {

              foreach (var groups in GetGroupByID(ID)) {
                  txtGroupID.Text = groups.GroupID;
                  txtGroupName.Text = groups.GroupName;
                  txtTeleNo.Text = groups.TeleNo;
                  txtFaxNo.Text = groups.FaxNo;
                  txtAddress.Text = groups.Address;
              }
          }
          catch(Exception ex){
              MessageBox.Show(ex.Message, "Error - C-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

      Company _company = new Company();
      // get selected object values to form controls 
      void getCompanyFeild(int ID)
      {
          try
          {

              if (GetCompanyByID(ID).Count > 0)
              {
                  foreach (var company in GetCompanyByID(ID))
                  {
                      _company.CompanyID = company.CompanyID;
                      _company.CompanyName = company.CompanyName;
                      _company.CompanyAddress = company.CompanyAddress;
                      _company.TeleNo = company.TeleNo;
                      _company.FaxNo = company.FaxNo;
                      _company.GroupID = company.GroupID;
                      _company.LocationCode = company.LocationCode;
                      _company.isDefaultCompany = company.isDefaultCompany;


                  }
              }

             
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

        #endregion


 #region Evets 
        



      private void frmCompany_FormClosing(object sender, FormClosingEventArgs e)
      {

      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
          if (isValidGroup() == true)
          {
              addGroup();
              GetGroup();
          }
          
         
      }

      private bool isvalidcompany()
      {
          throw new NotImplementedException();
      }

      private void frmCompany_Load(object sender, EventArgs e)
      {
          GetGroup();
          GetCompany();

      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
          if (btnEdit.Text == "Edit")
          {
              string groupID = gridView1.GetFocusedRowCellValue("GroupID").ToString();
              getGroupFeild(groupID);
              btnEdit.Text = "Update";
          }
          else
          {
              EditGroup();
              btnEdit.Text = "Edit";
          }


      }
      private void simpleButton4_Click(object sender, EventArgs e)
      {
          frmcompanyDialog companydialog = new frmcompanyDialog();
          companydialog.ShowDialog();
      }

      private void simpleButton2_Click(object sender, EventArgs e)
      {


          int ID = Convert.ToInt16(gridView2.GetFocusedRowCellValue("CompanyID").ToString());
          getCompanyFeild(ID);
          frmcompanyDialog companydialog = new frmcompanyDialog(_company, this);
          companydialog.ShowDialog();
      }

      private void simpleButton1_Click(object sender, EventArgs e)
      {
          DeleteGroup();
      }

      private void btnNew_Click(object sender, EventArgs e)
      {

      }
      #endregion

 #region validation
      public bool isValidGroup()
      {


          if (!Validator.isPresent(txtGroupID, "Group ID"))
          {
              return false;
          }

          if (!Validator.isPresent(txtGroupName, "Group Name"))
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