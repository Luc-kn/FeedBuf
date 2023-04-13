namespace Feedbuff
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
            this.components = new System.ComponentModel.Container();
            this.addFeedbackTxtBx = new System.Windows.Forms.TextBox();
            this.addFeedbackLbl = new System.Windows.Forms.Label();
            this.asignSubject = new System.Windows.Forms.Label();
            this.addSubjectTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseBtn = new System.Windows.Forms.Button();
            this.addFeedbackToDataBaseLbl = new System.Windows.Forms.Label();
            this.addFeedbackPageNameLbl = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.addTeacherNameLbl = new System.Windows.Forms.Label();
            this.addTeacherNameTxtbx = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.feedBufDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBufDBDataSet1 = new Feedbuff.FeedBufDBDataSet1();
            this.feedbackDataTableAdapter = new Feedbuff.FeedBufDBDataSet1TableAdapters.FeedbackDataTableAdapter();
            this.feedbackDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenFeedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDGV)).BeginInit();
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
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(156, 439);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Verwijderen";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // feedbackDataBindingSource
            // 
            this.feedbackDataBindingSource.DataMember = "FeedbackData";
            this.feedbackDataBindingSource.DataSource = this.feedBufDBDataSet1;
            // 
            // feedBufDBDataSet1
            // 
            this.feedBufDBDataSet1.DataSetName = "FeedBufDBDataSet1";
            this.feedBufDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackDataTableAdapter
            // 
            this.feedbackDataTableAdapter.ClearBeforeFill = true;
            // 
            // feedbackDGV
            // 
            this.feedbackDGV.AutoGenerateColumns = false;
            this.feedbackDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.documentBackDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.givenFeedbackDataGridViewTextBoxColumn,
            this.controleDataGridViewCheckBoxColumn});
            this.feedbackDGV.DataSource = this.feedbackDataBindingSource;
            this.feedbackDGV.Location = new System.Drawing.Point(442, 74);
            this.feedbackDGV.Name = "feedbackDGV";
            this.feedbackDGV.ReadOnly = true;
            this.feedbackDGV.RowHeadersWidth = 51;
            this.feedbackDGV.RowTemplate.Height = 24;
            this.feedbackDGV.Size = new System.Drawing.Size(1066, 756);
            this.feedbackDGV.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentBackDataGridViewTextBoxColumn
            // 
            this.documentBackDataGridViewTextBoxColumn.DataPropertyName = "DocumentBack";
            this.documentBackDataGridViewTextBoxColumn.HeaderText = "DocumentBack";
            this.documentBackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentBackDataGridViewTextBoxColumn.Name = "documentBackDataGridViewTextBoxColumn";
            this.documentBackDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentBackDataGridViewTextBoxColumn.Width = 125;
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
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // givenFeedbackDataGridViewTextBoxColumn
            // 
            this.givenFeedbackDataGridViewTextBoxColumn.DataPropertyName = "GivenFeedback";
            this.givenFeedbackDataGridViewTextBoxColumn.HeaderText = "GivenFeedback";
            this.givenFeedbackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.givenFeedbackDataGridViewTextBoxColumn.Name = "givenFeedbackDataGridViewTextBoxColumn";
            this.givenFeedbackDataGridViewTextBoxColumn.ReadOnly = true;
            this.givenFeedbackDataGridViewTextBoxColumn.Width = 125;
            // 
            // controleDataGridViewCheckBoxColumn
            // 
            this.controleDataGridViewCheckBoxColumn.DataPropertyName = "Controle";
            this.controleDataGridViewCheckBoxColumn.HeaderText = "Controle";
            this.controleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.controleDataGridViewCheckBoxColumn.Name = "controleDataGridViewCheckBoxColumn";
            this.controleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.controleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // FeedbackOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.feedbackDGV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addTeacherNameTxtbx);
            this.Controls.Add(this.addTeacherNameLbl);
            this.Controls.Add(this.ReturnBtn);
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
            this.Load += new System.EventHandler(this.FeedbackOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDGV)).EndInit();
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
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label addTeacherNameLbl;
        private System.Windows.Forms.TextBox addTeacherNameTxtbx;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource feedBufDBDataSetBindingSource;
        private FeedBufDBDataSet1 feedBufDBDataSet1;
        private System.Windows.Forms.BindingSource feedbackDataBindingSource;
        private FeedBufDBDataSet1TableAdapters.FeedbackDataTableAdapter feedbackDataTableAdapter;
        private System.Windows.Forms.DataGridView feedbackDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentBackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenFeedbackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controleDataGridViewCheckBoxColumn;
    }
}