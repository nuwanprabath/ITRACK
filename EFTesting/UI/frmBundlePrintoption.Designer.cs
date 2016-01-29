namespace EFTesting.UI
{
    partial class frmBundlePrintoption
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
            this.chkCutId = new DevExpress.XtraEditors.CheckEdit();
            this.chkCutIdRange = new DevExpress.XtraEditors.CheckEdit();
            this.chkBundleRange = new DevExpress.XtraEditors.CheckEdit();
            this.txtFrom = new DevExpress.XtraEditors.TextEdit();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EFTesting.UI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.chkCutId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCutIdRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBundleRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCutId
            // 
            this.chkCutId.Location = new System.Drawing.Point(40, 24);
            this.chkCutId.Name = "chkCutId";
            this.chkCutId.Properties.Caption = "By Cut ID";
            this.chkCutId.Size = new System.Drawing.Size(75, 19);
            this.chkCutId.TabIndex = 0;
            this.chkCutId.CheckedChanged += new System.EventHandler(this.chkCutId_CheckedChanged);
            // 
            // chkCutIdRange
            // 
            this.chkCutIdRange.Location = new System.Drawing.Point(145, 24);
            this.chkCutIdRange.Name = "chkCutIdRange";
            this.chkCutIdRange.Properties.Caption = "By Cut ID Range";
            this.chkCutIdRange.Size = new System.Drawing.Size(115, 19);
            this.chkCutIdRange.TabIndex = 1;
            this.chkCutIdRange.CheckedChanged += new System.EventHandler(this.chkCutIdRange_CheckedChanged);
            // 
            // chkBundleRange
            // 
            this.chkBundleRange.Location = new System.Drawing.Point(284, 24);
            this.chkBundleRange.Name = "chkBundleRange";
            this.chkBundleRange.Properties.Caption = "Bundle Range";
            this.chkBundleRange.Size = new System.Drawing.Size(115, 19);
            this.chkBundleRange.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(40, 87);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(203, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(252, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(203, 20);
            this.txtTo.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(40, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "From";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(257, 63);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "To";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(43, 129);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 63;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(124, 129);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 64;
            this.simpleButton1.Text = "Close";
            // 
            // frmBundlePrintoption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 194);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.chkBundleRange);
            this.Controls.Add(this.chkCutIdRange);
            this.Controls.Add(this.chkCutId);
            this.Name = "frmBundlePrintoption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Option";
            this.Load += new System.EventHandler(this.frmBundlePrintoption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkCutId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCutIdRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBundleRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkCutId;
        private DevExpress.XtraEditors.CheckEdit chkCutIdRange;
        private DevExpress.XtraEditors.CheckEdit chkBundleRange;
        private DevExpress.XtraEditors.TextEdit txtFrom;
        private DevExpress.XtraEditors.TextEdit txtTo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}