namespace EFTesting.UI
{
    partial class frmIndividualProductionDialog
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
            this.txtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenarate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txttoDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromDate
            // 
            this.txtFromDate.EditValue = null;
            this.txtFromDate.Location = new System.Drawing.Point(142, 38);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Size = new System.Drawing.Size(237, 20);
            this.txtFromDate.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "From Date";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(223, 102);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Close";
            // 
            // btnGenarate
            // 
            this.btnGenarate.Location = new System.Drawing.Point(142, 102);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(75, 23);
            this.btnGenarate.TabIndex = 43;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "To Date";
            // 
            // txttoDate
            // 
            this.txttoDate.EditValue = null;
            this.txttoDate.Location = new System.Drawing.Point(142, 64);
            this.txttoDate.Name = "txttoDate";
            this.txttoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttoDate.Size = new System.Drawing.Size(237, 20);
            this.txttoDate.TabIndex = 41;
            // 
            // frmIndividualProductionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 164);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.label7);
            this.Name = "frmIndividualProductionDialog";
            this.Text = "frmIndividualProductionDialog";
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtFromDate;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnGenarate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txttoDate;
    }
}