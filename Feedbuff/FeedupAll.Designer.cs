namespace Feedbuff
{
    partial class FeedupAll
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.feedBufDBDataSet2 = new Feedbuff.FeedBufDBDataSet2();
            this.feedBufDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.feedBufDBDataSet3 = new Feedbuff.FeedBufDBDataSet3();
            this.feedBufDBDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feedupDataTableAdapter = new Feedbuff.FeedBufDBDataSet3TableAdapters.FeedupDataTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(74, 786);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(140, 41);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Terug en update";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // feedBufDBDataSet2
            // 
            this.feedBufDBDataSet2.DataSetName = "FeedBufDBDataSet2";
            this.feedBufDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBufDBDataSet2BindingSource
            // 
            this.feedBufDBDataSet2BindingSource.DataSource = this.feedBufDBDataSet2;
            this.feedBufDBDataSet2BindingSource.Position = 0;
            // 
            // feedupDGV
            // 
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
            this.feedupDGV.Location = new System.Drawing.Point(44, 94);
            this.feedupDGV.Name = "feedupDGV";
            this.feedupDGV.RowHeadersWidth = 51;
            this.feedupDGV.RowTemplate.Height = 24;
            this.feedupDGV.Size = new System.Drawing.Size(1635, 686);
            this.feedupDGV.TabIndex = 4;
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
            this.achievedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // doneDateDataGridViewTextBoxColumn
            // 
            this.doneDateDataGridViewTextBoxColumn.DataPropertyName = "DoneDate";
            this.doneDateDataGridViewTextBoxColumn.HeaderText = "DoneDate";
            this.doneDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doneDateDataGridViewTextBoxColumn.Name = "doneDateDataGridViewTextBoxColumn";
            this.doneDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.doneDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sideNoteDataGridViewTextBoxColumn
            // 
            this.sideNoteDataGridViewTextBoxColumn.DataPropertyName = "SideNote";
            this.sideNoteDataGridViewTextBoxColumn.HeaderText = "SideNote";
            this.sideNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sideNoteDataGridViewTextBoxColumn.Name = "sideNoteDataGridViewTextBoxColumn";
            this.sideNoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.sideNoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // feedupDataBindingSource
            // 
            this.feedupDataBindingSource.DataMember = "FeedupData";
            this.feedupDataBindingSource.DataSource = this.feedBufDBDataSet3;
            // 
            // feedBufDBDataSet3
            // 
            this.feedBufDBDataSet3.DataSetName = "FeedBufDBDataSet3";
            this.feedBufDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBufDBDataSet2BindingSource1
            // 
            this.feedBufDBDataSet2BindingSource1.DataSource = this.feedBufDBDataSet2;
            this.feedBufDBDataSet2BindingSource1.Position = 0;
            // 
            // feedupDataTableAdapter
            // 
            this.feedupDataTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "selecteer een rij die je wil aanpassen. Je kan een rij selecteer door op het eers" +
    "te veld van die rij te drukken";
            // 
            // FeedupAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 874);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feedupDGV);
            this.Controls.Add(this.BackBtn);
            this.Name = "FeedupAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedupAll";
            this.Load += new System.EventHandler(this.FeedupAll_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource feedBufDBDataSet2BindingSource;
        private FeedBufDBDataSet2 feedBufDBDataSet2;
        private System.Windows.Forms.DataGridView feedupDGV;
        private System.Windows.Forms.BindingSource feedBufDBDataSet2BindingSource1;
        private FeedBufDBDataSet3 feedBufDBDataSet3;
        private System.Windows.Forms.BindingSource feedupDataBindingSource;
        private FeedBufDBDataSet3TableAdapters.FeedupDataTableAdapter feedupDataTableAdapter;
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
        private System.Windows.Forms.Label label1;
    }
}