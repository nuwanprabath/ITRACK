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
using System.Linq.Expressions;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.ViewModel;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmBundlingMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmBundlingMaster()
        {
            InitializeComponent();
        }

        CuttingHeader _cuttingHeader = new CuttingHeader();
        CuttingItem _cuttingItem = new CuttingItem();
        #region CRUD


       

    /// <summary>
    /// 
    /// </summary>
        private void SearchCuttingHeader()
        {

            try
            {

                splashScreenManager1.ShowWaitForm();
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

               splashScreenManager1.CloseWaitForm();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
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
                





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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


        private void GetBundleHeaderDetails()
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeader = new GenaricRepository<BundleHeader>(new ItrackContext());
                

                var selected = from items in _BundleHeader.GetAll().ToList()
                               where items.isBundleTagsGerated == true && items.CuttingItem.CuttingHeaderID ==txtCuttingTicketNo.Text

                               select items;

              //  grdBundleTicket.DataSource = _BundleHeader.GetAll().Where(x => x.isBundleTagsGerated == true).ToList();
                grdBundleTicket.DataSource = selected;
                gridView1.Columns["isOprationTagGenated"].Visible = false;
                gridView1.Columns["OprationTagGenaratedTime"].Visible = false;
                gridView1.Columns["CuttingItem"].Visible = false;

              //  return _BundleHeader.GetAll().Where(x => x.isBundleTagsGerated == true).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return null;

            }

        }


       
        // check if exist bundle header related to cutting item and remove it from to genarate grid
        List<CuttingItem> RemovedItem(List<CuttingItem> lst)
        {
            try {
                List<CuttingItem> lstItems = new List<CuttingItem>();
              
                int i = 0;
           
                 GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                 foreach (var items in lst)
                 {


                     if (_bhRepo.GetAll().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                     {
                      
                     }
                     else {
                         lstItems.Add(items);
                     }

                    i = i + 1;
                    
                    }


                 return lstItems;

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
             
            }
        }




        List<CuttingItem> PrintBundleItem(List<CuttingItem> lst)
        {
            try
            {
                List<CuttingItem> lstItemsPrint = new List<CuttingItem>();

                int i = 0;

                GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                foreach (var items in lst)
                {


                    if (_bhRepo.GetAll().ToList().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                    {
                        lstItemsPrint.Add(items);
                    }
                    else
                    {
                      
                    }

                    i = i + 1;

                }


                return lstItemsPrint;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_headerId"></param>
        private void FeedCuttingItem(string _headerId)
        {
            try
            {
             //  Debug.WriteLine(RemovedItem(GetCuttingItemByID(_headerId)).Count);
                
           grdItemList.DataSource =RemovedItem(GetCuttingItemByID(_headerId));

              
             //   grdBundleTicket.DataSource = PrintBundleItem(GetCuttingItemByID(_headerId));
             //   FeedPrintItemList(Convert.ToInt16(_headerId));

              //  grdBundleTicket.DataSource = PrintBundleItem(GetCuttingItemByID(_headerId));

                gridView2.Columns["CuttingHeader"].Visible = false;
                gridView2.Columns["CuttingHeaderID"].Visible = false;
                gridView2.Columns["BundleHeader"].Visible = false;
                gridView2.Columns["NoOfPlysLayed "].Visible = false;

                //gridView1.Columns["CuttingHeader"].Visible = false;
                //gridView1.Columns["CuttingHeaderID"].Visible = false;
                //gridView1.Columns["BundleHeader"].Visible = false;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void GenareteTags() {
            try {
                AddBundleHeader();
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        }

        private void AddBundleHeader()
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                _BundleHeaderRepository.Add(AssignBundleHeader());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }




        private Int64 GetBundleHeaderID() {
            try {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                return  _BundleHeaderRepository.GetAll().ToList().Last().BundleHeaderID;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return 0;
            }
        }


        void UpdateBundleStatus()
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                BundleHeader _header = new BundleHeader();
                _header = AssignBundleHeader();
                _header.isCompleteGenarateTags = true;
                _header.BundleTagGenaratedBy = "Admin";
                _header.BundleTagGenaratedTime =Convert.ToString( DateTime.Now);
                _header.GenaratedDate = DateTime.Now;
                _header.CuttingItemID = BundleHID;
                _BundleHeaderRepository.Update(_header);
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }







        BundleHeader _BundleHeader = new BundleHeader();
        int BundleHID = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BundleHeader AssignBundleHeader()
        {
            try
            {


            
                _BundleHeader.BundleTagGenaratedTime = Convert.ToString(DateTime.Now);
                _BundleHeader.isBundleTagsGerated = true;
                _BundleHeader.isOprationTagGenated = false;
                _BundleHeader.OprationTagGenaratedTime = "None";
                _BundleHeader.OprationTagGeratedBy = "None";
                _BundleHeader.CuttingItemID =Convert.ToInt16(gridView2.GetFocusedRowCellValue("CuttingItemID").ToString());

                _BundleHeader.isCompleteGenarateTags = true;
                _BundleHeader.BundleTagGenaratedBy = "Admin";
                _BundleHeader.BundleTagGenaratedTime = Convert.ToString(DateTime.Now);
                _BundleHeader.GenaratedDate = DateTime.Now;


                BundleHID = _BundleHeader.CuttingItemID;


                return _BundleHeader;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


     
        private void GenarateTags() {
            try {

                if (gridView2.RowCount > 0) {
                    Cursor.Current = Cursors.WaitCursor;
                    _cuttingHeader.CuttingHeaderID = txtCuttingTicketNo.Text;
                    
                    // add bundle Header 
                    GenareteTags();


                    GenarateTags gen = new GenarateTags();
                    Int64 bundlehader = GetBundleHeaderID();
                    string _lineNo = gridView2.GetFocusedRowCellValue("LineNo").ToString();
                    string _StyleNo = txtStyleNo.Text;
                    int _noofItem = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfItem").ToString());
                    int _noofLayer = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfLayer").ToString());
                    int _bundleSize = Convert.ToInt16(txtBundleSize.Text);

                    List<OprationBarcodes> lst = new List<OprationBarcodes>();
                    //genarate opration tags 
                    gen.GenrateBundleTags(_noofLayer, _noofItem/_noofLayer, _bundleSize, bundlehader, _StyleNo, _lineNo, lst,txtStyleNo.Text);
                    //Feed Cutting Items 
                    FeedCuttingItem(_cuttingHeader.CuttingHeaderID);

                    GetBundleHeaderDetails();


                    //using sql bulk copy
                    SqlBulkCopyHelper _helper = new SqlBulkCopyHelper();

                    // Copy data set using Sql Bulk Copy helper 
                    _helper.PerformBulkCopy(_helper.ConvertTagsToDatatable(lst));

                    Debug.WriteLine(lst.Count + "Count Of Record");
                   
                    //update Bundle Header Deta
                   // UpdateBundleStatus();
                    Cursor.Current = Cursors.Default;


                }
               

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }



        private void FeedPrintItemList(int cutID) {
            
            GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
            
            try {
                var print = from item in _bhRepo.GetAll().ToList() where item.CuttingItemID == cutID select new { item.CuttingItemID,item.CuttingItem.CuttingHeader.StyleID, item.CuttingItem.MarkerNo, item.BundleHeaderID, item.CuttingItem.Size, item.CuttingItem.NoOfLayer, item.CuttingItem.Date };
                grdBundleTicket.DataSource = print;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        private bool GenarateOprationBarcode() {
            try {


                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }
        }







        #endregion

        #region Diclaration

        Validator validator = new Validator();

        #endregion

        #region Valiadtion

        public bool isValidBundlingMaster()
        {

            if (!validator.isPresent(txtCuttingTicketNo, "Cutting Ticket Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtOrderQty, "Order Qty"))
            {
                return false;
            }

            if (!validator.isPresent(txtPlanQty, "Plan Qty"))
            {
                return false;
            }

            if (!validator.isPresent(txtBundleSize, "Bundle Size"))
            {
                return false;
            }

            return true;


        }


        #endregion


     

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
          
          SearchCuttingHeader();
          
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
           splashScreenManager1.ShowWaitForm();
          _cuttingHeader.CuttingHeaderID = gridView3.GetFocusedRowCellValue("CuttingHeaderID").ToString();
          getCuttingFeild(_cuttingHeader.CuttingHeaderID);
        
          FeedCuttingItem(_cuttingHeader.CuttingHeaderID);
         
          GetBundleHeaderDetails();
          grdSearch.Hide();
          txtSearchBox.Hide();
          btnClose.Hide();
          splashScreenManager1.CloseWaitForm();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (txtBundleSize.Text != "")
            {
                GenarateTags();

            }
            else
            {
                MessageBox.Show("Please Fill Bundle Size", "Error Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBundleSize.Focus();
            }

            

           // GenarateTags gn = new GenarateTags();
           // Cursor.Current = Cursors.WaitCursor;
            //gn.genarateTestData();
           // Cursor.Current = Cursors.Default;
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            
       //   gen.genarateBundle(150, 20, 20);
          
            
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmBundlingMaster_Load(object sender, EventArgs e)
        {
            
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            txtSearchBox.Focus();
            btnClose.Show();
            btnClose.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            GenaricRepository<OprationBarcodes> _OprationBarcodesRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
         var t  =  from item in _OprationBarcodesRepository.GetAll().ToList()  where item.BundleDetails.BundleHeader.CuttingItemID == 1 orderby item.OprationBarcodesID select item;
        Debug.WriteLine( t.Count());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try {
                frmBundlePrintoption _option = new frmBundlePrintoption();
                _option.ShowDialog();
                splashScreenManager1.ShowWaitForm();
                int CutNo = Convert.ToInt16(gridView1.GetFocusedRowCellValue("CuttingItemID").ToString());
                //  frmPrintBarcode print = new frmPrintBarcode(_barcode);
                frmBundlePrintoption p = new frmBundlePrintoption();
                Cursor.Current = Cursors.Default;
                p.ShowDialog();
                splashScreenManager1.CloseWaitForm();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

           
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void grdSearch_Click(object sender, EventArgs e)
        {

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

            }
        }



        void FeedBundleDetails(string _styleID) {

            try {
                GenaricRepository<BundleDetails> _bhRepo = new GenaricRepository<BundleDetails>(new ItrackContext());



                var print = from item in _bhRepo.GetAll().ToList() where item.BundleHeader.CuttingItem.CuttingHeader.StyleID == _styleID select new { item.BundleNo,item.NoOfItem,item.BundleHeader.CuttingItem.Size,item.BundleHeader.CuttingItem.NoOfLayer};
                grdBundleListPrinted.DataSource = print;
            }
            catch(Exception ex){

            
            }
        
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FeedBundleDetails(txtSNo.Text);
        }
    }
}