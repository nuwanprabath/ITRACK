namespace EFTesting.UI
{
    partial class frmcompanyDialog
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeleNo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocationCode = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupID = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFaxNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.isDefualtCompany = new DevExpress.XtraEditors.CheckEdit();
            this.grdGroup = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDefualtCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tele No";
            // 
            // txtTeleNo
            // 
            this.txtTeleNo.Location = new System.Drawing.Point(468, 90);
            this.txtTeleNo.Name = "txtTeleNo";
            this.txtTeleNo.Properties.NullValuePrompt = "Please Enter Telephone Number";
            this.txtTeleNo.Size = new System.Drawing.Size(226, 20);
            this.txtTeleNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(123, 90);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.NullValuePrompt = "Please Enter Company Name";
            this.txtCompanyName.Size = new System.Drawing.Size(226, 20);
            this.txtCompanyName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Location Code";
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.Location = new System.Drawing.Point(468, 54);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Properties.NullValuePrompt = "Please Enter Location Code";
            this.txtLocationCode.Size = new System.Drawing.Size(226, 20);
            this.txtLocationCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Group ID";
            // 
            // txtGroupID
            // 
            this.txtGroupID.EditValue = "";
            this.txtGroupID.Location = new System.Drawing.Point(123, 54);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Properties.AccessibleDescription = "";
            this.txtGroupID.Properties.NullValuePrompt = "Please Enter Group ID";
            this.txtGroupID.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtGroupID.Size = new System.Drawing.Size(226, 20);
            this.txtGroupID.TabIndex = 1;
            this.txtGroupID.EditValueChanged += new System.EventHandler(this.txtGroupID_EditValueChanged);
            this.txtGroupID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGroupID_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fax No";
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(123, 124);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Properties.NullValuePrompt = "Please Enter Fax Number";
            this.txtFaxNo.Size = new System.Drawing.Size(226, 20);
            this.txtFaxNo.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.NullValuePrompt = "Please Enter Fax Number";
            this.txtAddress.Size = new System.Drawing.Size(571, 96);
            this.txtAddress.TabIndex = 22;
            this.txtAddress.UseOptimizedRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(215, 301);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(123, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // isDefualtCompany
            // 
            this.isDefualtCompany.Location = new System.Drawing.Point(123, 267);
            this.isDefualtCompany.Name = "isDefualtCompany";
            this.isDefualtCompany.Properties.Caption = "Set As Defualt Company";
            this.isDefualtCompany.Size = new System.Drawing.Size(163, 19);
            this.isDefualtCompany.TabIndex = 6;
            // 
            // grdGroup
            // 
            this.grdGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdGroup.Location = new System.Drawing.Point(123, 78);
            this.grdGroup.MainView = this.gridView1;
            this.grdGroup.Name = "grdGroup";
            this.grdGroup.Size = new System.Drawing.Size(742, 208);
            this.grdGroup.TabIndex = 3;
            this.grdGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdGroup_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdGroup;
            this.gridView1.Name = "gridView1";
            // 
            // frmcompanyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 366);
            this.Controls.Add(this.grdGroup);
            this.Controls.Add(this.isDefualtCompany);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTeleNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroupID);
            this.Name = "frmcompanyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add \\ Edit Company";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcompanyDialog_FormClosing);
            this.Load += new System.EventHandler(this.frmcompanyDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTeleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDefualtCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtTeleNo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtLocationCode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtGroupID;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtFaxNo;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.CheckEdit isDefualtCompany;
        private DevExpress.XtraGrid.GridControl grdGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}