namespace Feedbuff
{
    partial class Welkom
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
            this.docentBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docentBtn
            // 
            this.docentBtn.Location = new System.Drawing.Point(46, 118);
            this.docentBtn.Name = "docentBtn";
            this.docentBtn.Size = new System.Drawing.Size(139, 45);
            this.docentBtn.TabIndex = 0;
            this.docentBtn.Text = "Docent";
            this.docentBtn.UseVisualStyleBackColor = true;
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(46, 47);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(139, 45);
            this.studentBtn.TabIndex = 2;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // Welkom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.docentBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Welkom";
            this.Text = "Choose your class";
            this.Load += new System.EventHandler(this.Welkom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button docentBtn;
        private System.Windows.Forms.Button studentBtn;
    }
}

