namespace EFTesting.UI
{
    partial class StockRequisition
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrnDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtGrnNo = new DevExpress.XtraEditors.TextEdit();
            this.lblGrnNo = new System.Windows.Forms.Label();
            this.cmbLocationCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocationCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton2.Location = new System.Drawing.Point(745, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 39);
            this.simpleButton2.TabIndex = 84;
            this.simpleButton2.Text = "Print";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(687, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 82;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(396, 27);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 81;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(296, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 80;
            this.simpleButton1.Text = "Search";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(195, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(103, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 83;
            this.btnNew.Text = "New";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 66);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1064, 407);
            this.xtraTabControl1.TabIndex = 85;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.textEdit3);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtGrnDate);
            this.xtraTabPage1.Controls.Add(this.lblDate);
            this.xtraTabPage1.Controls.Add(this.txtGrnNo);
            this.xtraTabPage1.Controls.Add(this.lblGrnNo);
            this.xtraTabPage1.Controls.Add(this.cmbLocationCode);
            this.xtraTabPage1.Controls.Add(this.lblLocationCode);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1025, 401);
            this.xtraTabPage1.Text = "Header";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(563, 25);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.NullValuePrompt = "GRN No";
            this.textEdit3.Size = new System.Drawing.Size(226, 20);
            this.textEdit3.TabIndex = 75;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(563, 104);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.NullValuePrompt = "GRN No";
            this.textEdit2.Size = new System.Drawing.Size(226, 20);
            this.textEdit2.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "To Department";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(126, 104);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullValuePrompt = "GRN No";
            this.textEdit1.Size = new System.Drawing.Size(226, 20);
            this.textEdit1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "From Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Location Name";
            // 
            // txtGrnDate
            // 
            this.txtGrnDate.EditValue = null;
            this.txtGrnDate.Location = new System.Drawing.Point(563, 64);
            this.txtGrnDate.Name = "txtGrnDate";
            this.txtGrnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGrnDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGrnDate.Properties.NullValuePrompt = "Select Date";
            this.txtGrnDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtGrnDate.Size = new System.Drawing.Size(226, 20);
            this.txtGrnDate.TabIndex = 68;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(463, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 67;
            this.lblDate.Text = "Date";
            // 
            // txtGrnNo
            // 
            this.txtGrnNo.Location = new System.Drawing.Point(126, 64);
            this.txtGrnNo.Name = "txtGrnNo";
            this.txtGrnNo.Properties.NullValuePrompt = "GRN No";
            this.txtGrnNo.Size = new System.Drawing.Size(226, 20);
            this.txtGrnNo.TabIndex = 65;
            // 
            // lblGrnNo
            // 
            this.lblGrnNo.AutoSize = true;
            this.lblGrnNo.Location = new System.Drawing.Point(26, 67);
            this.lblGrnNo.Name = "lblGrnNo";
            this.lblGrnNo.Size = new System.Drawing.Size(75, 13);
            this.lblGrnNo.TabIndex = 66;
            this.lblGrnNo.Text = "Requisition No";
            // 
            // cmbLocationCode
            // 
            this.cmbLocationCode.Location = new System.Drawing.Point(126, 25);
            this.cmbLocationCode.Name = "cmbLocationCode";
            this.cmbLocationCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLocationCode.Properties.Items.AddRange(new object[] {
            "VTW",
            "TGZ",
            "TGK",
            "IMN",
            "WFK",
            "HO",
            "TGB",
            "BAN"});
            this.cmbLocationCode.Properties.NullValuePrompt = "Please Select Location Code";
            this.cmbLocationCode.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbLocationCode.Size = new System.Drawing.Size(226, 20);
            this.cmbLocationCode.TabIndex = 63;
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.Location = new System.Drawing.Point(26, 28);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(75, 13);
            this.lblLocationCode.TabIndex = 64;
            this.lblLocationCode.Text = "Location Code";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1025, 401);
            this.xtraTabPage2.Text = "Details";
            // 
            // StockRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 485);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "StockRequisition";
            this.Text = "StockRequisition";
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrnNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocationCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtGrnDate;
        private System.Windows.Forms.Label lblDate;
        private DevExpress.XtraEditors.TextEdit txtGrnNo;
        private System.Windows.Forms.Label lblGrnNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLocationCode;
        private System.Windows.Forms.Label lblLocationCode;
    }
}