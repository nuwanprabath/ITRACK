namespace EFTesting.UI
{
    partial class frmSketchMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.imgprofile = new DevExpress.XtraEditors.PictureEdit();
            this.cmbItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSketchName = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grdParts = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgprofile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSketchName.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(293, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(770, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 10;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(479, 22);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 9;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(383, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(202, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(110, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(19, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(19, 68);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1206, 410);
            this.xtraTabControl1.TabIndex = 25;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Controls.Add(this.imgprofile);
            this.xtraTabPage1.Controls.Add(this.cmbItemType);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.txtRemark);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtSketchName);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1124, 404);
            this.xtraTabPage1.Text = "Header";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(466, 35);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(251, 20);
            this.txtStyleNo.TabIndex = 1;
            // 
            // imgprofile
            // 
            this.imgprofile.Location = new System.Drawing.Point(51, 38);
            this.imgprofile.Name = "imgprofile";
            this.imgprofile.Size = new System.Drawing.Size(277, 250);
            this.imgprofile.TabIndex = 45;
            // 
            // cmbItemType
            // 
            this.cmbItemType.Location = new System.Drawing.Point(466, 108);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbItemType.Properties.Items.AddRange(new object[] {
            "Pant",
            "Blouse",
            "Skirt"});
            this.cmbItemType.Properties.NullValuePrompt = "Please Select Item Type";
            this.cmbItemType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbItemType.Size = new System.Drawing.Size(212, 20);
            this.cmbItemType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Item Type";
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(466, 154);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullValuePrompt = "Remark";
            this.txtRemark.Size = new System.Drawing.Size(289, 96);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.UseOptimizedRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sketch Name";
            // 
            // txtSketchName
            // 
            this.txtSketchName.EditValue = "";
            this.txtSketchName.Location = new System.Drawing.Point(466, 73);
            this.txtSketchName.Name = "txtSketchName";
            this.txtSketchName.Properties.AccessibleDescription = "";
            this.txtSketchName.Properties.NullValuePrompt = "Please Enter Sketch Name";
            this.txtSketchName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSketchName.Size = new System.Drawing.Size(251, 20);
            this.txtSketchName.TabIndex = 2;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grdParts);
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1124, 404);
            this.xtraTabPage2.Text = "Parts";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // grdParts
            // 
            this.grdParts.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdParts.Location = new System.Drawing.Point(79, 35);
            this.grdParts.MainView = this.gridView2;
            this.grdParts.Name = "grdParts";
            this.grdParts.Size = new System.Drawing.Size(1010, 287);
            this.grdParts.TabIndex = 39;
            this.grdParts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdParts;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1124, 404);
            this.xtraTabPage3.Text = "Style";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Last Modified";
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit7.EditValue = "";
            this.textEdit7.Location = new System.Drawing.Point(745, 484);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.AccessibleDescription = "";
            this.textEdit7.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit7.Size = new System.Drawing.Size(209, 20);
            this.textEdit7.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Created By";
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit6.EditValue = "";
            this.textEdit6.Location = new System.Drawing.Point(448, 484);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.AccessibleDescription = "";
            this.textEdit6.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit6.Size = new System.Drawing.Size(209, 20);
            this.textEdit6.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Created Date";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(174, 484);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.AccessibleDescription = "";
            this.textEdit5.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit5.Size = new System.Drawing.Size(188, 20);
            this.textEdit5.TabIndex = 38;
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(19, 59);
            this.grdSearch.MainView = this.gridView1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(1048, 27);
            this.grdSearch.TabIndex = 44;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearch;
            this.gridView1.Name = "gridView1";
            // 
            // frmSketchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 520);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmSketchMaster";
            this.Text = "Sketch Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSketchMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgprofile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSketchName.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSketchName;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraGrid.GridControl grdParts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbItemType;
        private DevExpress.XtraEditors.PictureEdit imgprofile;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}