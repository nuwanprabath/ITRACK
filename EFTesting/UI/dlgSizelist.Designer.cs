namespace EFTesting.UI
{
    partial class dlgSizelist
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
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(26, 12);
            this.grdSearch.MainView = this.gridView3;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(685, 262);
            this.grdSearch.TabIndex = 63;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSearch;
            this.gridView3.Name = "gridView3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.EditValue = "";
            this.txtSize.Location = new System.Drawing.Point(26, 302);
            this.txtSize.Name = "txtSize";
            this.txtSize.Properties.AccessibleDescription = "";
            this.txtSize.Properties.NullValuePrompt = "Size";
            this.txtSize.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSize.Size = new System.Drawing.Size(208, 20);
            this.txtSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.EditValue = "";
            this.txtQty.Location = new System.Drawing.Point(240, 302);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.AccessibleDescription = "";
            this.txtQty.Properties.NullValuePrompt = "Qty";
            this.txtQty.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtQty.Size = new System.Drawing.Size(208, 20);
            this.txtQty.TabIndex = 2;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(616, 299);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 70;
            this.simpleButton4.Text = "Remove";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(535, 299);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 69;
            this.simpleButton3.Text = "Edit";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(454, 299);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 68;
            this.simpleButton2.Text = "Add";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dlgSizelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 342);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.grdSearch);
            this.Name = "dlgSizelist";
            this.Text = "dlgSizelist";
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}