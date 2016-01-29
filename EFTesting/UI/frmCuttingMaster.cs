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
using System.Linq.Expressions;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using MyTeamApp;
using DevExpress.XtraEditors.Controls;
using ITRACK.Validator;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;
using DevExpress.XtraPivotGrid;
using EFTesting.ViewModel;


namespace EFTesting.UI
{
    public partial class frmCuttingMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmCuttingMaster()
        {
            InitializeComponent();
        }

        #region Initialization 

        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());
        
        

        CuttingHeader _cuttingHeader = new CuttingHeader();
        CuttingItem _cuttingItem = new CuttingItem();
        BundleHeader _BundleHeader = new BundleHeader();
        Style _Style = new Style();

        #endregion

        #region CRUD
        CuttingHeader AssignHeader() {
            try {
                _cuttingHeader.CuttingHeaderID = txtCuttingTicketNo.Text;
                _cuttingHeader.StyleID = txtStyleNo.Text;
                _cuttingHeader.OrderQuantity = Convert.ToInt16(txtOrderQty.Text);
                _cuttingHeader.PlanQuantity = Convert.ToInt16(txtPlanQty.Text);
                _cuttingHeader.ItemType = cmbItemType.Text;
                _cuttingHeader.status = cmbStatus.Text;
                _cuttingHeader.Remark = txtRemark.Text;
                _cuttingHeader.Date = DateTime.Now;
                return _cuttingHeader;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        CuttingItem AssignCuttingItem() {
            try {
                CuttingItem _cuttingItem = new CuttingItem();
                _cuttingItem.PoNo = txtPoNo.Text;
                _cuttingItem.CuttingHeaderID = _cuttingHeader.CuttingHeaderID;
                _cuttingItem.MarkerNo = txtMarkerNo.Text;
                _cuttingItem.Color = txtColorCode.Text;
                _cuttingItem.Size = txtSize.Text;
                _cuttingItem.Length = txtLength.Text;
                _cuttingItem.NoOfItem =Convert.ToInt16( txtnoOfItem.Text);
                _cuttingItem.NoOfLayer =Convert.ToInt16( txtnoOfLayers.Text);
              
                _cuttingItem.FabricType = txtfabricType.Text;
             
                _cuttingItem.LineNo = txtlineNo.Text;
                _cuttingItem.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _cuttingItem.isGenaratedTags = false;
                _cuttingItem.GenaratedTime = "None";
                _cuttingItem.isPrinted = false;
                _cuttingItem.PrinteTime = "None";
                return _cuttingItem;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        private int GetLastCutNo() {
            try {
                GenaricRepository<CuttingItem> _CuttingItemRepository = new GenaricRepository<CuttingItem>(new ItrackContext());
             _cuttingItem =   _CuttingItemRepository.GetAll().ToList().Last();

             return _cuttingItem.CuttingItemID;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return 0;
            }
        
        }

        /// <summary>
        /// check if cutting item fegures alight to add item . reuturn true or false 
        /// </summary>
        /// <param name="_item"> cutting item </param>
        /// <returns></returns>
        private bool isEligbleCuttingItem(CuttingItem _item) {
            try {

                GenaricRepository<CuttingItem> _CuttingItemRepository = new GenaricRepository<CuttingItem>(new ItrackContext());

                var result = from item in _CuttingItemRepository.GetAll() where (item.MarkerNo == item.MarkerNo  && item.Size == _item.Size && item.Color == _item.Color && item.Length   == _item.Length && _item.Date == item.Date && _item.MarkerNo == item.MarkerNo) select item;
                if (result.Count() <= 0)
                {
                    return true;
                }
                else { 
                    return false;
                }
            }catch(Exception ex){

                Debug.WriteLine(ex.Message);
                return false;
            }
        
        }

        BundleHeader AssignBundleHeader()
        {
            try
            {

                
                _BundleHeader.BundleTagGenaratedBy = "None";
                _BundleHeader.BundleTagGenaratedTime = "None";
                _BundleHeader.isBundleTagsGerated = false;
                _BundleHeader.isOprationTagGenated = false;
                _BundleHeader.OprationTagGenaratedTime = "None";
                _BundleHeader.OprationTagGeratedBy = "None";
                _BundleHeader.CuttingItemID = GetLastCutNo();
                int i = GetLastCutNo();


                return _BundleHeader;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        private void AddCuttingHeader()
        {
            try
            {
                GenaricRepository<CuttingHeader> _HeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
                _HeaderRepository.Add(AssignHeader());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddCuttingItem()
        {
            try
            {
                GenaricRepository<CuttingItem> _CuttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());

                if (isEligbleCuttingItem(AssignCuttingItem()) == true)
                {
                    _CuttingItemRepo.Add(AssignCuttingItem());

                }
                else {
                    MessageBox.Show("Already Exist", "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddBundleHeader() {
            try {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                _BundleHeaderRepository.Add(AssignBundleHeader());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        private void SearchCuttingHeader()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(CuttingHeader), "s");
                Expression nameProperty = Expression.Property(argParam, "CuttingHeaderID");
                Expression namespaceProperty = Expression.Property(argParam, "StyleID");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<CuttingHeader, bool>>(andExp, argParam);
                // pass object to query 
                GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
                var selected = from item in _SearchHeaderRepository.SearchFor(lambda1).ToList() select new { item.CuttingHeaderID, item.StyleID, item.OrderQuantity, item.Date, item.Remark };

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
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void getCuttingFeild(string ID)
        {
            try
            {

                foreach (var header in GetCuttingByID(ID))
                {


                    _cuttingHeader.CuttingHeaderID = header.CuttingHeaderID;
                    txtCuttingTicketNo.Text = header.CuttingHeaderID;
                    txtStyleNo.Text = header.StyleID;
                    txtPlanQty.Text = Convert.ToString(header.PlanQuantity);
                    txtOrderQty.Text = Convert.ToString(header.OrderQuantity);
                    cmbItemType.Text = Convert.ToString(header.ItemType);
                    cmbStatus.Text = header.status;
                    txtRemark.Text = header.Remark;





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<CuttingHeader> GetCuttingByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
                return _SearchHeaderRepository.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private List<CuttingItem> GetCuttingItemByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingItem> _CuttingItem = new GenaricRepository<CuttingItem>(new ItrackContext());
                return _CuttingItem.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private List<CuttingItem> GetCuttingItem(int ID)
        {
            try
            {
                GenaricRepository<CuttingItem> _CuttingItem = new GenaricRepository<CuttingItem>(new ItrackContext());
                return _CuttingItem.GetAll().Where(u => u.CuttingItemID== ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private void FeedCuttingItem(string _headerId) {
            try {
               // grdItemList.DataSource = GetCuttingItemByID(_headerId);

                var selectedColumn = from item in GetCuttingItemByID(_headerId)
                                     select
                                     new {item.CuttingItemID,item.Date, item.PoNo,item.MarkerNo,item.LineNo,item.FabricType,item.Color,item.Size,item.Length,item.NoOfLayer,item.NoOfItem };
                grdItemList.DataSource = selectedColumn;
                gridView1.Columns["CuttingHeader"].Visible = false;
                gridView1.Columns["CuttingHeaderID"].Visible = false;
                gridView1.Columns["BundleHeader"].Visible = false;
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }

        
        }

        /// <summary>
        /// edit marker details selecting by griud view.get id form grid view by user selection
        /// </summary>
        /// <param name="id"></param>
        private void EditCuttingItem(int id) {
            try {

                GenaricRepository<CuttingItem> _CuttingItemrRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
            
                   
                 /*
                    _cuttingItem.CuttingHeaderID = item.CuttingHeaderID;
                    _cuttingItem.CuttingItemID = item.CuttingItemID;
                    _cuttingItem.MarkerNo = item.MarkerNo;
                    _cuttingItem.MarkerWidth = item.MarkerWidth;
                    _cuttingItem.MarkerLenth = item.MarkerLenth;
                    _cuttingItem.LineNo = item.LineNo;
                    _cuttingItem.Color = item.Color;
                    _cuttingItem.Size = item.Size;
                    _cuttingItem.Length = item.Length;
                    _cuttingItem.NoOfItem = item.NoOfItem;
                    _cuttingItem.NoOfLayer = item.NoOfLayer;
                    _cuttingItem.NoOfPlysLayed = item.NoOfPlysLayed;
                    _cuttingItem.NoOfPlysPlaned = item.NoOfPlysPlaned;
                    _cuttingItem.FabricType = item.FabricType;
                    */

                    _cuttingItem = AssignCuttingItem();
                    _cuttingItem.CuttingItemID = this.CItem;

                    _CuttingItemrRepo.Edit(_cuttingItem);

               
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        private void Remove(int id)
        {
            try {
                GenaricRepository<CuttingItem> _CuttingItemRepository = new GenaricRepository<CuttingItem>(new ItrackContext());
             
                _cuttingItem.CuttingItemID = id;
                _CuttingItemRepository.Delete(_cuttingItem);
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        }

        public int CItem { get; set; }
        private void getCuttingItem() {
            try {

                txtlineNo.Text = gridView1.GetFocusedRowCellValue("LineNo").ToString();
                txtMarkerNo.Text = gridView1.GetFocusedRowCellValue("MarkerNo").ToString();
                txtfabricType.Text = gridView1.GetFocusedRowCellValue("FabricType").ToString();
                txtColorCode.Text = gridView1.GetFocusedRowCellValue("Color").ToString();
                txtSize.Text = gridView1.GetFocusedRowCellValue("Size").ToString();
                txtLength.Text = gridView1.GetFocusedRowCellValue("Length").ToString();
                txtnoOfItem.Text = gridView1.GetFocusedRowCellValue("NoOfItem").ToString();
                txtnoOfLayers.Text = gridView1.GetFocusedRowCellValue("NoOfLayer").ToString();
               
                this.CItem =Convert.ToInt16( gridView1.GetFocusedRowCellValue("CuttingItemID").ToString());
                _cuttingItem.CuttingHeaderID = txtCuttingTicketNo.Text;
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }




        StyleVM _StyleVM = new StyleVM();

        private void SearchStyle()
        {
            try
            {
                _StyleVM.SearchStyle2(grdSearchStyle, txtStyleNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        LayinDetails fDetails = new LayinDetails();
        private LayinDetails AssignFabricDetails() {

            try {
                fDetails.StyleID = txtStyleNo.Text;
                fDetails.MarkerNo = txtMNo.Text;
                fDetails.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
                fDetails.FabricRollID = txtRoleNo.Text;
                fDetails.LayerLenth =Convert.ToDouble( txtRollWidth.Text);
                fDetails.FabricRollLenth =Convert.ToDouble( txtRollHegiht.Text);
                fDetails.NoofPlys =Convert.ToInt16( txtNoOfPlys.Text);
                fDetails.Rest =Convert.ToDouble( txtRest.Text);
                fDetails.FabricUsed =Convert.ToDouble( txtFabused.Text);
                fDetails.TotalPcs =Convert.ToInt16( txtTotalPcs.Text);

                return fDetails;
            }
            catch(Exception ex)
            {

                Debug.WriteLine(ex.Message); 
                return null;

            }
        
        
        }


        private void AddLayerDetails() {
            try {
                GenaricRepository<LayinDetails> _LayinDetailsRepo = new GenaricRepository<LayinDetails>(new ItrackContext());
                _LayinDetailsRepo.Add(AssignFabricDetails());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }



        void feedCombo() {
            try { 
                
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            
            }
        }

        void FeedLayinDetails(string _styleNo) {
            try {

                GenaricRepository<LayinDetails> _LayinDetailsRepo = new GenaricRepository<LayinDetails>(new ItrackContext());

              grdFabricDetails.DataSource =   _LayinDetailsRepo.GetAll().ToList().Where(x=>x.StyleID == _styleNo );
              gridView4.Columns["Style"].Visible = false;
            
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            
            }
        
        }


        private void EditLayerDetails()
        {
            try
            {
                GenaricRepository<LayinDetails> _LayinDetailsRepo = new GenaricRepository<LayinDetails>(new ItrackContext());
                _LayinDetailsRepo.Add(AssignFabricDetails());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void SetLayingDetails(string StyleNo) {
            try {
                GenaricRepository<LayinDetails> _LayinDetailsRepo = new GenaricRepository<LayinDetails>(new ItrackContext());
                grdFabricDetails.DataSource = _LayinDetailsRepo.GetAll().ToList().Where(x => x.StyleID == StyleNo);
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }



        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidCuttingMaster() == true)
            {
                AddCuttingHeader();
            }
            
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            SearchCuttingHeader();
            splashScreenManager1.CloseWaitForm();
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

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidCuttingMaster()
        {

            if (!validate.isPresent(txtCuttingTicketNo, "Cutting Ticket Number"))
            {
                return false;
            }

            if (!validate.isPresent(cmbItemType, "Item Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validate.isPresent(cmbStatus, "Status"))
            {
                return false;
            }

            if (!validate.isPresent(txtOrderQty, "Order Qyt"))
            {
                return false;
            }

            if (!validate.isPresent(txtPlanQty, "Plan Qty"))
            {
                return false;
            }

            return true;
        }

        public bool isValidMarker()
        {
            if (!validate.isPresent(txtlineNo, "Line Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtMarkerNo, "Marker Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtfabricType, "Fabric Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtColorCode, "Color Code"))
            {
                return false;
            }

            if (!validate.isPresent(txtLength, "Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtnoOfLayers, "Number of Layer"))
            {
                return false;
            }


            if (!validate.isPresent(txtSize, "Size"))
            {
                return false;
            }

            if (!validate.isPresent(txtnoOfItem, "Number of Item"))
            {
                return false;
            }

            return true;
        }



        public bool isValidLayer()
        {
            if (!validate.isPresent(txtRoleNo, "Fabric Roll ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtRollWidth, "Fabric Roll Width"))
            {
                return false;
            }

            if (!validate.isPresent(txtRollHegiht, "Fabric Roll Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtNoOfPlys, "No Of Plys"))
            {
                return false;
            }

            if (!validate.isPresent(txtRest, "Rest"))
            {
                return false;
            }

            if (!validate.isPresent(txtFabused, "Fabric Used"))
            {
                return false;
            }

            if (!validate.isPresent(txtTotalPcs, "Total PCS"))
            {
                return false;
            }
            return true;
        }








        #endregion

      

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _cuttingHeader.CuttingHeaderID = gridView3.GetFocusedRowCellValue("CuttingHeaderID").ToString();
                getCuttingFeild(_cuttingHeader.CuttingHeaderID);
                FeedCuttingItem(_cuttingHeader.CuttingHeaderID);
                FeedConmbo(txtSize);
                FeedColorCombo(txtColorCode);
                FeedLayinDetails(txtStyleNo.Text);
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();
                grdSearchStyle.Hide();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (isValidMarker() == true)
            {

                AddCuttingItem();
            }
            
           // AddBundleHeader();
            FeedCuttingItem(txtCuttingTicketNo.Text);
        }



        private void simpleButton5_Click(object sender, EventArgs e)
        {

            if (isValidLayer() == true)
            {
                if (isExistingItem(txtMNo.Text) == true)
                {
                    AddLayerDetails();
                    FeedLayinDetails(txtStyleNo.Text);
                }
                else
                {
                     MessageBox.Show("Please Check Marker No", "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            
           

                 
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dlgSizelist Sizelist = new dlgSizelist();
            Sizelist.ShowDialog();

        }

        private void frmCuttingMaster_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            grdSearchStyle.Hide();
        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
            if (btnEditItem.Text == "Edit")
            {
                getCuttingItem();
                btnEditItem.Text = "Update";
            }
            else {
                btnEditItem.Text = "Edit";
                EditCuttingItem(_cuttingItem.CuttingItemID);
                FeedCuttingItem(txtCuttingTicketNo.Text);
            }
           
           
        }



        void FeedConmbo(ComboBoxEdit combo)
        {
            try {
               
                ComboBoxItemCollection coll = combo.Properties.Items;

                GenaricRepository<PurchaseOrderItems> _PoRepo = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
                foreach (var items in _PoRepo.GetAll().Where(u => u.PurchaseOrderHeader.Style.StyleID == txtStyleNo.Text).Distinct())
                {
                    coll.Add(items.Size);

                } 

                            
                
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

      void FeedColorCombo(ComboBoxEdit combo)
        {
            try {
               
                ComboBoxItemCollection coll = combo.Properties.Items;

                GenaricRepository<PurchaseOrderItems> _PoRepo = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
                foreach (var items in _PoRepo.GetAll().Where(u => u.PurchaseOrderHeader.Style.StyleID == txtStyleNo.Text).Distinct())
                {
                    coll.Add(items.Color);

                } 

                            
                
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }




   

      GenaricRepository<Style> _Stylerepository = new GenaricRepository<Style>(new ItrackContext());
      private List<Style> GetStyleByID(string ID)
      {
          try
          {
              return _Stylerepository.GetAll().Where(u => u.StyleID == ID).ToList();


          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return null;

          }

      }
      void getStyleFeild(string ID)
      {
          try
          {

              foreach (var style in GetStyleByID(ID))
              {
                  txtStyleNo.Text = style.StyleID;
              
               


              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }



      private bool isExistingItem( string _markerNo) {
          try {
              GenaricRepository<CuttingItem> _CutItemrepo = new GenaricRepository<CuttingItem>(new ItrackContext());
              if (_CutItemrepo.GetAll().Where(x => x.MarkerNo == _markerNo).ToList().Count() > 0)
              {
                  return true;
              }
              else {
                  return false;
              }
          }
          catch(Exception ex){
             
              Debug.WriteLine(ex.Message);
              return false;
          }
      
      }

      private List<CuttingItem> GetCuttingDetailsReport( string _styleNo) {

          try 
          {
              GenaricRepository<CuttingItem> _CuttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
              return _CuttingItemRepo.GetAll().Where(x=>x.CuttingHeader.StyleID == _styleNo ).ToList();
          }
          catch(Exception ex)
          {
              Debug.WriteLine(ex.Message);
              return null;
          }
      
      }


      private List<LayinDetails> GetLayinDetailsReport(string _styleNo)
      {

          try
          {
              GenaricRepository<LayinDetails> _CuttingItemRepo = new GenaricRepository<LayinDetails>(new ItrackContext());
              return _CuttingItemRepo.GetAll().Where(x => x.StyleID == _styleNo).ToList();
          }
          catch (Exception ex)
          {
              Debug.WriteLine(ex.Message);
              return null;
          }

      }


      private List<CutReport> GetList() {
          GenaricRepository<CuttingItem> _CuttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
          List<CutReport> lst = new List<CutReport>();
          foreach (var item in _CuttingItemRepo.GetAll().ToList().Where(x=>x.CuttingHeader.StyleID==txtStyleNo.Text)) {
              lst.Add(new CutReport {StyleNo=item.CuttingHeader.StyleID, Date= item.Date,LineNo = item.LineNo,Color=item.Color,Size=item.Size,Pcs=item.NoOfItem});
          }
          return lst;
      }


      private XtraReport CreateReport()
      {
          // Create a blank report.
          XtraReport crossTabReport = new XtraReport();

          // Create a detail band and add it to the report.
          DetailBand detail = new DetailBand();
          crossTabReport.Bands.Add(detail);

          // Create a pivot grid and add it to the Detail band.
          XRPivotGrid pivotGrid = new XRPivotGrid();
          detail.Controls.Add(pivotGrid);

          //// Create a data connection.
          //OleDbConnection connection = new
          //OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\nwind.mdb");

          //// Create a data adapter.
          //OleDbDataAdapter adapter = new OleDbDataAdapter(
          //"SELECT CategoryName, ProductName, Country, [Sales Person], Quantity, [Extended Price] FROM SalesPerson",
          //connection);

          //// Creata and populate a dataset.
          //DataSet dataSet1 = new DataSet();
          //adapter.Fill(dataSet1, "SalesPerson");

          // Bind the pivot grid to data.
          pivotGrid.DataSource = GetList();
        //  pivotGrid.DataMember = "SalesPerson";

          // Generate pivot grid's fields.
         
          XRPivotGridField fieldProductName = new XRPivotGridField("LineNo", PivotArea.RowArea);
          XRPivotGridField fieldDate = new XRPivotGridField("Date", PivotArea.RowArea);
          XRPivotGridField fieldCountry = new XRPivotGridField("Size", PivotArea.ColumnArea);
         
          XRPivotGridField fieldQuantity = new XRPivotGridField("Pcs", PivotArea.DataArea);
          fieldDate.ValueFormat.FormatString = "d";

          // Add these fields to the pivot grid.
          pivotGrid.Fields.AddRange(new XRPivotGridField[] {fieldDate, fieldProductName, fieldCountry,
         fieldQuantity});

          return crossTabReport;
      }




      private void GetCuttingDetailsReport() {
          try {
           //   rptCuttingDetails report = new rptCuttingDetails();
            //  report.DataSource = GetCuttingDetailsReport(txtStyleNo.Text);

             rptCutS report = new rptCutS();
             report.DataSource = GetList();
             report.Landscape = true;
             ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
          }
          catch(Exception ex){
              Debug.WriteLine(ex.Message);
          }
      
      }


      private void GetFabricDetailsReport()
      {
          try
          {
              MatirialDetails report = new MatirialDetails();
              report.DataSource = GetLayinDetailsReport(txtStyleNo.Text);

              ReportPrintTool tool = new ReportPrintTool(report);
              tool.ShowPreview();
          }
          catch (Exception ex)
          {
              Debug.WriteLine(ex.Message);
          }

      }




        private void simpleButton4_Click(object sender, EventArgs e)
        {
            _cuttingItem.CuttingItemID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("CuttingItemID").ToString());
            Remove(_cuttingItem.CuttingItemID);
            FeedCuttingItem(txtCuttingTicketNo.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            SearchStyle();
        }

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
                getStyleFeild(_Style.StyleID);
                grdSearchStyle.Hide();
              
            }
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
           // GetCuttingDetailsReport();
            // Create a cross-tab report.
         // XtraReport report = CreateReport();

            // Show its Print Preview.
            // report.ShowPreview();
            GetCuttingDetailsReport();


          

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            GetFabricDetailsReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }
    }
}