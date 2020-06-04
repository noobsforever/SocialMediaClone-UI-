namespace SocialMediaClone
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gotoRegisterButton = new System.Windows.Forms.Button();
            this.loginConfirmButton = new System.Windows.Forms.Button();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gotoRegisterButton);
            this.panel1.Controls.Add(this.loginConfirmButton);
            this.panel1.Controls.Add(this.passwordLogin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(33, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 354);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Don\'t Have An Account? Register Now";
            // 
            // gotoRegisterButton
            // 
            this.gotoRegisterButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.gotoRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoRegisterButton.ForeColor = System.Drawing.Color.White;
            this.gotoRegisterButton.Location = new System.Drawing.Point(17, 264);
            this.gotoRegisterButton.Name = "gotoRegisterButton";
            this.gotoRegisterButton.Size = new System.Drawing.Size(393, 40);
            this.gotoRegisterButton.TabIndex = 15;
            this.gotoRegisterButton.Text = "Register";
            this.gotoRegisterButton.UseVisualStyleBackColor = false;
            // 
            // loginConfirmButton
            // 
            this.loginConfirmButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginConfirmButton.ForeColor = System.Drawing.Color.White;
            this.loginConfirmButton.Location = new System.Drawing.Point(17, 173);
            this.loginConfirmButton.Name = "loginConfirmButton";
            this.loginConfirmButton.Size = new System.Drawing.Size(393, 40);
            this.loginConfirmButton.TabIndex = 12;
            this.loginConfirmButton.Text = "Login";
            this.loginConfirmButton.UseVisualStyleBackColor = false;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(17, 135);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '•';
            this.passwordLogin.Size = new System.Drawing.Size(393, 20);
            this.passwordLogin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // emailLogin
            // 
            this.emailLogin.Location = new System.Drawing.Point(17, 67);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(393, 20);
            this.emailLogin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(161, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login Form";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button gotoRegisterButton;
        private System.Windows.Forms.Button loginConfirmButton;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}