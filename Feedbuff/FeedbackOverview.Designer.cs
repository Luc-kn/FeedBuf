﻿namespace Feedbuff
{
    partial class FeedbackOverview
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
            this.addFeedbackTxtBx = new System.Windows.Forms.TextBox();
            this.addFeedbackLbl = new System.Windows.Forms.Label();
            this.asignSubject = new System.Windows.Forms.Label();
            this.addSubjectTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseBtn = new System.Windows.Forms.Button();
            this.addFeedbackToDataBaseLbl = new System.Windows.Forms.Label();
            this.addFeedbackPageNameLbl = new System.Windows.Forms.Label();
            this.feedbackFromDatabaseLstBx = new System.Windows.Forms.ListBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.addTeacherNameLbl = new System.Windows.Forms.Label();
            this.addTeacherNameTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addFeedbackTxtBx
            // 
            this.addFeedbackTxtBx.Location = new System.Drawing.Point(156, 70);
            this.addFeedbackTxtBx.Name = "addFeedbackTxtBx";
            this.addFeedbackTxtBx.Size = new System.Drawing.Size(258, 22);
            this.addFeedbackTxtBx.TabIndex = 0;
            // 
            // addFeedbackLbl
            // 
            this.addFeedbackLbl.AutoSize = true;
            this.addFeedbackLbl.Location = new System.Drawing.Point(13, 73);
            this.addFeedbackLbl.Name = "addFeedbackLbl";
            this.addFeedbackLbl.Size = new System.Drawing.Size(137, 16);
            this.addFeedbackLbl.TabIndex = 1;
            this.addFeedbackLbl.Text = "Feedback toevoegen";
            // 
            // asignSubject
            // 
            this.asignSubject.AutoSize = true;
            this.asignSubject.Location = new System.Drawing.Point(12, 129);
            this.asignSubject.Name = "asignSubject";
            this.asignSubject.Size = new System.Drawing.Size(97, 16);
            this.asignSubject.TabIndex = 3;
            this.asignSubject.Text = "Vak toekennen";
            // 
            // addSubjectTxtBx
            // 
            this.addSubjectTxtBx.Location = new System.Drawing.Point(115, 129);
            this.addSubjectTxtBx.Name = "addSubjectTxtBx";
            this.addSubjectTxtBx.Size = new System.Drawing.Size(299, 22);
            this.addSubjectTxtBx.TabIndex = 4;
            // 
            // addDocumentTxtBx
            // 
            this.addDocumentTxtBx.Location = new System.Drawing.Point(218, 98);
            this.addDocumentTxtBx.Name = "addDocumentTxtBx";
            this.addDocumentTxtBx.Size = new System.Drawing.Size(196, 22);
            this.addDocumentTxtBx.TabIndex = 6;
            // 
            // addDocumentLbl
            // 
            this.addDocumentLbl.AutoSize = true;
            this.addDocumentLbl.Location = new System.Drawing.Point(12, 101);
            this.addDocumentLbl.Name = "addDocumentLbl";
            this.addDocumentLbl.Size = new System.Drawing.Size(200, 16);
            this.addDocumentLbl.TabIndex = 5;
            this.addDocumentLbl.Text = "Onderdeel/document toekennen";
            // 
            // addFeedbackToDataBaseBtn
            // 
            this.addFeedbackToDataBaseBtn.Location = new System.Drawing.Point(140, 194);
            this.addFeedbackToDataBaseBtn.Name = "addFeedbackToDataBaseBtn";
            this.addFeedbackToDataBaseBtn.Size = new System.Drawing.Size(139, 23);
            this.addFeedbackToDataBaseBtn.TabIndex = 7;
            this.addFeedbackToDataBaseBtn.Text = "opslaan";
            this.addFeedbackToDataBaseBtn.UseVisualStyleBackColor = true;
            this.addFeedbackToDataBaseBtn.Click += new System.EventHandler(this.addFeedbackToDataBaseBtn_Click);
            // 
            // addFeedbackToDataBaseLbl
            // 
            this.addFeedbackToDataBaseLbl.AutoSize = true;
            this.addFeedbackToDataBaseLbl.Location = new System.Drawing.Point(13, 197);
            this.addFeedbackToDataBaseLbl.Name = "addFeedbackToDataBaseLbl";
            this.addFeedbackToDataBaseLbl.Size = new System.Drawing.Size(121, 16);
            this.addFeedbackToDataBaseLbl.TabIndex = 8;
            this.addFeedbackToDataBaseLbl.Text = "Feedback opslaan";
            // 
            // addFeedbackPageNameLbl
            // 
            this.addFeedbackPageNameLbl.AutoSize = true;
            this.addFeedbackPageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeedbackPageNameLbl.Location = new System.Drawing.Point(12, 18);
            this.addFeedbackPageNameLbl.Name = "addFeedbackPageNameLbl";
            this.addFeedbackPageNameLbl.Size = new System.Drawing.Size(568, 32);
            this.addFeedbackPageNameLbl.TabIndex = 9;
            this.addFeedbackPageNameLbl.Text = "Feedback toevoegen, in zien en veranderen";
            // 
            // feedbackFromDatabaseLstBx
            // 
            this.feedbackFromDatabaseLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackFromDatabaseLstBx.FormattingEnabled = true;
            this.feedbackFromDatabaseLstBx.ItemHeight = 22;
            this.feedbackFromDatabaseLstBx.Location = new System.Drawing.Point(442, 74);
            this.feedbackFromDatabaseLstBx.Name = "feedbackFromDatabaseLstBx";
            this.feedbackFromDatabaseLstBx.Size = new System.Drawing.Size(1066, 752);
            this.feedbackFromDatabaseLstBx.TabIndex = 10;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 801);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(121, 29);
            this.ReturnBtn.TabIndex = 11;
            this.ReturnBtn.Text = "terug";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // addTeacherNameLbl
            // 
            this.addTeacherNameLbl.AutoSize = true;
            this.addTeacherNameLbl.Location = new System.Drawing.Point(9, 164);
            this.addTeacherNameLbl.Name = "addTeacherNameLbl";
            this.addTeacherNameLbl.Size = new System.Drawing.Size(118, 16);
            this.addTeacherNameLbl.TabIndex = 12;
            this.addTeacherNameLbl.Text = "Docent toevoegen";
            // 
            // addTeacherNameTxtbx
            // 
            this.addTeacherNameTxtbx.Location = new System.Drawing.Point(133, 161);
            this.addTeacherNameTxtbx.Name = "addTeacherNameTxtbx";
            this.addTeacherNameTxtbx.Size = new System.Drawing.Size(281, 22);
            this.addTeacherNameTxtbx.TabIndex = 13;
            // 
            // FeedbackOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.addTeacherNameTxtbx);
            this.Controls.Add(this.addTeacherNameLbl);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.feedbackFromDatabaseLstBx);
            this.Controls.Add(this.addFeedbackPageNameLbl);
            this.Controls.Add(this.addFeedbackToDataBaseLbl);
            this.Controls.Add(this.addFeedbackToDataBaseBtn);
            this.Controls.Add(this.addDocumentTxtBx);
            this.Controls.Add(this.addDocumentLbl);
            this.Controls.Add(this.addSubjectTxtBx);
            this.Controls.Add(this.asignSubject);
            this.Controls.Add(this.addFeedbackLbl);
            this.Controls.Add(this.addFeedbackTxtBx);
            this.Name = "FeedbackOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedbackOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addFeedbackTxtBx;
        private System.Windows.Forms.Label addFeedbackLbl;
        private System.Windows.Forms.Label asignSubject;
        private System.Windows.Forms.TextBox addSubjectTxtBx;
        private System.Windows.Forms.TextBox addDocumentTxtBx;
        private System.Windows.Forms.Label addDocumentLbl;
        private System.Windows.Forms.Button addFeedbackToDataBaseBtn;
        private System.Windows.Forms.Label addFeedbackToDataBaseLbl;
        private System.Windows.Forms.Label addFeedbackPageNameLbl;
        private System.Windows.Forms.ListBox feedbackFromDatabaseLstBx;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label addTeacherNameLbl;
        private System.Windows.Forms.TextBox addTeacherNameTxtbx;
    }
}