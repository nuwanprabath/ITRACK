namespace EFTesting.UI
{
    partial class Opration_List
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
            this.grdOpList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOperationNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtOName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAnd = new DevExpress.XtraEditors.CheckEdit();
            this.chkOr = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOpList
            // 
            this.grdOpList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdOpList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdOpList.Location = new System.Drawing.Point(26, 90);
            this.grdOpList.MainView = this.gridView1;
            this.grdOpList.Name = "grdOpList";
            this.grdOpList.Size = new System.Drawing.Size(1115, 308);
            this.grdOpList.TabIndex = 7;
            this.grdOpList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdOpList;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // txtOperationNo
            // 
            this.txtOperationNo.EditValue = "";
            this.txtOperationNo.Location = new System.Drawing.Point(26, 63);
            this.txtOperationNo.Name = "txtOperationNo";
            this.txtOperationNo.Properties.AccessibleDescription = "";
            this.txtOperationNo.Properties.NullValuePrompt = "Please Enter Group ID";
            this.txtOperationNo.Size = new System.Drawing.Size(355, 20);
            this.txtOperationNo.TabIndex = 9;
            this.txtOperationNo.EditValueChanged += new System.EventHandler(this.txtOperationNo_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Operation No";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(26, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 39);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOName
            // 
            this.txtOName.EditValue = "";
            this.txtOName.Location = new System.Drawing.Point(387, 63);
            this.txtOName.Name = "txtOName";
            this.txtOName.Properties.AccessibleDescription = "";
            this.txtOName.Properties.NullValuePrompt = "Please Enter Group ID";
            this.txtOName.Size = new System.Drawing.Size(355, 20);
            this.txtOName.TabIndex = 12;
            this.txtOName.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Operation Name";
            // 
            // chkAnd
            // 
            this.chkAnd.Location = new System.Drawing.Point(26, 12);
            this.chkAnd.Name = "chkAnd";
            this.chkAnd.Properties.Caption = "And";
            this.chkAnd.Size = new System.Drawing.Size(75, 19);
            this.chkAnd.TabIndex = 14;
            this.chkAnd.CheckedChanged += new System.EventHandler(this.chkAnd_CheckedChanged);
            // 
            // chkOr
            // 
            this.chkOr.Location = new System.Drawing.Point(107, 12);
            this.chkOr.Name = "chkOr";
            this.chkOr.Properties.Caption = "Or";
            this.chkOr.Size = new System.Drawing.Size(75, 19);
            this.chkOr.TabIndex = 15;
            this.chkOr.CheckedChanged += new System.EventHandler(this.chkOr_CheckedChanged);
            // 
            // Opration_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 462);
            this.Controls.Add(this.chkOr);
            this.Controls.Add(this.chkAnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOperationNo);
            this.Controls.Add(this.grdOpList);
            this.Name = "Opration_List";
            this.Text = "Opration List";
            this.Load += new System.EventHandler(this.Opration_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdOpList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtOperationNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtOName;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit chkAnd;
        private DevExpress.XtraEditors.CheckEdit chkOr;

    }
}