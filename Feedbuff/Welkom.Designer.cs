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
            this.welkomTxtBx = new System.Windows.Forms.TextBox();
            this.feedbufInformationTxtBx = new System.Windows.Forms.TextBox();
            this.choiceTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // docentBtn
            // 
            this.docentBtn.Location = new System.Drawing.Point(225, 214);
            this.docentBtn.Name = "docentBtn";
            this.docentBtn.Size = new System.Drawing.Size(139, 45);
            this.docentBtn.TabIndex = 0;
            this.docentBtn.Text = "Docent";
            this.docentBtn.UseVisualStyleBackColor = true;
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(417, 214);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(139, 45);
            this.studentBtn.TabIndex = 2;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // welkomTxtBx
            // 
            this.welkomTxtBx.Location = new System.Drawing.Point(46, 30);
            this.welkomTxtBx.Name = "welkomTxtBx";
            this.welkomTxtBx.Size = new System.Drawing.Size(292, 22);
            this.welkomTxtBx.TabIndex = 3;
            this.welkomTxtBx.Text = "Welkom bij feebuf";
            // 
            // feedbufInformationTxtBx
            // 
            this.feedbufInformationTxtBx.Location = new System.Drawing.Point(46, 74);
            this.feedbufInformationTxtBx.Name = "feedbufInformationTxtBx";
            this.feedbufInformationTxtBx.Size = new System.Drawing.Size(292, 22);
            this.feedbufInformationTxtBx.TabIndex = 4;
            this.feedbufInformationTxtBx.Text = "Informatie";
            // 
            // choiceTxtBx
            // 
            this.choiceTxtBx.Location = new System.Drawing.Point(225, 171);
            this.choiceTxtBx.Name = "choiceTxtBx";
            this.choiceTxtBx.Size = new System.Drawing.Size(331, 22);
            this.choiceTxtBx.TabIndex = 5;
            this.choiceTxtBx.Text = "Kies hoe u deze applicatie wilt gebruiken";
            // 
            // Welkom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choiceTxtBx);
            this.Controls.Add(this.feedbufInformationTxtBx);
            this.Controls.Add(this.welkomTxtBx);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.docentBtn);
            this.Name = "Welkom";
            this.Text = "WelkomMenu";
            this.Load += new System.EventHandler(this.Welkom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button docentBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.TextBox welkomTxtBx;
        private System.Windows.Forms.TextBox feedbufInformationTxtBx;
        private System.Windows.Forms.TextBox choiceTxtBx;
    }
}

