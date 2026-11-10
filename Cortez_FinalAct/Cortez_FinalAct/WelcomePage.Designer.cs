namespace Cortez_FinalAct
{
    partial class WelcomePage
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
            lblWelcome = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(305, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cortez Inventory";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(325, 115);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(229, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to my Inventory System";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleVioletRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(350, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.PaleVioletRed;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(350, 260);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(180, 45);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(884, 511);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Button btnLogin;
        private Button btnSignUp;
    }
}