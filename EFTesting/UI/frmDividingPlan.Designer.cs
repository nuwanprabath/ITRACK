namespace EFTesting.UI
{
    partial class frmDividingPlan
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductionPerHour = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTarget = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalEmployee = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLineNo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDividingPlanNo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.grdOpration = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnProcess = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionPerHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDividingPlanNo.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(303, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(871, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(580, 35);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 12;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(484, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(212, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(120, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(29, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(29, 78);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1031, 478);
            this.xtraTabControl1.TabIndex = 48;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label24);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Controls.Add(this.label11);
            this.xtraTabPage1.Controls.Add(this.txtProductionPerHour);
            this.xtraTabPage1.Controls.Add(this.label9);
            this.xtraTabPage1.Controls.Add(this.txtTarget);
            this.xtraTabPage1.Controls.Add(this.label8);
            this.xtraTabPage1.Controls.Add(this.txtTotalEmployee);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.txtLineNo);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.txtRemark);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtDividingPlanNo);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(992, 472);
            this.xtraTabPage1.Text = "Header";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(79, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(249, 13);
            this.label24.TabIndex = 86;
            this.label24.Text = "Dividing Plan Genaral Information / Header Details ";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(635, 55);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(251, 20);
            this.txtStyleNo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Style No";
            // 
            // txtProductionPerHour
            // 
            this.txtProductionPerHour.EditValue = "";
            this.txtProductionPerHour.Location = new System.Drawing.Point(635, 89);
            this.txtProductionPerHour.Name = "txtProductionPerHour";
            this.txtProductionPerHour.Properties.AccessibleDescription = "";
            this.txtProductionPerHour.Properties.NullValuePrompt = "Please Enter Production Per Hour";
            this.txtProductionPerHour.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtProductionPerHour.Size = new System.Drawing.Size(251, 20);
            this.txtProductionPerHour.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Production Per Hour";
            // 
            // txtTarget
            // 
            this.txtTarget.EditValue = "";
            this.txtTarget.Location = new System.Drawing.Point(197, 119);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Properties.AccessibleDescription = "";
            this.txtTarget.Properties.NullValuePrompt = "Please Enter Target";
            this.txtTarget.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTarget.Size = new System.Drawing.Size(251, 20);
            this.txtTarget.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Target";
            // 
            // txtTotalEmployee
            // 
            this.txtTotalEmployee.EditValue = "";
            this.txtTotalEmployee.Location = new System.Drawing.Point(635, 123);
            this.txtTotalEmployee.Name = "txtTotalEmployee";
            this.txtTotalEmployee.Properties.AccessibleDescription = "";
            this.txtTotalEmployee.Properties.NullValuePrompt = "Please Enter Total Employee";
            this.txtTotalEmployee.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTotalEmployee.Size = new System.Drawing.Size(251, 20);
            this.txtTotalEmployee.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Line No";
            // 
            // txtLineNo
            // 
            this.txtLineNo.EditValue = "";
            this.txtLineNo.Location = new System.Drawing.Point(198, 89);
            this.txtLineNo.Name = "txtLineNo";
            this.txtLineNo.Properties.AccessibleDescription = "";
            this.txtLineNo.Properties.NullValuePrompt = "Please Enter Line Number";
            this.txtLineNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLineNo.Size = new System.Drawing.Size(251, 20);
            this.txtLineNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total Employee";
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(197, 151);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullValuePrompt = "Remark";
            this.txtRemark.Size = new System.Drawing.Size(289, 96);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.UseOptimizedRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Dividing Plan No";
            // 
            // txtDividingPlanNo
            // 
            this.txtDividingPlanNo.EditValue = "";
            this.txtDividingPlanNo.Location = new System.Drawing.Point(198, 59);
            this.txtDividingPlanNo.Name = "txtDividingPlanNo";
            this.txtDividingPlanNo.Properties.AccessibleDescription = "";
            this.txtDividingPlanNo.Properties.NullValuePrompt = "Please Enter Dividing Plan Number";
            this.txtDividingPlanNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDividingPlanNo.Size = new System.Drawing.Size(251, 20);
            this.txtDividingPlanNo.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton6);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.textEdit2);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.textEdit1);
            this.xtraTabPage2.Controls.Add(this.simpleButton3);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.grdOpration);
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(992, 472);
            this.xtraTabPage2.Text = "Oparation";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton6.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton6.Location = new System.Drawing.Point(108, 402);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(85, 39);
            this.simpleButton6.TabIndex = 92;
            this.simpleButton6.Text = "List";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Approved At";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(566, 407);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AccessibleDescription = "";
            this.textEdit2.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit2.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit2.Size = new System.Drawing.Size(181, 20);
            this.textEdit2.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Approve Code";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(381, 407);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AccessibleDescription = "";
            this.textEdit1.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit1.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Size = new System.Drawing.Size(181, 20);
            this.textEdit1.TabIndex = 50;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton3.Location = new System.Drawing.Point(290, 402);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 39);
            this.simpleButton3.TabIndex = 88;
            this.simpleButton3.Text = "Approve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Oparation List of Dividing Plan ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton2.Location = new System.Drawing.Point(199, 402);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 39);
            this.simpleButton2.TabIndex = 41;
            this.simpleButton2.Text = "Edit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton4.Location = new System.Drawing.Point(14, 402);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(85, 39);
            this.simpleButton4.TabIndex = 40;
            this.simpleButton4.Text = "New";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // grdOpration
            // 
            this.grdOpration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOpration.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdOpration.Location = new System.Drawing.Point(14, 28);
            this.grdOpration.MainView = this.gridView2;
            this.grdOpration.Name = "grdOpration";
            this.grdOpration.Size = new System.Drawing.Size(920, 352);
            this.grdOpration.TabIndex = 39;
            this.grdOpration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdOpration;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.label12);
            this.xtraTabPage3.Controls.Add(this.progressPanel1);
            this.xtraTabPage3.Controls.Add(this.btnProcess);
            this.xtraTabPage3.Controls.Add(this.label7);
            this.xtraTabPage3.Controls.Add(this.txtFileName);
            this.xtraTabPage3.Controls.Add(this.simpleButton5);
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(992, 472);
            this.xtraTabPage3.Text = "Import";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Import Dividing Plan From Excel File";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(136, 85);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(134, 66);
            this.progressPanel1.TabIndex = 68;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(357, 108);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 67;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Select Excel File ";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(276, 64);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(338, 21);
            this.txtFileName.TabIndex = 65;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(276, 108);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 64;
            this.simpleButton5.Text = "Upload";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // grdSearch
            // 
            this.grdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(29, 66);
            this.grdSearch.MainView = this.gridView1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(1031, 414);
            this.grdSearch.TabIndex = 49;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearch;
            this.gridView1.Name = "gridView1";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::EFTesting.Properties.Resources.update;
            this.btnPrint.Location = new System.Drawing.Point(394, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 39);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmDividingPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 568);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmDividingPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dividing Plan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDividingPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductionPerHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDividingPlanNo.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtLineNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDividingPlanNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl grdOpration;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtProductionPerHour;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtTarget;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTotalEmployee;
        private DevExpress.XtraEditors.SimpleButton btnProcess;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}