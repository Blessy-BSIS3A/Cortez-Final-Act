namespace Cortez_FinalAct
{
    partial class SignUpForm
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
            lblFullname = new Label();
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();
            lnkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(300, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create an Account";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(345, 100);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(196, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Fill in your details to get started.";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.ForeColor = Color.Maroon;
            lblFullname.Location = new Point(310, 145);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(62, 17);
            lblFullname.TabIndex = 2;
            lblFullname.Text = "Fullname:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(310, 165);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(280, 25);
            txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Maroon;
            lblUsername.Location = new Point(310, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 17);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 215);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 25);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Maroon;
            lblEmail.Location = new Point(310, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(310, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 25);
            txtEmail.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Maroon;
            lblPassword.Location = new Point(310, 295);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 17);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 25);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.LavenderBlush;
            lblConfirmPassword.ForeColor = Color.Maroon;
            lblConfirmPassword.Location = new Point(310, 345);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(114, 17);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(310, 365);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 25);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(325, 395);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(118, 21);
            chkShowPassword.TabIndex = 12;
            chkShowPassword.Text = "show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleVioletRed;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(310, 422);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(280, 42);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Create account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = Color.PaleVioletRed;
            lnkLogin.Location = new Point(345, 475);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(196, 17);
            lnkLogin.TabIndex = 14;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Already have an account? Log In";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(884, 511);
            Controls.Add(lnkLogin);
            Controls.Add(btnRegister);
            Controls.Add(chkShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblFullname);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullname;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowPassword;
        private Button btnRegister;
        private LinkLabel lnkLogin;
    }
}