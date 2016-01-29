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
using System.Diagnostics;

namespace EFTesting.UI
{
    public partial class frmStyleMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmStyleMaster()
        {
            InitializeComponent();
        }

        #region  Delcaration
            GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
            GenaricRepository<Buyer> _BuyerRepository = new GenaricRepository<Buyer>(new ItrackContext());
            GenaricRepository<Style> _Stylerepository = new GenaricRepository<Style>(new ItrackContext());
            Buyer _Buyer = new Buyer();
            Company _Company = new Company();
            Style _Style = new Style();
            StyleVM _StyleVM = new StyleVM();
            Validator Validator = new Validator();
        #endregion



        #region CRUD


            void Clear() {
                try {
                    txtStyleNo.Text = "";
                    txtArticle.Text = "";
                    txtSeason.Text = "";
                    txtRemark.Text = "";
                    txtBuyerName.Text = "";
                    cmbGarmentType.Text = "";
                    cmbStatus.Text = "";
                    txtStyleNo.Focus();
                    grdSearchBuyer.Hide();
                    btnClose.Hide();

                }
                catch(Exception ex){
                    Debug.WriteLine(ex.Message);
                }
            
            }
        Style AssignStyle() {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                _Style.StyleID = txtStyleNo.Text;
                _Style.Article = txtArticle.Text;
                _Style.Season = txtSeason.Text;
                _Style.CompanyID = _Company.CompanyID;
                _Style.Remark = txtRemark.Text;
                _Style.Status = cmbStatus.Text; 
                _Style.BuyerID = _Buyer.BuyerID;
                _Style.GarmantType = cmbGarmentType.Text;
                _Style.FeedingRule = cmbFeedingRule.Text;
                _Style.ForecastingRule = cmbForecastingRule.Text;
                _Style.WorkflowID= 1 ;
               

                return _Style;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void SearchBuyer()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Buyer), "s");
                Expression nameProperty = Expression.Property(argParam, "BuyerName");
                Expression namespaceProperty = Expression.Property(argParam, "BuyerName");

                var val1 = Expression.Constant(txtBuyerName.Text);
                var val2 = Expression.Constant(txtBuyerName.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Buyer, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _BuyerRepository.SearchFor(lambda1).ToList() select new { item.BuyerID, item.BuyerName, item.BuyerTeleNo, item.FaxNo, item.BuyerShippingAddress };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchBuyer.Show();
                    btnClose.Show();

                    grdSearchBuyer.DataSource = selected;
                }
                else
                {
                    grdSearchBuyer.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SearchStyle() {
            try {
                _StyleVM.SearchStyle(grdSearchStyle, txtSearchBox, btnClose);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void AddStyle()
        {
            try
            {
                _Stylerepository.Add(AssignStyle());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void editStyle()
        {


            try
            {
                GenaricRepository<Style> _genaricrepositoryStylenew = new GenaricRepository<Style>(new ItrackContext());
                await _genaricrepositoryStylenew.EditAsync(AssignStyle());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getStyleFeild(string ID)
        {
            try
            {

                foreach (var style in GetStyleByID(ID))
                {
                    txtStyleNo.Text = style.StyleID;
                    txtBuyerName.Text = style.Buyer.BuyerName;
                    txtArticle.Text = style.Article;
                    cmbStatus.Text = style.Status;
                    cmbGarmentType.Text = style.GarmantType;
                    txtRemark.Text = style.Remark;
                    _Company.CompanyID = style.CompanyID;
                    txtSeason.Text = style.Season;
                    cmbFeedingRule.Text = style.FeedingRule;
                    cmbForecastingRule.Text = style.ForecastingRule;
                    _Buyer = style.Buyer;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
        #endregion



        #region FabricDetails 
        FabricDetails fDetails = new FabricDetails();
        FabricDetails AssignfDetails() {
            try {

                fDetails.FabricType = cmbFabricType.Text;
                fDetails.FabricName = txtFabricName.Text;
                fDetails.Color = txtFabricColor.Text;
                fDetails.PlanedConsumtion =Convert.ToDouble( txtPlanedConsumtion.Text);
                fDetails.Remark = txtfRemark.Text;
                fDetails.StyleID = txtStyleNo.Text;
                fDetails.FabricDetailsID = this.fDetailsID;
                return fDetails;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }


        bool AddFabricDetails() {
            try {
                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                _FabricDetailsRepository.Add(AssignfDetails());
                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }

        }


        bool EditFabricDetails()
        {
            try
            {
                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                _FabricDetailsRepository.Edit(AssignfDetails());
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        List<FabricDetails> lstFabric = new List<FabricDetails>();
        List<FabricDetails> GetFabricList(string _styleNo) {
            try {

                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                var list = from items in _FabricDetailsRepository.GetAll().Where(u => u.StyleID == _styleNo).ToList() select new { items.FabricDetailsID,items.FabricType,items.FabricName,items.Color,items.PlanedConsumtion,items.Remark};
                grdFabricList.DataSource = list;

                return lstFabric;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;

            }
        
        }

        public int fDetailsID { get; set; }

        void GetFabricDetailsField() {
            try
            {
                cmbFabricType.Text = gridView3.GetFocusedRowCellValue("FabricType").ToString();
                txtFabricName.Text = gridView3.GetFocusedRowCellValue("FabricName").ToString();
                txtFabricColor.Text = gridView3.GetFocusedRowCellValue("Color").ToString();
                txtPlanedConsumtion.Text = gridView3.GetFocusedRowCellValue("PlanedConsumtion").ToString();
                txtfRemark.Text = gridView3.GetFocusedRowCellValue("Remark").ToString();
                this.fDetailsID = Convert.ToInt16(gridView3.GetFocusedRowCellValue("FabricDetailsID").ToString());
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        
        }

        #endregion 

        #region events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidStyleMaster() == true)
            AddStyle();
        }

        private void txtBuyerName_EditValueChanged(object sender, EventArgs e)
        {
            SearchBuyer();
        }

        private void txtBuyerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchBuyer.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchBuyer.Hide();

            }
        }

        private void grdSearchBuyer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Buyer.BuyerID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("BuyerID").ToString());
                _Buyer.BuyerName = gridView1.GetFocusedRowCellValue("BuyerName").ToString();
                txtBuyerName.Text = _Buyer.BuyerName;
                grdSearchBuyer.Hide();
            }



        }

        private void frmStyleMaster_Load(object sender, EventArgs e)
        {
            grdSearchBuyer.Hide();
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchStyle();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
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
                _Style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
                getStyleFeild(_Style.StyleID);
                GetFabricList(_Style.StyleID);
                grdSearchStyle.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
                grdSearchBuyer.Hide();
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editStyle();
        }
        #endregion

        #region validation
        public bool isValidStyleMaster()
        {


            if (!Validator.isPresent(txtStyleNo, "Style No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtBuyerName, "Buyer Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtArticle, "Article"))
            {
                return false;
            }

            if (!Validator.isPresent(txtSeason, "Season"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbGarmentType, "Garment Type"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbStatus, "Status"))
            {
                return false;
            }
            if (!Validator.isPresent(cmbFeedingRule, "Feeding Rule"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbForecastingRule, "Forecasting Rule"))
            {
                return false;
            }

            return true;
        }


        public bool isValidFabricDetails()
        {
            if (!Validator.isPresent(cmbFabricType, "Fabric Type"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFabricName, "Fabric Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFabricColor, "Fabric Color"))
            {
                return false;
            }

            if (!Validator.isPresent(txtPlanedConsumtion, "Planed Consumption"))
            {
                return false;
            }



            return true;
        }
        #endregion

        private void btnfAdd_Click(object sender, EventArgs e)
        {
            if (isValidFabricDetails() == true)
            {
                AddFabricDetails();
                GetFabricList(txtStyleNo.Text);
            }
            
            
        }

        private void btnfUpdate_Click(object sender, EventArgs e)
        {
            if (btnfUpdate.Text == "Edit")
            {
                GetFabricDetailsField();
                btnfUpdate.Text = "Update";
            }
            else
            {
                btnfUpdate.Text = "Edit";
                EditFabricDetails();
                GetFabricList(txtStyleNo.Text);
            }
        }


    }
}