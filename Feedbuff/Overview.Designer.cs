namespace Feedbuff
{
    partial class Overview
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
            this.goToFeedbackBtn = new System.Windows.Forms.Button();
            this.feedForwardBtn = new System.Windows.Forms.Button();
            this.goalsLstBx = new System.Windows.Forms.ListBox();
            this.recentFeedbackLstBx = new System.Windows.Forms.ListBox();
            this.recentFeedforwardLstBx = new System.Windows.Forms.ListBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.FeedupBtn = new System.Windows.Forms.Button();
            this.toProgressOverviewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goToFeedbackBtn
            // 
            this.goToFeedbackBtn.Location = new System.Drawing.Point(161, 294);
            this.goToFeedbackBtn.Name = "goToFeedbackBtn";
            this.goToFeedbackBtn.Size = new System.Drawing.Size(106, 47);
            this.goToFeedbackBtn.TabIndex = 0;
            this.goToFeedbackBtn.Text = "Feedback in zien";
            this.goToFeedbackBtn.UseVisualStyleBackColor = true;
            this.goToFeedbackBtn.Click += new System.EventHandler(this.goToFeedbackBtn_Click);
            // 
            // feedForwardBtn
            // 
            this.feedForwardBtn.Location = new System.Drawing.Point(45, 294);
            this.feedForwardBtn.Name = "feedForwardBtn";
            this.feedForwardBtn.Size = new System.Drawing.Size(108, 47);
            this.feedForwardBtn.TabIndex = 1;
            this.feedForwardBtn.Text = "Feedforward in zien";
            this.feedForwardBtn.UseVisualStyleBackColor = true;
            this.feedForwardBtn.Click += new System.EventHandler(this.feedForwardBtn_Click);
            // 
            // goalsLstBx
            // 
            this.goalsLstBx.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.goalsLstBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goalsLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsLstBx.FormattingEnabled = true;
            this.goalsLstBx.HorizontalScrollbar = true;
            this.goalsLstBx.ItemHeight = 22;
            this.goalsLstBx.Items.AddRange(new object[] {
            "Leerdoelen van de huidige week."});
            this.goalsLstBx.Location = new System.Drawing.Point(611, 40);
            this.goalsLstBx.Name = "goalsLstBx";
            this.goalsLstBx.Size = new System.Drawing.Size(901, 596);
            this.goalsLstBx.TabIndex = 3;
            // 
            // recentFeedbackLstBx
            // 
            this.recentFeedbackLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentFeedbackLstBx.FormattingEnabled = true;
            this.recentFeedbackLstBx.ItemHeight = 22;
            this.recentFeedbackLstBx.Items.AddRange(new object[] {
            "Meest recente feedback "});
            this.recentFeedbackLstBx.Location = new System.Drawing.Point(48, 63);
            this.recentFeedbackLstBx.Name = "recentFeedbackLstBx";
            this.recentFeedbackLstBx.Size = new System.Drawing.Size(490, 48);
            this.recentFeedbackLstBx.TabIndex = 4;
            // 
            // recentFeedforwardLstBx
            // 
            this.recentFeedforwardLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentFeedforwardLstBx.FormattingEnabled = true;
            this.recentFeedforwardLstBx.ItemHeight = 22;
            this.recentFeedforwardLstBx.Items.AddRange(new object[] {
            "Meest recente feedforward"});
            this.recentFeedforwardLstBx.Location = new System.Drawing.Point(48, 117);
            this.recentFeedforwardLstBx.Name = "recentFeedforwardLstBx";
            this.recentFeedforwardLstBx.Size = new System.Drawing.Size(490, 48);
            this.recentFeedforwardLstBx.TabIndex = 5;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(48, 601);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(104, 35);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "Uitloggen";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // FeedupBtn
            // 
            this.FeedupBtn.Location = new System.Drawing.Point(159, 347);
            this.FeedupBtn.Name = "FeedupBtn";
            this.FeedupBtn.Size = new System.Drawing.Size(108, 47);
            this.FeedupBtn.TabIndex = 8;
            this.FeedupBtn.Text = "Feedup in zien";
            this.FeedupBtn.UseVisualStyleBackColor = true;
            this.FeedupBtn.Click += new System.EventHandler(this.FeedupBtn_Click);
            // 
            // toProgressOverviewBtn
            // 
            this.toProgressOverviewBtn.Location = new System.Drawing.Point(45, 347);
            this.toProgressOverviewBtn.Name = "toProgressOverviewBtn";
            this.toProgressOverviewBtn.Size = new System.Drawing.Size(108, 47);
            this.toProgressOverviewBtn.TabIndex = 9;
            this.toProgressOverviewBtn.Text = "Voortgang overview";
            this.toProgressOverviewBtn.UseVisualStyleBackColor = true;
            this.toProgressOverviewBtn.Click += new System.EventHandler(this.toProgressOverviewBtn_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.toProgressOverviewBtn);
            this.Controls.Add(this.FeedupBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.recentFeedforwardLstBx);
            this.Controls.Add(this.recentFeedbackLstBx);
            this.Controls.Add(this.goalsLstBx);
            this.Controls.Add(this.feedForwardBtn);
            this.Controls.Add(this.goToFeedbackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToFeedbackBtn;
        private System.Windows.Forms.Button feedForwardBtn;
        private System.Windows.Forms.ListBox goalsLstBx;
        private System.Windows.Forms.ListBox recentFeedbackLstBx;
        private System.Windows.Forms.ListBox recentFeedforwardLstBx;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button FeedupBtn;
        private System.Windows.Forms.Button toProgressOverviewBtn;
    }
}