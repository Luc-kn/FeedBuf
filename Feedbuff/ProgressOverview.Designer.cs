namespace Feedbuff
{
    partial class ProgressOverview
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
            this.feedBufDBDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feedBufDBDataSet2 = new Feedbuff.FeedBufDBDataSet2();
            this.pageNameLbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.finishedFeedupDGVNameLbl = new System.Windows.Forms.Label();
            this.notFinishedFeedupDGVNameLbl = new System.Windows.Forms.Label();
            this.feedBufDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedupDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedupDataTableAdapter = new Feedbuff.FeedBufDBDataSet2TableAdapters.FeedupDataTableAdapter();
            this.feedupDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yesFinishedFeedupLstBx = new System.Windows.Forms.ListBox();
            this.notFinishedFeedupLstBx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // feedBufDBDataSet2BindingSource1
            // 
            this.feedBufDBDataSet2BindingSource1.DataSource = this.feedBufDBDataSet2;
            this.feedBufDBDataSet2BindingSource1.Position = 0;
            // 
            // feedBufDBDataSet2
            // 
            this.feedBufDBDataSet2.DataSetName = "FeedBufDBDataSet2";
            this.feedBufDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pageNameLbl
            // 
            this.pageNameLbl.AutoSize = true;
            this.pageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLbl.Location = new System.Drawing.Point(12, 9);
            this.pageNameLbl.Name = "pageNameLbl";
            this.pageNameLbl.Size = new System.Drawing.Size(364, 46);
            this.pageNameLbl.TabIndex = 2;
            this.pageNameLbl.Text = "voortgang overview";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(12, 666);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(132, 41);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Terug";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // finishedFeedupDGVNameLbl
            // 
            this.finishedFeedupDGVNameLbl.AutoSize = true;
            this.finishedFeedupDGVNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedFeedupDGVNameLbl.Location = new System.Drawing.Point(126, 100);
            this.finishedFeedupDGVNameLbl.Name = "finishedFeedupDGVNameLbl";
            this.finishedFeedupDGVNameLbl.Size = new System.Drawing.Size(278, 25);
            this.finishedFeedupDGVNameLbl.TabIndex = 4;
            this.finishedFeedupDGVNameLbl.Text = "Dit zijn de behaalde leerdoelen";
            // 
            // notFinishedFeedupDGVNameLbl
            // 
            this.notFinishedFeedupDGVNameLbl.AutoSize = true;
            this.notFinishedFeedupDGVNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFinishedFeedupDGVNameLbl.Location = new System.Drawing.Point(817, 100);
            this.notFinishedFeedupDGVNameLbl.Name = "notFinishedFeedupDGVNameLbl";
            this.notFinishedFeedupDGVNameLbl.Size = new System.Drawing.Size(317, 25);
            this.notFinishedFeedupDGVNameLbl.TabIndex = 5;
            this.notFinishedFeedupDGVNameLbl.Text = "Dit zijn de Niet behaalde leerdoelen";
            // 
            // feedBufDBDataSet2BindingSource
            // 
            this.feedBufDBDataSet2BindingSource.DataSource = this.feedBufDBDataSet2;
            this.feedBufDBDataSet2BindingSource.Position = 0;
            // 
            // feedupDataBindingSource
            // 
            this.feedupDataBindingSource.DataMember = "FeedupData";
            this.feedupDataBindingSource.DataSource = this.feedBufDBDataSet2BindingSource1;
            // 
            // feedupDataTableAdapter
            // 
            this.feedupDataTableAdapter.ClearBeforeFill = true;
            // 
            // feedupDataBindingSource1
            // 
            this.feedupDataBindingSource1.DataMember = "FeedupData";
            this.feedupDataBindingSource1.DataSource = this.feedBufDBDataSet2BindingSource1;
            // 
            // yesFinishedFeedupLstBx
            // 
            this.yesFinishedFeedupLstBx.FormattingEnabled = true;
            this.yesFinishedFeedupLstBx.ItemHeight = 16;
            this.yesFinishedFeedupLstBx.Location = new System.Drawing.Point(131, 128);
            this.yesFinishedFeedupLstBx.Name = "yesFinishedFeedupLstBx";
            this.yesFinishedFeedupLstBx.Size = new System.Drawing.Size(639, 532);
            this.yesFinishedFeedupLstBx.TabIndex = 6;
            // 
            // notFinishedFeedupLstBx
            // 
            this.notFinishedFeedupLstBx.FormattingEnabled = true;
            this.notFinishedFeedupLstBx.ItemHeight = 16;
            this.notFinishedFeedupLstBx.Location = new System.Drawing.Point(822, 128);
            this.notFinishedFeedupLstBx.Name = "notFinishedFeedupLstBx";
            this.notFinishedFeedupLstBx.Size = new System.Drawing.Size(639, 532);
            this.notFinishedFeedupLstBx.TabIndex = 7;
            // 
            // ProgressOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.notFinishedFeedupLstBx);
            this.Controls.Add(this.yesFinishedFeedupLstBx);
            this.Controls.Add(this.notFinishedFeedupDGVNameLbl);
            this.Controls.Add(this.finishedFeedupDGVNameLbl);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.pageNameLbl);
            this.Name = "ProgressOverview";
            this.Text = "ProgressOverview";
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBufDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedupDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pageNameLbl;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label finishedFeedupDGVNameLbl;
        private System.Windows.Forms.Label notFinishedFeedupDGVNameLbl;
        private System.Windows.Forms.BindingSource feedBufDBDataSet2BindingSource;
        private FeedBufDBDataSet2 feedBufDBDataSet2;
        private System.Windows.Forms.BindingSource feedBufDBDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource feedupDataBindingSource;
        private FeedBufDBDataSet2TableAdapters.FeedupDataTableAdapter feedupDataTableAdapter;
        private System.Windows.Forms.BindingSource feedupDataBindingSource1;
        private System.Windows.Forms.ListBox yesFinishedFeedupLstBx;
        private System.Windows.Forms.ListBox notFinishedFeedupLstBx;
    }
}