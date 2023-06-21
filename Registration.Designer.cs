namespace DearDiary
{
    partial class Registration
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
            this.UName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkToLogin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UName
            // 
            this.UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.Location = new System.Drawing.Point(474, 209);
            this.UName.Margin = new System.Windows.Forms.Padding(4);
            this.UName.Multiline = true;
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(304, 41);
            this.UName.TabIndex = 0;
            this.UName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UName.TextChanged += new System.EventHandler(this.UName_TextChanged);
            this.UName.Enter += new System.EventHandler(this.UName_Enter);
            this.UName.Leave += new System.EventHandler(this.UName_Leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(474, 273);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(304, 41);
            this.Username.TabIndex = 1;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(474, 349);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(304, 41);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // CPassword
            // 
            this.CPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPassword.Location = new System.Drawing.Point(474, 423);
            this.CPassword.Margin = new System.Windows.Forms.Padding(4);
            this.CPassword.Multiline = true;
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordChar = '*';
            this.CPassword.Size = new System.Drawing.Size(304, 41);
            this.CPassword.TabIndex = 3;
            this.CPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPassword.TextChanged += new System.EventHandler(this.CPassword_TextChanged);
            this.CPassword.Enter += new System.EventHandler(this.CPassword_Enter);
            this.CPassword.Leave += new System.EventHandler(this.CPassword_Leave);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignUp.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(539, 504);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(163, 58);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 591);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = " Already Member?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LinkToLogin
            // 
            this.LinkToLogin.AutoSize = true;
            this.LinkToLogin.BackColor = System.Drawing.Color.Transparent;
            this.LinkToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkToLogin.Location = new System.Drawing.Point(651, 591);
            this.LinkToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkToLogin.Name = "LinkToLogin";
            this.LinkToLogin.Size = new System.Drawing.Size(103, 20);
            this.LinkToLogin.TabIndex = 6;
            this.LinkToLogin.TabStop = true;
            this.LinkToLogin.Text = "Login here !!";
            this.LinkToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToLogin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 96);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dear Diary";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DearDiary.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 815);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkToLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.CPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkToLogin;
        private System.Windows.Forms.Label label2;
    }
}