namespace EFTesting.UI
{
    partial class frmPoDeliveriesDialog
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.txttoDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenarate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.chkByStyle = new System.Windows.Forms.CheckBox();
            this.chkFitToPage = new System.Windows.Forms.CheckBox();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(158, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "By Date Range";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "From Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.EditValue = null;
            this.txtFromDate.Location = new System.Drawing.Point(158, 130);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Size = new System.Drawing.Size(237, 20);
            this.txtFromDate.TabIndex = 29;
            // 
            // txttoDate
            // 
            this.txttoDate.EditValue = null;
            this.txttoDate.Location = new System.Drawing.Point(158, 166);
            this.txttoDate.Name = "txttoDate";
            this.txttoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttoDate.Size = new System.Drawing.Size(237, 20);
            this.txttoDate.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "To Date";
            // 
            // btnGenarate
            // 
            this.btnGenarate.Location = new System.Drawing.Point(158, 204);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(75, 23);
            this.btnGenarate.TabIndex = 32;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(239, 204);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 33;
            this.simpleButton2.Text = "Close";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(158, 95);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(237, 20);
            this.txtStyleNo.TabIndex = 40;
            this.txtStyleNo.EditValueChanged += new System.EventHandler(this.txtStyleNo_EditValueChanged);
            this.txtStyleNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStyleNo_KeyDown);
            // 
            // chkByStyle
            // 
            this.chkByStyle.AutoSize = true;
            this.chkByStyle.Location = new System.Drawing.Point(47, 21);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Size = new System.Drawing.Size(65, 17);
            this.chkByStyle.TabIndex = 42;
            this.chkByStyle.Text = "By Style";
            this.chkByStyle.UseVisualStyleBackColor = true;
            this.chkByStyle.CheckedChanged += new System.EventHandler(this.chkByStyle_CheckedChanged);
            // 
            // chkFitToPage
            // 
            this.chkFitToPage.AutoSize = true;
            this.chkFitToPage.Location = new System.Drawing.Point(47, 58);
            this.chkFitToPage.Name = "chkFitToPage";
            this.chkFitToPage.Size = new System.Drawing.Size(80, 17);
            this.chkFitToPage.TabIndex = 43;
            this.chkFitToPage.Text = "Fit To Page";
            this.chkFitToPage.UseVisualStyleBackColor = true;
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(38, 121);
            this.grdSearchStyle.MainView = this.gridView1;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(688, 173);
            this.grdSearchStyle.TabIndex = 44;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearchStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchStyle_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearchStyle;
            this.gridView1.Name = "gridView1";
            // 
            // frmPoDeliveriesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 306);
            this.Controls.Add(this.grdSearchStyle);
            this.Controls.Add(this.chkFitToPage);
            this.Controls.Add(this.chkByStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Name = "frmPoDeliveriesDialog";
            this.Text = "Cutting Production By FBO Date";
            this.Load += new System.EventHandler(this.frmPoDeliveriesDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit txtFromDate;
        private DevExpress.XtraEditors.DateEdit txttoDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnGenarate;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private System.Windows.Forms.CheckBox chkByStyle;
        private System.Windows.Forms.CheckBox chkFitToPage;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}