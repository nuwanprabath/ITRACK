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
using EFTesting.Reports;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Diagnostics;

namespace EFTesting.UI
{
    public partial class frmProduction : DevExpress.XtraEditors.XtraForm
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        StyleVM _StyleVM = new StyleVM();
        GenaricRepository<Style> _Stylerepository = new GenaricRepository<Style>(new ItrackContext());

        GenaricRepository<OprationBarcodes> _OperationBarcode = new GenaricRepository<OprationBarcodes>(new ItrackContext());
       
        Style _Style = new Style();

        private void SearchStyle()
        {
            try
            {
                _StyleVM.SearchStyle(grdSearchStyle, txtSearchBox, btnClose);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        void getStyleFeild(string ID)
        {
            try
            {

                foreach (var style in GetStyleByID(ID))
                {
                    txtStyleNo.Text = style.StyleID;
                    txtGarmentType.Text = style.GarmantType;
                    txtStatus.Text = style.Status;
                    txtBuyerName.Text = style.Buyer.BuyerName;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchStyle();
        }

        private void grdSearchStyle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
                getStyleFeild(_Style.StyleID);
           
                grdSearchStyle.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
   
            }
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

          clsProductionSummary p = new clsProductionSummary();
          Cursor.Current = Cursors.WaitCursor;
          grdProduction.DataSource =   p.GetInputCount();

          Cursor.Current = Cursors.Default;

          // Create and setup the second summary item 
        /*
          GridView View = gridView1;
          gridView1.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
          GridGroupSummaryItem item1 = new GridGroupSummaryItem();
       
          item1.FieldName = "NoOfItems";
          item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
          item1.DisplayFormat = "No Of Item = {0}";
          item1.ShowInGroupColumnFooter = View.Columns["LineOut"];
          item1.Tag = "No Of Items";


          View.GroupSummary.Add(item1);
           */

          gridView1.Columns["LineOut"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "LineOut", "Sum={0}");




        }



        #region DayEND

        public void GetProductionDaySummary(DateTime dayendDate) {

            try {
                var itemList = from items in _OperationBarcode.GetAll().ToList()
                               
                               where items.OprationRole == "In" && items.isOparationComplete == true && items.OprationComplteAt.Day == dayendDate.Day && items.OprationComplteAt.Month == dayendDate.Month && items.OprationComplteAt.Year == dayendDate.Year
                              
                               group items by new { items.OprationComplteAt.Date, items.LineNo, items.StyleNo, items.BundleDetails.BundleHeader.CuttingItem.Color, items.BundleDetails.BundleHeader.CuttingItem.Size } into ItemG
                               
                               select new {ItemG.Key.Date,ItemG.Key.LineNo,ItemG.Key.StyleNo,ItemG.Key.Color,ItemG.Key.Size, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };


                foreach (var items in itemList) {

                    Debug.WriteLine("Date :" + items.Date.Date + " Line No - " + items.LineNo + " Style No " + items.StyleNo + " Color -" + items.Color + " Size -" + items.Size + " In - " + items.Count);
                
                }
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);

            
            }
        
        }

        #endregion 

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
          //  GetProductionDaySummary(DateTime.Now);
           // clsProductionSummary p = new clsProductionSummary();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}