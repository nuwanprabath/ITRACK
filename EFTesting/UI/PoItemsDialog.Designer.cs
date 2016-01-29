namespace EFTesting.UI
{
    partial class PoItemsDialog
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
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoNo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorCode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLength = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuntity = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grdSearchPo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuntity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchPo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(494, 49);
            this.txtSize.Name = "txtSize";
            this.txtSize.Properties.NullValuePrompt = "Please Enter Size";
            this.txtSize.Size = new System.Drawing.Size(226, 20);
            this.txtSize.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Po No";
            // 
            // txtPoNo
            // 
            this.txtPoNo.EditValue = "";
            this.txtPoNo.Location = new System.Drawing.Point(149, 49);
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Properties.AccessibleDescription = "";
            this.txtPoNo.Properties.NullValuePrompt = "Please Enter Po Number";
            this.txtPoNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPoNo.Size = new System.Drawing.Size(226, 20);
            this.txtPoNo.TabIndex = 14;
            this.txtPoNo.EditValueChanged += new System.EventHandler(this.txtPoNo_EditValueChanged);
            this.txtPoNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoNo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Color Code ";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(149, 91);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Properties.NullValuePrompt = "Please Enter Color Code";
            this.txtColorCode.Size = new System.Drawing.Size(226, 20);
            this.txtColorCode.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(494, 91);
            this.txtLength.Name = "txtLength";
            this.txtLength.Properties.NullValuePrompt = "Please Enter Length";
            this.txtLength.Size = new System.Drawing.Size(226, 20);
            this.txtLength.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            // 
            // txtQuntity
            // 
            this.txtQuntity.Location = new System.Drawing.Point(149, 137);
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Properties.NullValuePrompt = "Please Enter Qty";
            this.txtQuntity.Size = new System.Drawing.Size(226, 20);
            this.txtQuntity.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(331, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(149, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdSearchPo
            // 
            this.grdSearchPo.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchPo.Location = new System.Drawing.Point(149, 75);
            this.grdSearchPo.MainView = this.gridView2;
            this.grdSearchPo.Name = "grdSearchPo";
            this.grdSearchPo.Size = new System.Drawing.Size(675, 206);
            this.grdSearchPo.TabIndex = 46;
            this.grdSearchPo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdSearchPo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchPo_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearchPo;
            this.gridView2.Name = "gridView2";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton1.Location = new System.Drawing.Point(240, 183);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Add/New";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PoItemsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 302);
            this.Controls.Add(this.grdSearchPo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuntity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoNo);
            this.Name = "PoItemsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Ratio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoItemsDialog_FormClosing);
            this.Load += new System.EventHandler(this.PoItemsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuntity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchPo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtPoNo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtColorCode;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtLength;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtQuntity;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl grdSearchPo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}