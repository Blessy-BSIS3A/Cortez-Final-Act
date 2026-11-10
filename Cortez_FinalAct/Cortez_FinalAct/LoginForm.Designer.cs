namespace Cortez_FinalAct
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lnkSignUp = new LinkLabel();
            btnLogin = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(310, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(355, 105);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(154, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Please Log In to continue";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Maroon;
            lblUsername.Location = new Point(305, 180);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 17);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(295, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Maroon;
            lblPassword.Location = new Point(310, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 17);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(295, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(310, 293);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(118, 21);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.LinkColor = Color.PaleVioletRed;
            lnkSignUp.Location = new Point(340, 390);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(195, 17);
            lnkSignUp.TabIndex = 7;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Don't Have an account? Sign Up";
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleVioletRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(295, 329);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LavenderBlush;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Maroon;
            btnBack.Location = new Point(385, 440);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(884, 511);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(lnkSignUp);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private LinkLabel lnkSignUp;
        private Button btnLogin;
        private Button btnBack;
    }
}