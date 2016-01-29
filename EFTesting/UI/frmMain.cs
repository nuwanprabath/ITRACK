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
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;

namespace EFTesting.UI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.TouchSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            
            ribbonControl1.Minimized = true;

            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown();
            gallery.Manager = barManager1;
            SkinHelper.InitSkinGalleryDropDown(gallery);
            gallery.ShowPopup(MousePosition);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmCompany objfrmMChild = new UI.frmCompany();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmBuyer objfrmMChild = new UI.frmBuyer();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmStyleMaster objfrmMChild = new UI.frmStyleMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.EmployeeMaster objfrmMChild = new UI.EmployeeMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmPurchaseOrder objfrmMChild = new UI.frmPurchaseOrder();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmSketchMaster objfrmMChild = new UI.frmSketchMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmParts objfrmMChild = new UI.frmParts();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmOperation objfrmMChild = new UI.frmOperation();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmCuttingMaster objfrmMChild = new UI.frmCuttingMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmDividingPlan objfrmMChild = new UI.frmDividingPlan();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmBundlingMaster objfrmMChild = new UI.frmBundlingMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmOparationScaning objfrmMChild = new UI.frmOparationScaning();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmProduction objfrmMChild = new UI.frmProduction();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnDayend_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmDayend objfrmMChild = new UI.frmDayend();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPoDeliveriesDialog dialog = new frmPoDeliveriesDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHourlyProductionDialog dialog = new frmHourlyProductionDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmIndividualProductionDialog dialog = new frmIndividualProductionDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmScaningTimeScadual objfrmMChild = new UI.frmScaningTimeScadual();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmOfflineScaning objfrmMChild = new UI.frmOfflineScaning();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            dailyProductionDialog dialog = new dailyProductionDialog();
            dialog.ShowDialog();

        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            dlgBundleSelect dialog = new dlgBundleSelect();
            dialog.ShowDialog();
        }
    }
}