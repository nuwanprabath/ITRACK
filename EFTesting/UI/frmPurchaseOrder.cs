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
using System.Diagnostics;
using EFTesting.ViewModel;
using ITRACK.Validator;
namespace EFTesting.UI
{
    public partial class frmPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        #region Initialization

        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<PurchaseOrderHeader> _PORepository = new GenaricRepository<PurchaseOrderHeader>(new ItrackContext());
        GenaricRepository<PurchaseOrderItems> _POItemRepository = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
        
        GenaricRepository<PurchaseOrderHeader> _PORepositoryNew = new GenaricRepository<PurchaseOrderHeader>(new ItrackContext());
        Buyer _Buyer = new Buyer();
        Company _Company = new Company();
        CompanyVM CVM = new CompanyVM();
        StyleVM SVM = new StyleVM();
        PurchaseHeaderVM Pvm = new PurchaseHeaderVM();
        PurchaseOrderHeader PoHeader = new PurchaseOrderHeader();
        PurchaseOrderItems poItems = new PurchaseOrderItems();
        


        #endregion

        #region CRUD


        // get Company details related to application defualt profile 
        private  void GetDefualtCompany() {
            marqueeProgressBarControl1.Show();
            lblProgress.Text = "looking For Defualt Company";
           _Company.CompanyID =   CVM.GetCompany();
           if (_Company.CompanyID == 0) {
               btnAdd.Enabled = false;
               btnEdit.Enabled = false;
               MessageBox.Show("Please Add Defualt Company Before Get Started", "Defualt Company not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           lblProgress.Text = "";
           marqueeProgressBarControl1.Hide();
        
        }



        private PurchaseOrderHeader AssginPoHeader() {
            try {

                PoHeader.PurchaseOrderHeaderID = txtPoNo.Text;
                PoHeader.StyleID = txtStyleNo.Text;
                PoHeader.Article = txtArticle.Text;
                PoHeader.Season = txtSeason.Text;
                PoHeader.DeliveryTerms = cmbDterms.Text;
                PoHeader.OrderPrice =Convert.ToDouble( txtOrderPrice.Text);
                PoHeader.StartDate = Convert.ToDateTime(txtStartDate.Text);
                PoHeader.EndDate = Convert.ToDateTime(txtEndDate.Text);
                PoHeader.Remark = txtRemark.Text;
                if (chkPlanToWashinFct.Checked == true) {
                    PoHeader.PlaceWashingFactory = true;
                }
                else {
                    PoHeader.PlaceWashingFactory = false;
                }
               
                
                
                
                return PoHeader;
            
            }
            catch( Exception ex){

                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }


        private void AddPO()
        {
            try
            {
                showProgress("try To Add Po Header Details", true);
                _PORepository.Add(AssginPoHeader());
                showProgress("", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void showProgress(string Text,bool Show) {
            lblProgress.Text = Text;
            if (Show == true) {
                marqueeProgressBarControl1.Show();
            }
            else {
                marqueeProgressBarControl1.Hide();
            }
            
        }
        async void editPo()
        {


            try
            {
               
                showProgress("try To Update Po Header Details",true);
               
                  await _PORepositoryNew.EditAsync(AssginPoHeader());
                showProgress("", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchPo()
        {
            try
            {
                Pvm.SearchPo(grdSearchPo, txtSearchBox, btnClose);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void getPoFeild(string ID)
        {
            try
            {

                foreach (var po in GetPoByID(ID))
                {
               txtPoNo.Text =  po.PurchaseOrderHeaderID;
               txtStyleNo.Text = po.StyleID;
               txtArticle.Text =  po.Article  ;
               txtSeason.Text = po.Season ;
               cmbDterms.Text = po.DeliveryTerms;
               txtOrderPrice.Text = Convert.ToString(po.OrderPrice) ;
               txtStartDate.Text = Convert.ToString(po.StartDate);
               txtEndDate.Text = Convert.ToString(po.EndDate);
               txtRemark.Text = po.Remark;
               if (PoHeader.PlaceWashingFactory == true)
               {
                   chkPlanToWashinFct.Checked = true;
               }
               else
               {
                   chkPlanToWashinFct.Checked = false;
               }
                  


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Clear() {
            try {
                txtPoNo.Text = "";
                txtStyleNo.Text = "";
                txtArticle.Text = "";
                txtSeason.Text = "";
                cmbDterms.Text = "";
                txtOrderPrice.Text = "";
                txtStartDate.Text = "";
                txtEndDate.Text = "";
                txtRemark.Text = "";
                if (PoHeader.PlaceWashingFactory == true)
                {
                    chkPlanToWashinFct.Checked = true;
                }
                else
                {
                    chkPlanToWashinFct.Checked = false;
                }

                txtPoNo.Focus();
                grdSearchStyle.Hide();
                grdPoItems.DataSource = null;
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        
        }

        private List<PurchaseOrderHeader> GetPoByID(string ID)
        {
            try
            {
                return _PORepository.GetAll().Where(u => u.PurchaseOrderHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        private List<PurchaseOrderItems> GetPoItemsByID(string ID)
        {
            try
            {
              
                return _POItemRepository.GetAll().Where(u => u.PurchaseOrderHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private List<PurchaseOrderItems> GetPoItemsByIDRefesh(string ID)
        {
            try
            {

                GenaricRepository<PurchaseOrderItems> _POItemRepositorynew = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
                return _POItemRepositorynew.GetAll().Where(u => u.PurchaseOrderHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        public  void GetPoItems(string ID)
        {

            try
            {

                var datasource = from item in GetPoItemsByID(ID) select new { item.PurchaseOrderHeaderID, item.Color, item.Size, item.Length, item.Quantity };
                grdPoItems.DataSource = datasource;

              

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        void InitilizedPOItems() {
            try {
                
               
                
                    poItems.PurchaseOrderHeaderID = gridView3.GetFocusedRowCellValue("PurchaseOrderHeaderID").ToString();
                    poItems.PurchaseOrderID = gridView3.GetFocusedRowCellValue("PurchaseOrderHeaderID").ToString();
                    poItems.Color = gridView3.GetFocusedRowCellValue("Color").ToString();
                    poItems.Size = gridView3.GetFocusedRowCellValue("Size").ToString();
                    poItems.Length = gridView3.GetFocusedRowCellValue("Length").ToString();
                    poItems.Quantity =Convert.ToInt16( gridView3.GetFocusedRowCellValue("Quantity").ToString());

                
               
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }


      public void RefreshGrid() {


          var datasource = from item in GetPoItemsByIDRefesh(txtPoNo.Text) select new { item.PurchaseOrderHeaderID, item.Color, item.Size, item.Length, item.Quantity };
            grdPoItems.DataSource = datasource;
        
        }


        #endregion

      #region Diclaration

      Validator validate = new Validator();

      #endregion

      #region Validaton

      public bool isValidPurchaseOrder()
      {
          if (!validate.isPresent(txtPoNo, "Po Number"))
          {
              return false;
          }

          if (!validate.isPresent(txtStyleNo, "Style Number"))
          {
              return false;
          }

          if (!validate.isPresent(txtArticle, "Article"))
          {
              return false;
          }

          if (!validate.isPresent(txtSeason, "Season"))
          {
              return false;
          }

          if (!validate.isPresent(cmbDterms, "Delivery Terms"))
          {
              return false;
          }

          if (!validate.isPresent(txtOrderPrice, "Order Price"))
          {
              return false;
          }

          if (!validate.isPresent(txtStartDate, "Start Date"))
          {
              return false;
          }

          if (!validate.isPresent(txtEndDate, "End Date"))
          {
              return false;
          }

          return true;

      }

      #endregion




      private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            marqueeProgressBarControl1.Hide();
            grdSearchStyle.Hide();
            grdSearchPo.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            GetDefualtCompany();
        }

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            showProgress("try To Search Progress", true);
            SVM.SearchStyle2(grdSearchStyle, txtStyleNo);
            showProgress("", false);
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

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtStyleNo.Text = gridView1.GetFocusedRowCellValue("StyleID").ToString();
                grdSearchStyle.Hide();
             
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidPurchaseOrder() == true)
            {
                AddPO();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editPo();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchPo();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchPo.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchPo.Hide();

            }
        }

        private void grdSearchPo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PoHeader.PurchaseOrderHeaderID = gridView2.GetFocusedRowCellValue("PurchaseOrderHeaderID").ToString();
                getPoFeild(PoHeader.PurchaseOrderHeaderID);
                GetPoItems(PoHeader.PurchaseOrderHeaderID);
                grdSearchPo.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
                grdSearchStyle.Hide();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            txtSearchBox.Focus();
            btnClose.Show();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PoItemsDialog PoItems = new PoItemsDialog();
            PoItems.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            InitilizedPOItems();
            PoItemsDialog PoItems = new PoItemsDialog(poItems,this);
            PoItems.ShowDialog();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchPo.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }
    }
}