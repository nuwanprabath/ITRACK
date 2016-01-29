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
            p.getSampleDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}