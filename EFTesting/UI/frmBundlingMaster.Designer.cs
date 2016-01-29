namespace EFTesting.UI
{
    partial class frmBundlingMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.grdItemList = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBundleSize = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlanQty = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderQty = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuttingTicketNo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.grdBundleTicket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSNo = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EFTesting.UI.WaitForm1), true, true);
            this.grdBundleListPrinted = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBundleSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuttingTicketNo.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBundleTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBundleListPrinted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(9, 64);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1172, 409);
            this.xtraTabControl1.TabIndex = 42;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.grdItemList);
            this.xtraTabPage1.Controls.Add(this.label12);
            this.xtraTabPage1.Controls.Add(this.txtBundleSize);
            this.xtraTabPage1.Controls.Add(this.label11);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.txtPlanQty);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.txtOrderQty);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtCuttingTicketNo);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1133, 403);
            this.xtraTabPage1.Text = "Genarate Bundle Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ready To Genarate Tags/ Cutting Items";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(16, 366);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 62;
            this.simpleButton3.Text = "Genarate";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // grdItemList
            // 
            this.grdItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdItemList.Location = new System.Drawing.Point(16, 72);
            this.grdItemList.MainView = this.gridView2;
            this.grdItemList.Name = "grdItemList";
            this.grdItemList.Size = new System.Drawing.Size(1102, 288);
            this.grdItemList.TabIndex = 58;
            this.grdItemList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdItemList;
            this.gridView2.Name = "gridView2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(826, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Bundle Size";
            // 
            // txtBundleSize
            // 
            this.txtBundleSize.EditValue = "";
            this.txtBundleSize.Location = new System.Drawing.Point(829, 49);
            this.txtBundleSize.Name = "txtBundleSize";
            this.txtBundleSize.Properties.AccessibleDescription = "";
            this.txtBundleSize.Properties.NullValuePrompt = "Bundle Size";
            this.txtBundleSize.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtBundleSize.Size = new System.Drawing.Size(195, 20);
            this.txtBundleSize.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(221, 49);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Style No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(210, 20);
            this.txtStyleNo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Plane Qty";
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.EditValue = "";
            this.txtPlanQty.Location = new System.Drawing.Point(628, 49);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Properties.AccessibleDescription = "";
            this.txtPlanQty.Properties.NullValuePrompt = "Plan Qty";
            this.txtPlanQty.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPlanQty.Size = new System.Drawing.Size(195, 20);
            this.txtPlanQty.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Order Qty";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.EditValue = "";
            this.txtOrderQty.Location = new System.Drawing.Point(437, 49);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Properties.AccessibleDescription = "";
            this.txtOrderQty.Properties.NullValuePrompt = "Order Qty";
            this.txtOrderQty.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOrderQty.Size = new System.Drawing.Size(185, 20);
            this.txtOrderQty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cutting Ticket No";
            // 
            // txtCuttingTicketNo
            // 
            this.txtCuttingTicketNo.EditValue = "";
            this.txtCuttingTicketNo.Location = new System.Drawing.Point(18, 49);
            this.txtCuttingTicketNo.Name = "txtCuttingTicketNo";
            this.txtCuttingTicketNo.Properties.AccessibleDescription = "";
            this.txtCuttingTicketNo.Properties.NullValuePrompt = "Cutting Ticket No";
            this.txtCuttingTicketNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCuttingTicketNo.Size = new System.Drawing.Size(197, 20);
            this.txtCuttingTicketNo.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.grdBundleTicket);
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1133, 403);
            this.xtraTabPage2.Text = "Print Bundle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Ready To Print Tags/ Bundle Ticket";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Location = new System.Drawing.Point(16, 369);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 74;
            this.simpleButton4.Text = "Print";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // grdBundleTicket
            // 
            this.grdBundleTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBundleTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdBundleTicket.Location = new System.Drawing.Point(16, 39);
            this.grdBundleTicket.MainView = this.gridView1;
            this.grdBundleTicket.Name = "grdBundleTicket";
            this.grdBundleTicket.Size = new System.Drawing.Size(1102, 324);
            this.grdBundleTicket.TabIndex = 73;
            this.grdBundleTicket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdBundleTicket;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.grdBundleListPrinted);
            this.xtraTabPage3.Controls.Add(this.txtSNo);
            this.xtraTabPage3.Controls.Add(this.simpleButton5);
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1133, 403);
            this.xtraTabPage3.Text = "F/Consumption";
            // 
            // txtSNo
            // 
            this.txtSNo.Location = new System.Drawing.Point(16, 65);
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(222, 21);
            this.txtSNo.TabIndex = 60;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(269, 65);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 59;
            this.simpleButton5.Text = "Add";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(286, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(763, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 48;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(472, 16);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 47;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(376, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(195, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(103, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(12, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "New";
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(9, 50);
            this.grdSearch.MainView = this.gridView3;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(1164, 61);
            this.grdSearch.TabIndex = 63;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.grdSearch.Click += new System.EventHandler(this.grdSearch_Click);
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSearch;
            this.gridView3.Name = "gridView3";
            // 
            // grdBundleListPrinted
            // 
            this.grdBundleListPrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBundleListPrinted.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdBundleListPrinted.Location = new System.Drawing.Point(16, 92);
            this.grdBundleListPrinted.MainView = this.gridView4;
            this.grdBundleListPrinted.Name = "grdBundleListPrinted";
            this.grdBundleListPrinted.Size = new System.Drawing.Size(1102, 324);
            this.grdBundleListPrinted.TabIndex = 74;
            this.grdBundleListPrinted.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdBundleListPrinted;
            this.gridView4.Name = "gridView4";
            // 
            // frmBundlingMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 495);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmBundlingMaster";
            this.Text = "Bundling Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBundlingMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBundleSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuttingTicketNo.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBundleTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBundleListPrinted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPlanQty;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtOrderQty;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtCuttingTicketNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.TextBox txtSNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtBundleSize;
        private DevExpress.XtraGrid.GridControl grdItemList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl grdBundleTicket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl grdBundleListPrinted;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}