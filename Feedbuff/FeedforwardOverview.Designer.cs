namespace Feedbuff
{
    partial class FeedforwardOverview
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
            this.addFeedforwardLbl = new System.Windows.Forms.Label();
            this.addFeedbackTxtBx = new System.Windows.Forms.TextBox();
            this.feedforwadDVG = new System.Windows.Forms.DataGridView();
            this.feedForwardDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBufDBDataSet = new Feedbuff.FeedBufDBDataSet();
            this.feedForwardDataTableAdapter = new Feedbuff.FeedBufDBDataSetTableAdapters.FeedForwardDataTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.justfeedup = new Feedbuff.justfeedup();
            this.feedupDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedupDataTableAdapter = new Feedbuff.justfeedupTableAdapters.FeedupDataTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feedBufDBDataSet4 = new Feedbuff.FeedBufDBDataSet4();
            this.feedbackDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackDataTableAdapter = new Feedbuff.FeedBufDBDataSet4TableAdapters.FeedbackDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feedforwadDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedForwardDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.justfeedup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addTeacherNameTxtbx
            // 
            this.addTeacherNameTxtbx.Location = new System.Drawing.Point(133, 152);
            this.addTeacherNameTxtbx.Name = "addTeacherNameTxtbx";
            this.addTeacherNameTxtbx.Size = new System.Drawing.Size(281, 22);
            this.addTeacherNameTxtbx.TabIndex = 26;
            // 
            // addTeacherNameLbl
            // 
            this.addTeacherNameLbl.AutoSize = true;
            this.addTeacherNameLbl.Location = new System.Drawing.Point(9, 155);
            this.addTeacherNameLbl.Name = "addTeacherNameLbl";
            this.addTeacherNameLbl.Size = new System.Drawing.Size(118, 16);
            this.addTeacherNameLbl.TabIndex = 25;
            this.addTeacherNameLbl.Text = "Docent toevoegen";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 792);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(121, 29);
            this.ReturnBtn.TabIndex = 24;
            this.ReturnBtn.Text = "terug";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // pageNameLbl
            // 
            this.pageNameLbl.AutoSize = true;
            this.pageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLbl.Location = new System.Drawing.Point(12, 9);
            this.pageNameLbl.Name = "pageNameLbl";
            this.pageNameLbl.Size = new System.Drawing.Size(450, 32);
            this.pageNameLbl.TabIndex = 22;
            this.pageNameLbl.Text = "Feedforward toevoegen en in zien ";
            // 
            // addFeedbackToDataBaseLbl
            // 
            this.addFeedbackToDataBaseLbl.AutoSize = true;
            this.addFeedbackToDataBaseLbl.Location = new System.Drawing.Point(13, 188);
            this.addFeedbackToDataBaseLbl.Name = "addFeedbackToDataBaseLbl";
            this.addFeedbackToDataBaseLbl.Size = new System.Drawing.Size(135, 16);
            this.addFeedbackToDataBaseLbl.TabIndex = 21;
            this.addFeedbackToDataBaseLbl.Text = "Feedforward opslaan";
            // 
            // addFeedbackToDataBaseBtn
            // 
            this.addFeedbackToDataBaseBtn.Location = new System.Drawing.Point(154, 185);
            this.addFeedbackToDataBaseBtn.Name = "addFeedbackToDataBaseBtn";
            this.addFeedbackToDataBaseBtn.Size = new System.Drawing.Size(139, 23);
            this.addFeedbackToDataBaseBtn.TabIndex = 20;
            this.addFeedbackToDataBaseBtn.Text = "opslaan";
            this.addFeedbackToDataBaseBtn.UseVisualStyleBackColor = true;
            this.addFeedbackToDataBaseBtn.Click += new System.EventHandler(this.addFeedbackToDataBaseBtn_Click);
            // 
            // addDocumentTxtBx
            // 
            this.addDocumentTxtBx.Location = new System.Drawing.Point(218, 89);
            this.addDocumentTxtBx.Name = "addDocumentTxtBx";
            this.addDocumentTxtBx.Size = new System.Drawing.Size(196, 22);
            this.addDocumentTxtBx.TabIndex = 19;
            // 
            // addDocumentLbl
            // 
            this.addDocumentLbl.AutoSize = true;
            this.addDocumentLbl.Location = new System.Drawing.Point(12, 92);
            this.addDocumentLbl.Name = "addDocumentLbl";
            this.addDocumentLbl.Size = new System.Drawing.Size(200, 16);
            this.addDocumentLbl.TabIndex = 18;
            this.addDocumentLbl.Text = "Onderdeel/document toekennen";
            // 
            // addSubjectTxtBx
            // 
            this.addSubjectTxtBx.Location = new System.Drawing.Point(115, 120);
            this.addSubjectTxtBx.Name = "addSubjectTxtBx";
            this.addSubjectTxtBx.Size = new System.Drawing.Size(299, 22);
            this.addSubjectTxtBx.TabIndex = 17;
            // 
            // asignSubject
            // 
            this.asignSubject.AutoSize = true;
            this.asignSubject.Location = new System.Drawing.Point(12, 120);
            this.asignSubject.Name = "asignSubject";
            this.asignSubject.Size = new System.Drawing.Size(97, 16);
            this.asignSubject.TabIndex = 16;
            this.asignSubject.Text = "Vak toekennen";
            // 
            // addFeedforwardLbl
            // 
            this.addFeedforwardLbl.AutoSize = true;
            this.addFeedforwardLbl.Location = new System.Drawing.Point(13, 64);
            this.addFeedforwardLbl.Name = "addFeedforwardLbl";
            this.addFeedforwardLbl.Size = new System.Drawing.Size(151, 16);
            this.addFeedforwardLbl.TabIndex = 15;
            this.addFeedforwardLbl.Text = "Feedforward toevoegen";
            // 
            // addFeedbackTxtBx
            // 
            this.addFeedbackTxtBx.Location = new System.Drawing.Point(170, 61);
            this.addFeedbackTxtBx.Name = "addFeedbackTxtBx";
            this.addFeedbackTxtBx.Size = new System.Drawing.Size(244, 22);
            this.addFeedbackTxtBx.TabIndex = 14;
            // 
            // feedforwadDVG
            // 
            this.feedforwadDVG.AllowUserToAddRows = false;
            this.feedforwadDVG.AutoGenerateColumns = false;
            this.feedforwadDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedforwadDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.controleDataGridViewCheckBoxColumn});
            this.feedforwadDVG.DataSource = this.feedForwardDataBindingSource;
            this.feedforwadDVG.Location = new System.Drawing.Point(490, 64);
            this.feedforwadDVG.Name = "feedforwadDVG";
            this.feedforwadDVG.ReadOnly = true;
            this.feedforwadDVG.RowHeadersWidth = 51;
            this.feedforwadDVG.RowTemplate.Height = 24;
            this.feedforwadDVG.Size = new System.Drawing.Size(994, 757);
            this.feedforwadDVG.TabIndex = 27;
            // 
            // feedForwardDataBindingSource
            // 
            this.feedForwardDataBindingSource.DataMember = "FeedForwardData";
            this.feedForwardDataBindingSource.DataSource = this.feedBufDBDataSet;
            // 
            // feedBufDBDataSet
            // 
            this.feedBufDBDataSet.DataSetName = "FeedBufDBDataSet";
            this.feedBufDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedForwardDataTableAdapter
            // 
            this.feedForwardDataTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(299, 185);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 23);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "verwijderen";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // justfeedup
            // 
            this.justfeedup.DataSetName = "justfeedup";
            this.justfeedup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedupDataBindingSource
            // 
            this.feedupDataBindingSource.DataMember = "FeedupData";
            this.feedupDataBindingSource.DataSource = this.justfeedup;
            // 
            // feedupDataTableAdapter
            // 
            this.feedupDataTableAdapter.ClearBeforeFill = true;
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
            // controleDataGridViewCheckBoxColumn
            // 
            this.controleDataGridViewCheckBoxColumn.DataPropertyName = "Controle";
            this.controleDataGridViewCheckBoxColumn.HeaderText = "Controle";
            this.controleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.controleDataGridViewCheckBoxColumn.Name = "controleDataGridViewCheckBoxColumn";
            this.controleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.controleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // feedBufDBDataSet4
            // 
            this.feedBufDBDataSet4.DataSetName = "FeedBufDBDataSet4";
            this.feedBufDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackDataBindingSource
            // 
            this.feedbackDataBindingSource.DataMember = "FeedbackData";
            this.feedbackDataBindingSource.DataSource = this.feedBufDBDataSet4;
            // 
            // feedbackDataTableAdapter
            // 
            this.feedbackDataTableAdapter.ClearBeforeFill = true;
            // 
            // FeedforwardOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.feedforwadDVG);
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
            this.Controls.Add(this.addFeedforwardLbl);
            this.Controls.Add(this.addFeedbackTxtBx);
            this.Name = "FeedforwardOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedforwardOverview";
            this.Load += new System.EventHandler(this.FeedforwardOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedforwadDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedForwardDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.justfeedup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).EndInit();
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
        private System.Windows.Forms.Label addFeedforwardLbl;
        private System.Windows.Forms.TextBox addFeedbackTxtBx;
        private System.Windows.Forms.DataGridView feedforwadDVG;
        private FeedBufDBDataSet feedBufDBDataSet;
        private System.Windows.Forms.BindingSource feedForwardDataBindingSource;
        private FeedBufDBDataSetTableAdapters.FeedForwardDataTableAdapter feedForwardDataTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private justfeedup justfeedup;
        private System.Windows.Forms.BindingSource feedupDataBindingSource;
        private justfeedupTableAdapters.FeedupDataTableAdapter feedupDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controleDataGridViewCheckBoxColumn;
        private FeedBufDBDataSet4 feedBufDBDataSet4;
        private System.Windows.Forms.BindingSource feedbackDataBindingSource;
        private FeedBufDBDataSet4TableAdapters.FeedbackDataTableAdapter feedbackDataTableAdapter;
    }
}