namespace Feedbuff
{
    partial class Student_Login
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
            this.fillInEmailTxtBx = new System.Windows.Forms.TextBox();
            this.fillInPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.noAcountLbl = new System.Windows.Forms.Label();
            this.passwordForgotenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(167, 253);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(90, 36);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(74, 253);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(87, 36);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(143, 61);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(133, 16);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login to your account";
            // 
            // fillInEmailTxtBx
            // 
            this.fillInEmailTxtBx.Location = new System.Drawing.Point(146, 119);
            this.fillInEmailTxtBx.Name = "fillInEmailTxtBx";
            this.fillInEmailTxtBx.Size = new System.Drawing.Size(143, 22);
            this.fillInEmailTxtBx.TabIndex = 3;
            // 
            // fillInPasswordTxtBx
            // 
            this.fillInPasswordTxtBx.Location = new System.Drawing.Point(146, 166);
            this.fillInPasswordTxtBx.Name = "fillInPasswordTxtBx";
            this.fillInPasswordTxtBx.Size = new System.Drawing.Size(143, 22);
            this.fillInPasswordTxtBx.TabIndex = 4;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(61, 119);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(41, 16);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(64, 171);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(67, 16);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // noAcountLbl
            // 
            this.noAcountLbl.AutoSize = true;
            this.noAcountLbl.Location = new System.Drawing.Point(12, 303);
            this.noAcountLbl.Name = "noAcountLbl";
            this.noAcountLbl.Size = new System.Drawing.Size(174, 16);
            this.noAcountLbl.TabIndex = 7;
            this.noAcountLbl.Text = "Geen account? registreer nu";
            // 
            // passwordForgotenBtn
            // 
            this.passwordForgotenBtn.Location = new System.Drawing.Point(263, 253);
            this.passwordForgotenBtn.Name = "passwordForgotenBtn";
            this.passwordForgotenBtn.Size = new System.Drawing.Size(173, 36);
            this.passwordForgotenBtn.TabIndex = 8;
            this.passwordForgotenBtn.Text = "Wachtwoord vergeten";
            this.passwordForgotenBtn.UseVisualStyleBackColor = true;
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 347);
            this.Controls.Add(this.passwordForgotenBtn);
            this.Controls.Add(this.noAcountLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.fillInPasswordTxtBx);
            this.Controls.Add(this.fillInEmailTxtBx);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Student_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox fillInEmailTxtBx;
        private System.Windows.Forms.TextBox fillInPasswordTxtBx;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label noAcountLbl;
        private System.Windows.Forms.Button passwordForgotenBtn;
    }
}