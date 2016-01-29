namespace EFTesting.UI
{
    partial class frmDividingPlanItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOprationNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoprationName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSmvType = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMV = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMachineType = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartName = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.grdOpList = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWno = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOprationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoprationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSmvType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMachineType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Opration No";
            // 
            // txtOprationNo
            // 
            this.txtOprationNo.EditValue = "";
            this.txtOprationNo.Location = new System.Drawing.Point(148, 71);
            this.txtOprationNo.Name = "txtOprationNo";
            this.txtOprationNo.Properties.AccessibleDescription = "";
            this.txtOprationNo.Properties.NullValuePrompt = "Please Enter Operation Number";
            this.txtOprationNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOprationNo.Size = new System.Drawing.Size(251, 20);
            this.txtOprationNo.TabIndex = 1;
            this.txtOprationNo.EditValueChanged += new System.EventHandler(this.txtOprationNo_EditValueChanged);
            this.txtOprationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOprationNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Opration Name";
            // 
            // txtoprationName
            // 
            this.txtoprationName.EditValue = "";
            this.txtoprationName.Location = new System.Drawing.Point(148, 107);
            this.txtoprationName.Name = "txtoprationName";
            this.txtoprationName.Properties.AccessibleDescription = "";
            this.txtoprationName.Properties.NullValuePrompt = "Please Enter Operation Name";
            this.txtoprationName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtoprationName.Size = new System.Drawing.Size(251, 20);
            this.txtoprationName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "SMV Type";
            // 
            // cmbSmvType
            // 
            this.cmbSmvType.EditValue = "";
            this.cmbSmvType.Location = new System.Drawing.Point(148, 144);
            this.cmbSmvType.Name = "cmbSmvType";
            this.cmbSmvType.Properties.AccessibleDescription = "";
            this.cmbSmvType.Properties.NullValuePrompt = "Please Enter SMV Type";
            this.cmbSmvType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbSmvType.Size = new System.Drawing.Size(251, 20);
            this.cmbSmvType.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(330, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(148, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "SMV";
            // 
            // txtSMV
            // 
            this.txtSMV.EditValue = "";
            this.txtSMV.Location = new System.Drawing.Point(564, 103);
            this.txtSMV.Name = "txtSMV";
            this.txtSMV.Properties.AccessibleDescription = "";
            this.txtSMV.Properties.NullValuePrompt = "Please Enter SMV";
            this.txtSMV.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSMV.Size = new System.Drawing.Size(251, 20);
            this.txtSMV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Machine Type";
            // 
            // cmbMachineType
            // 
            this.cmbMachineType.EditValue = "";
            this.cmbMachineType.Location = new System.Drawing.Point(564, 67);
            this.cmbMachineType.Name = "cmbMachineType";
            this.cmbMachineType.Properties.AccessibleDescription = "";
            this.cmbMachineType.Properties.NullValuePrompt = "Please Enter Machine Type";
            this.cmbMachineType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbMachineType.Size = new System.Drawing.Size(251, 20);
            this.cmbMachineType.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton1.Location = new System.Drawing.Point(239, 226);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Add/New";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Part Name";
            // 
            // txtPartName
            // 
            this.txtPartName.EditValue = "";
            this.txtPartName.Location = new System.Drawing.Point(564, 140);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Properties.AccessibleDescription = "";
            this.txtPartName.Properties.NullValuePrompt = "Please Enter Part Name";
            this.txtPartName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPartName.Size = new System.Drawing.Size(251, 20);
            this.txtPartName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Add / Edit Operation To Dividing Plan";
            // 
            // grdOpList
            // 
            this.grdOpList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdOpList.Location = new System.Drawing.Point(33, 93);
            this.grdOpList.MainView = this.gridView2;
            this.grdOpList.Name = "grdOpList";
            this.grdOpList.Size = new System.Drawing.Size(979, 248);
            this.grdOpList.TabIndex = 58;
            this.grdOpList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdOpList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdOpList_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdOpList;
            this.gridView2.Name = "gridView2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "W/No";
            // 
            // txtWno
            // 
            this.txtWno.EditValue = "";
            this.txtWno.Location = new System.Drawing.Point(148, 179);
            this.txtWno.Name = "txtWno";
            this.txtWno.Properties.AccessibleDescription = "";
            this.txtWno.Properties.NullValuePrompt = "Please Enter SMV Type";
            this.txtWno.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtWno.Size = new System.Drawing.Size(251, 20);
            this.txtWno.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "OP/No";
            // 
            // txtOpNo
            // 
            this.txtOpNo.EditValue = "";
            this.txtOpNo.Location = new System.Drawing.Point(564, 179);
            this.txtOpNo.Name = "txtOpNo";
            this.txtOpNo.Properties.AccessibleDescription = "";
            this.txtOpNo.Properties.NullValuePrompt = "Please Enter SMV Type";
            this.txtOpNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOpNo.Size = new System.Drawing.Size(251, 20);
            this.txtOpNo.TabIndex = 61;
            // 
            // frmDividingPlanItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 390);
            this.Controls.Add(this.grdOpList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSMV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMachineType);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSmvType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoprationName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOprationNo);
            this.Controls.Add(this.txtWno);
            this.Name = "frmDividingPlanItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dividing Plan Item";
            this.Load += new System.EventHandler(this.frmDividingPlanItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOprationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoprationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSmvType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMachineType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtOprationNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtoprationName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit cmbSmvType;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSMV;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit cmbMachineType;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPartName;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl grdOpList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtWno;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtOpNo;
    }
}