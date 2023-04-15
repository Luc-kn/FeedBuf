namespace Feedbuff
{
    partial class FeedupOverview
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
            this.components = new System.ComponentModel.Container();
            this.addTeacherNameTxtbx = new System.Windows.Forms.TextBox();
            this.addTeacherNameLbl = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.pageNameLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseBtn = new System.Windows.Forms.Button();
            this.addDocumentTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentLbl = new System.Windows.Forms.Label();
            this.addSubjectTxtBx = new System.Windows.Forms.TextBox();
            this.asignSubject = new System.Windows.Forms.Label();
            this.addFeedupLbl = new System.Windows.Forms.Label();
            this.addFeedupTxtBx = new System.Windows.Forms.TextBox();
            this.addDoneDateTxtBx = new System.Windows.Forms.TextBox();
            this.doneDateLbl = new System.Windows.Forms.Label();
            this.feedupDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initiateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentUpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedUpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doneDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedupDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBufDBDataSet2 = new Feedbuff.FeedBufDBDataSet2();
            this.feedupDataTableAdapter = new Feedbuff.FeedBufDBDataSet2TableAdapters.FeedupDataTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // addTeacherNameTxtbx
            // 
            this.addTeacherNameTxtbx.Location = new System.Drawing.Point(132, 147);
            this.addTeacherNameTxtbx.Name = "addTeacherNameTxtbx";
            this.addTeacherNameTxtbx.Size = new System.Drawing.Size(281, 22);
            this.addTeacherNameTxtbx.TabIndex = 26;
            // 
            // addTeacherNameLbl
            // 
            this.addTeacherNameLbl.AutoSize = true;
            this.addTeacherNameLbl.Location = new System.Drawing.Point(5, 150);
            this.addTeacherNameLbl.Name = "addTeacherNameLbl";
            this.addTeacherNameLbl.Size = new System.Drawing.Size(118, 16);
            this.addTeacherNameLbl.TabIndex = 25;
            this.addTeacherNameLbl.Text = "Docent toevoegen";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(11, 787);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(121, 29);
            this.ReturnBtn.TabIndex = 24;
            this.ReturnBtn.Text = "terug";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click_1);
            // 
            // pageNameLbl
            // 
            this.pageNameLbl.AutoSize = true;
            this.pageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLbl.Location = new System.Drawing.Point(11, 4);
            this.pageNameLbl.Name = "pageNameLbl";
            this.pageNameLbl.Size = new System.Drawing.Size(540, 32);
            this.pageNameLbl.TabIndex = 22;
            this.pageNameLbl.Text = "Feedup toevoegen, in zien en veranderen";
            // 
            // addFeedbackToDataBaseLbl
            // 
            this.addFeedbackToDataBaseLbl.AutoSize = true;
            this.addFeedbackToDataBaseLbl.Location = new System.Drawing.Point(5, 224);
            this.addFeedbackToDataBaseLbl.Name = "addFeedbackToDataBaseLbl";
            this.addFeedbackToDataBaseLbl.Size = new System.Drawing.Size(121, 16);
            this.addFeedbackToDataBaseLbl.TabIndex = 21;
            this.addFeedbackToDataBaseLbl.Text = "Feedback opslaan";
            // 
            // addFeedbackToDataBaseBtn
            // 
            this.addFeedbackToDataBaseBtn.Location = new System.Drawing.Point(132, 221);
            this.addFeedbackToDataBaseBtn.Name = "addFeedbackToDataBaseBtn";
            this.addFeedbackToDataBaseBtn.Size = new System.Drawing.Size(139, 23);
            this.addFeedbackToDataBaseBtn.TabIndex = 20;
            this.addFeedbackToDataBaseBtn.Text = "opslaan";
            this.addFeedbackToDataBaseBtn.UseVisualStyleBackColor = true;
            // 
            // addDocumentTxtBx
            // 
            this.addDocumentTxtBx.Location = new System.Drawing.Point(217, 84);
            this.addDocumentTxtBx.Name = "addDocumentTxtBx";
            this.addDocumentTxtBx.Size = new System.Drawing.Size(196, 22);
            this.addDocumentTxtBx.TabIndex = 19;
            // 
            // addDocumentLbl
            // 
            this.addDocumentLbl.AutoSize = true;
            this.addDocumentLbl.Location = new System.Drawing.Point(11, 87);
            this.addDocumentLbl.Name = "addDocumentLbl";
            this.addDocumentLbl.Size = new System.Drawing.Size(200, 16);
            this.addDocumentLbl.TabIndex = 18;
            this.addDocumentLbl.Text = "Onderdeel/document toekennen";
            // 
            // addSubjectTxtBx
            // 
            this.addSubjectTxtBx.Location = new System.Drawing.Point(114, 115);
            this.addSubjectTxtBx.Name = "addSubjectTxtBx";
            this.addSubjectTxtBx.Size = new System.Drawing.Size(299, 22);
            this.addSubjectTxtBx.TabIndex = 17;
            // 
            // asignSubject
            // 
            this.asignSubject.AutoSize = true;
            this.asignSubject.Location = new System.Drawing.Point(11, 115);
            this.asignSubject.Name = "asignSubject";
            this.asignSubject.Size = new System.Drawing.Size(97, 16);
            this.asignSubject.TabIndex = 16;
            this.asignSubject.Text = "Vak toekennen";
            // 
            // addFeedupLbl
            // 
            this.addFeedupLbl.AutoSize = true;
            this.addFeedupLbl.Location = new System.Drawing.Point(12, 59);
            this.addFeedupLbl.Name = "addFeedupLbl";
            this.addFeedupLbl.Size = new System.Drawing.Size(122, 16);
            this.addFeedupLbl.TabIndex = 15;
            this.addFeedupLbl.Text = "Feedup toevoegen";
            // 
            // addFeedupTxtBx
            // 
            this.addFeedupTxtBx.Location = new System.Drawing.Point(155, 56);
            this.addFeedupTxtBx.Name = "addFeedupTxtBx";
            this.addFeedupTxtBx.Size = new System.Drawing.Size(258, 22);
            this.addFeedupTxtBx.TabIndex = 14;
            // 
            // addDoneDateTxtBx
            // 
            this.addDoneDateTxtBx.Location = new System.Drawing.Point(72, 175);
            this.addDoneDateTxtBx.Name = "addDoneDateTxtBx";
            this.addDoneDateTxtBx.Size = new System.Drawing.Size(341, 22);
            this.addDoneDateTxtBx.TabIndex = 28;
            // 
            // doneDateLbl
            // 
            this.doneDateLbl.AutoSize = true;
            this.doneDateLbl.Location = new System.Drawing.Point(8, 178);
            this.doneDateLbl.Name = "doneDateLbl";
            this.doneDateLbl.Size = new System.Drawing.Size(58, 16);
            this.doneDateLbl.TabIndex = 27;
            this.doneDateLbl.Text = "datum af";
            // 
            // feedupDGV
            // 
            this.feedupDGV.AllowUserToAddRows = false;
            this.feedupDGV.AutoGenerateColumns = false;
            this.feedupDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedupDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.initiateDateDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.documentUpDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.feedUpDataGridViewTextBoxColumn,
            this.achievedDataGridViewCheckBoxColumn,
            this.doneDateDataGridViewTextBoxColumn,
            this.sideNoteDataGridViewTextBoxColumn});
            this.feedupDGV.DataSource = this.feedupDataBindingSource;
            this.feedupDGV.Location = new System.Drawing.Point(476, 56);
            this.feedupDGV.Name = "feedupDGV";
            this.feedupDGV.ReadOnly = true;
            this.feedupDGV.RowHeadersWidth = 51;
            this.feedupDGV.RowTemplate.Height = 24;
            this.feedupDGV.Size = new System.Drawing.Size(1042, 760);
            this.feedupDGV.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // initiateDateDataGridViewTextBoxColumn
            // 
            this.initiateDateDataGridViewTextBoxColumn.DataPropertyName = "InitiateDate";
            this.initiateDateDataGridViewTextBoxColumn.HeaderText = "InitiateDate";
            this.initiateDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initiateDateDataGridViewTextBoxColumn.Name = "initiateDateDataGridViewTextBoxColumn";
            this.initiateDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.initiateDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            this.deadlineDataGridViewTextBoxColumn.ReadOnly = true;
            this.deadlineDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentUpDataGridViewTextBoxColumn
            // 
            this.documentUpDataGridViewTextBoxColumn.DataPropertyName = "DocumentUp";
            this.documentUpDataGridViewTextBoxColumn.HeaderText = "DocumentUp";
            this.documentUpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentUpDataGridViewTextBoxColumn.Name = "documentUpDataGridViewTextBoxColumn";
            this.documentUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentUpDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherDataGridViewTextBoxColumn.Visible = false;
            this.teacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // feedUpDataGridViewTextBoxColumn
            // 
            this.feedUpDataGridViewTextBoxColumn.DataPropertyName = "FeedUp";
            this.feedUpDataGridViewTextBoxColumn.HeaderText = "FeedUp";
            this.feedUpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feedUpDataGridViewTextBoxColumn.Name = "feedUpDataGridViewTextBoxColumn";
            this.feedUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedUpDataGridViewTextBoxColumn.Width = 125;
            // 
            // achievedDataGridViewCheckBoxColumn
            // 
            this.achievedDataGridViewCheckBoxColumn.DataPropertyName = "Achieved";
            this.achievedDataGridViewCheckBoxColumn.HeaderText = "Achieved";
            this.achievedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.achievedDataGridViewCheckBoxColumn.Name = "achievedDataGridViewCheckBoxColumn";
            this.achievedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.achievedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // doneDateDataGridViewTextBoxColumn
            // 
            this.doneDateDataGridViewTextBoxColumn.DataPropertyName = "DoneDate";
            this.doneDateDataGridViewTextBoxColumn.HeaderText = "DoneDate";
            this.doneDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doneDateDataGridViewTextBoxColumn.Name = "doneDateDataGridViewTextBoxColumn";
            this.doneDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.doneDateDataGridViewTextBoxColumn.Visible = false;
            this.doneDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sideNoteDataGridViewTextBoxColumn
            // 
            this.sideNoteDataGridViewTextBoxColumn.DataPropertyName = "SideNote";
            this.sideNoteDataGridViewTextBoxColumn.HeaderText = "SideNote";
            this.sideNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sideNoteDataGridViewTextBoxColumn.Name = "sideNoteDataGridViewTextBoxColumn";
            this.sideNoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.sideNoteDataGridViewTextBoxColumn.Visible = false;
            this.sideNoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // feedupDataBindingSource
            // 
            this.feedupDataBindingSource.DataMember = "FeedupData";
            this.feedupDataBindingSource.DataSource = this.feedBufDBDataSet2;
            // 
            // feedBufDBDataSet2
            // 
            this.feedBufDBDataSet2.DataSetName = "FeedBufDBDataSet2";
            this.feedBufDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedupDataTableAdapter
            // 
            this.feedupDataTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(277, 221);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(135, 23);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "verwijderen";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(236, 787);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(123, 29);
            this.InfoBtn.TabIndex = 31;
            this.InfoBtn.Text = "Uitgebreide info";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // FeedupOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.feedupDGV);
            this.Controls.Add(this.addDoneDateTxtBx);
            this.Controls.Add(this.doneDateLbl);
            this.Controls.Add(this.addTeacherNameTxtbx);
            this.Controls.Add(this.addTeacherNameLbl);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.pageNameLbl);
            this.Controls.Add(this.addFeedbackToDataBaseLbl);
            this.Controls.Add(this.addFeedbackToDataBaseBtn);
            this.Controls.Add(this.addDocumentTxtBx);
            this.Controls.Add(this.addDocumentLbl);
            this.Controls.Add(this.addSubjectTxtBx);
            this.Controls.Add(this.asignSubject);
            this.Controls.Add(this.addFeedupLbl);
            this.Controls.Add(this.addFeedupTxtBx);
            this.Name = "FeedupOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedupOverview";
            ((System.ComponentModel.ISupportInitialize)(this.feedupDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTeacherNameTxtbx;
        private System.Windows.Forms.Label addTeacherNameLbl;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label pageNameLbl;
        private System.Windows.Forms.Label addFeedbackToDataBaseLbl;
        private System.Windows.Forms.Button addFeedbackToDataBaseBtn;
        private System.Windows.Forms.TextBox addDocumentTxtBx;
        private System.Windows.Forms.Label addDocumentLbl;
        private System.Windows.Forms.TextBox addSubjectTxtBx;
        private System.Windows.Forms.Label asignSubject;
        private System.Windows.Forms.Label addFeedupLbl;
        private System.Windows.Forms.TextBox addFeedupTxtBx;
        private System.Windows.Forms.TextBox addDoneDateTxtBx;
        private System.Windows.Forms.Label doneDateLbl;
        private System.Windows.Forms.DataGridView feedupDGV;
        private FeedBufDBDataSet2 feedBufDBDataSet2;
        private System.Windows.Forms.BindingSource feedupDataBindingSource;
        private FeedBufDBDataSet2TableAdapters.FeedupDataTableAdapter feedupDataTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initiateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentUpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedUpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn achievedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button InfoBtn;
    }
}