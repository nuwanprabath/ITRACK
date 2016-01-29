namespace EFTesting.UI
{
    partial class frmPromotion
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtJobDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesignation = new DevExpress.XtraEditors.TextEdit();
            this.txtFromotedDate = new DevExpress.XtraEditors.DateEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromDesignation = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToDesigation = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromotedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromotedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDesignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDesigation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Job Description";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.Location = new System.Drawing.Point(116, 133);
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Properties.NullValuePrompt = "Remark";
            this.txtJobDescription.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtJobDescription.Size = new System.Drawing.Size(226, 96);
            this.txtJobDescription.TabIndex = 5;
            this.txtJobDescription.UseOptimizedRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Promoted Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Designation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(116, 56);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Properties.NullValuePrompt = "Please Enter Designation";
            this.txtDesignation.Size = new System.Drawing.Size(226, 20);
            this.txtDesignation.TabIndex = 2;
            // 
            // txtFromotedDate
            // 
            this.txtFromotedDate.EditValue = "";
            this.txtFromotedDate.Location = new System.Drawing.Point(460, 56);
            this.txtFromotedDate.Name = "txtFromotedDate";
            this.txtFromotedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromotedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromotedDate.Properties.NullValuePrompt = "Plese Select From Date";
            this.txtFromotedDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtFromotedDate.Size = new System.Drawing.Size(226, 20);
            this.txtFromotedDate.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(208, 254);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(116, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "From.Designation";
            // 
            // txtFromDesignation
            // 
            this.txtFromDesignation.Location = new System.Drawing.Point(116, 93);
            this.txtFromDesignation.Name = "txtFromDesignation";
            this.txtFromDesignation.Properties.NullValuePrompt = "Please Enter Designation";
            this.txtFromDesignation.Size = new System.Drawing.Size(226, 20);
            this.txtFromDesignation.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "To.Designation";
            // 
            // txtToDesigation
            // 
            this.txtToDesigation.Location = new System.Drawing.Point(460, 89);
            this.txtToDesigation.Name = "txtToDesigation";
            this.txtToDesigation.Properties.NullValuePrompt = "Please Enter Designation";
            this.txtToDesigation.Size = new System.Drawing.Size(226, 20);
            this.txtToDesigation.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(460, 133);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullValuePrompt = "Remark";
            this.txtRemark.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRemark.Size = new System.Drawing.Size(226, 96);
            this.txtRemark.TabIndex = 46;
            this.txtRemark.UseOptimizedRendering = true;
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToDesigation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFromDesignation);
            this.Controls.Add(this.txtFromotedDate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesignation);
            this.Name = "frmPromotion";
            this.Text = "Promotion";
            ((System.ComponentModel.ISupportInitialize)(this.txtJobDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromotedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromotedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDesignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDesigation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.MemoEdit txtJobDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDesignation;
        private DevExpress.XtraEditors.DateEdit txtFromotedDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtFromDesignation;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtToDesigation;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
    }
}