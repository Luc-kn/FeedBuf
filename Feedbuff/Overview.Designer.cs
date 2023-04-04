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
            this.closeBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.leerDoelenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goToFeedbackBtn
            // 
            this.goToFeedbackBtn.Location = new System.Drawing.Point(46, 306);
            this.goToFeedbackBtn.Name = "goToFeedbackBtn";
            this.goToFeedbackBtn.Size = new System.Drawing.Size(106, 35);
            this.goToFeedbackBtn.TabIndex = 0;
            this.goToFeedbackBtn.Text = "Feedback";
            this.goToFeedbackBtn.UseVisualStyleBackColor = true;
            this.goToFeedbackBtn.Click += new System.EventHandler(this.goToFeedbackBtn_Click);
            // 
            // feedForwardBtn
            // 
            this.feedForwardBtn.Location = new System.Drawing.Point(159, 306);
            this.feedForwardBtn.Name = "feedForwardBtn";
            this.feedForwardBtn.Size = new System.Drawing.Size(108, 35);
            this.feedForwardBtn.TabIndex = 1;
            this.feedForwardBtn.Text = "Feedforward";
            this.feedForwardBtn.UseVisualStyleBackColor = true;
            this.feedForwardBtn.Click += new System.EventHandler(this.feedForwardBtn_Click);
            // 
            // goalsLstBx
            // 
            this.goalsLstBx.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.goalsLstBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goalsLstBx.FormattingEnabled = true;
            this.goalsLstBx.ItemHeight = 16;
            this.goalsLstBx.Items.AddRange(new object[] {
            "Leerdoelen"});
            this.goalsLstBx.Location = new System.Drawing.Point(607, 40);
            this.goalsLstBx.Name = "goalsLstBx";
            this.goalsLstBx.Size = new System.Drawing.Size(138, 354);
            this.goalsLstBx.TabIndex = 3;
            // 
            // recentFeedbackLstBx
            // 
            this.recentFeedbackLstBx.FormattingEnabled = true;
            this.recentFeedbackLstBx.ItemHeight = 16;
            this.recentFeedbackLstBx.Items.AddRange(new object[] {
            "Feedback"});
            this.recentFeedbackLstBx.Location = new System.Drawing.Point(48, 58);
            this.recentFeedbackLstBx.Name = "recentFeedbackLstBx";
            this.recentFeedbackLstBx.Size = new System.Drawing.Size(490, 52);
            this.recentFeedbackLstBx.TabIndex = 4;
            // 
            // recentFeedforwardLstBx
            // 
            this.recentFeedforwardLstBx.FormattingEnabled = true;
            this.recentFeedforwardLstBx.ItemHeight = 16;
            this.recentFeedforwardLstBx.Items.AddRange(new object[] {
            "Feedforward"});
            this.recentFeedforwardLstBx.Location = new System.Drawing.Point(48, 117);
            this.recentFeedforwardLstBx.Name = "recentFeedforwardLstBx";
            this.recentFeedforwardLstBx.Size = new System.Drawing.Size(490, 52);
            this.recentFeedforwardLstBx.TabIndex = 5;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(48, 348);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 35);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Sluiten";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(159, 348);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(108, 35);
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.Text = "Uitloggen";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // leerDoelenBtn
            // 
            this.leerDoelenBtn.Location = new System.Drawing.Point(274, 306);
            this.leerDoelenBtn.Name = "leerDoelenBtn";
            this.leerDoelenBtn.Size = new System.Drawing.Size(104, 35);
            this.leerDoelenBtn.TabIndex = 9;
            this.leerDoelenBtn.Text = "Leerdoelen";
            this.leerDoelenBtn.UseVisualStyleBackColor = true;
            this.leerDoelenBtn.Click += new System.EventHandler(this.leerDoelenBtn_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leerDoelenBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.closeBtn);
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
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button leerDoelenBtn;
    }
}