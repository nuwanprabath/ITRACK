namespace EFTesting.UI
{
    partial class frmOfflineScaning
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHourNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScanTime = new DevExpress.XtraEditors.TextEdit();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textfileOpen = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtHourNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton1.Location = new System.Drawing.Point(217, 148);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(162, 39);
            this.simpleButton1.TabIndex = 79;
            this.simpleButton1.Text = "Process";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton4.Location = new System.Drawing.Point(49, 148);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(162, 39);
            this.simpleButton4.TabIndex = 78;
            this.simpleButton4.Text = "Upload ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(159, 59);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(248, 21);
            this.txtDate.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Scan Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Hour No";
            // 
            // txtHourNo
            // 
            this.txtHourNo.EditValue = "";
            this.txtHourNo.Location = new System.Drawing.Point(537, 58);
            this.txtHourNo.Name = "txtHourNo";
            this.txtHourNo.Properties.AccessibleDescription = "";
            this.txtHourNo.Properties.NullValuePrompt = "Opration No";
            this.txtHourNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtHourNo.Size = new System.Drawing.Size(251, 20);
            this.txtHourNo.TabIndex = 84;
            this.txtHourNo.EditValueChanged += new System.EventHandler(this.txtHourNo_EditValueChanged);
            this.txtHourNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHourNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Offline Scan / Upload and Process";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(49, 214);
            this.txtLog.Name = "txtLog";
            this.txtLog.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtLog.Properties.Appearance.Options.UseForeColor = true;
            this.txtLog.Size = new System.Drawing.Size(887, 282);
            this.txtLog.TabIndex = 87;
            this.txtLog.UseOptimizedRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Scaning Time";
            // 
            // txtScanTime
            // 
            this.txtScanTime.EditValue = "";
            this.txtScanTime.Location = new System.Drawing.Point(159, 85);
            this.txtScanTime.Name = "txtScanTime";
            this.txtScanTime.Properties.AccessibleDescription = "";
            this.txtScanTime.Properties.NullValuePrompt = "Opration No";
            this.txtScanTime.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtScanTime.Size = new System.Drawing.Size(251, 20);
            this.txtScanTime.TabIndex = 88;
            this.txtScanTime.EditValueChanged += new System.EventHandler(this.txtScanTime_EditValueChanged);
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(159, 193);
            this.grdSearch.MainView = this.gridView4;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(777, 399);
            this.grdSearch.TabIndex = 90;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdSearch;
            this.gridView4.Name = "gridView4";
            // 
            // textfileOpen
            // 
            this.textfileOpen.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.EditValue = "";
            this.txtLocation.Location = new System.Drawing.Point(537, 85);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Properties.AccessibleDescription = "";
            this.txtLocation.Properties.NullValuePrompt = "Opration No";
            this.txtLocation.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLocation.Size = new System.Drawing.Size(251, 20);
            this.txtLocation.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Style NO";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(159, 116);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Opration No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(251, 20);
            this.txtStyleNo.TabIndex = 94;
            this.txtStyleNo.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(537, 116);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AccessibleDescription = "";
            this.textEdit2.Properties.NullValuePrompt = "Opration No";
            this.textEdit2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit2.Size = new System.Drawing.Size(251, 20);
            this.textEdit2.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Line No";
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(49, 193);
            this.grdSearchStyle.MainView = this.gridView1;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(887, 180);
            this.grdSearchStyle.TabIndex = 97;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearchStyle;
            this.gridView1.Name = "gridView1";
            // 
            // frmOfflineScaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 508);
            this.Controls.Add(this.grdSearchStyle);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScanTime);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHourNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Name = "frmOfflineScaning";
            this.Text = "Offline Scaning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOfflineScaning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHourNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScanTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtHourNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit txtLog;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtScanTime;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.OpenFileDialog textfileOpen;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}