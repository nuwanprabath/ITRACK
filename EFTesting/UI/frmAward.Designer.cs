namespace EFTesting.UI
{
    partial class frmAward
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
            this.txtAwardDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAwardRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAwardName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAwardID = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAwardDate
            // 
            this.txtAwardDate.EditValue = "";
            this.txtAwardDate.Location = new System.Drawing.Point(121, 93);
            this.txtAwardDate.Name = "txtAwardDate";
            this.txtAwardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAwardDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAwardDate.Properties.NullValuePrompt = "Plese Select Award Date";
            this.txtAwardDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtAwardDate.Size = new System.Drawing.Size(226, 20);
            this.txtAwardDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Remarks";
            // 
            // txtAwardRemarks
            // 
            this.txtAwardRemarks.Location = new System.Drawing.Point(121, 133);
            this.txtAwardRemarks.Name = "txtAwardRemarks";
            this.txtAwardRemarks.Size = new System.Drawing.Size(226, 96);
            this.txtAwardRemarks.TabIndex = 4;
            this.txtAwardRemarks.UseOptimizedRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Award Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Award Name";
            // 
            // txtAwardName
            // 
            this.txtAwardName.Location = new System.Drawing.Point(466, 57);
            this.txtAwardName.Name = "txtAwardName";
            this.txtAwardName.Properties.NullValuePrompt = "Please Enter Award Name";
            this.txtAwardName.Size = new System.Drawing.Size(226, 20);
            this.txtAwardName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Award ID";
            // 
            // txtAwardID
            // 
            this.txtAwardID.EditValue = "";
            this.txtAwardID.Location = new System.Drawing.Point(121, 57);
            this.txtAwardID.Name = "txtAwardID";
            this.txtAwardID.Properties.AccessibleDescription = "";
            this.txtAwardID.Properties.NullValuePrompt = "Please Enter Award ID";
            this.txtAwardID.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtAwardID.Size = new System.Drawing.Size(226, 20);
            this.txtAwardID.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(214, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(122, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 346);
            this.Controls.Add(this.txtAwardDate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAwardRemarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAwardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAwardID);
            this.Name = "frmAward";
            this.Text = "frmAward";
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwardID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtAwardDate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.MemoEdit txtAwardRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtAwardName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAwardID;
    }
}