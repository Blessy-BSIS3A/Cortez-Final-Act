
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cortez_FinalAct
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate empty fields
            if (fullName == "" || username == "" ||
                email == "" || password == "" ||
                confirmPassword == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            // Validate email
            try
            {
                var emailAddress =
                    new System.Net.Mail.MailAddress(email);

                if (emailAddress.Address != email)
                    throw new FormatException();
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must contain at least 6 characters."
                );
                return;
            }

            // Validate password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (OleDbConnection connection =
                    DBConnection.GetConnection())
                {
                    connection.Open();

                    // Check if an account already exists
                    string countQuery =
                        "SELECT COUNT(*) FROM Users";

                    using (OleDbCommand countCommand =
                        new OleDbCommand(countQuery, connection))
                    {
                        int accountCount = Convert.ToInt32(
                            countCommand.ExecuteScalar()
                        );

                        if (accountCount >= 1)
                        {
                            MessageBox.Show(
                                "An account has already been registered.",
                                "Registration Closed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    // Check duplicate username
                    string usernameQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username = ?";

                    using (OleDbCommand usernameCommand =
                        new OleDbCommand(usernameQuery, connection))
                    {
                        usernameCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 50
                        ).Value = username;

                        int usernameCount = Convert.ToInt32(
                            usernameCommand.ExecuteScalar()
                        );

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username is already taken.");
                            return;
                        }
                    }

                    // Check duplicate email
                    string emailQuery =
                        "SELECT COUNT(*) FROM Users WHERE Email = ?";

                    using (OleDbCommand emailCommand =
                        new OleDbCommand(emailQuery, connection))
                    {
                        emailCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 100
                        ).Value = email;

                        int emailCount = Convert.ToInt32(
                            emailCommand.ExecuteScalar()
                        );

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email is already registered.");
                            return;
                        }
                    }

                    // Register account
                    string insertQuery =
                        "INSERT INTO Users " +
                        "([FullName], [Username], [Email], [Password]) " +
                        "VALUES (?, ?, ?, ?)";

                    using (OleDbCommand insertCommand =
                        new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 100
                        ).Value = fullName;

                        insertCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 50
                        ).Value = username;

                        insertCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 100
                        ).Value = email;

                        insertCommand.Parameters.Add(
                            "?", OleDbType.VarWChar, 255
                        ).Value = password;

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Account created successfully!",
                        "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Clear fields
                    txtFullName.Clear();
                    txtUsername.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();

                    chkShowPassword.Checked = false;

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to register account.\n\n" + ex.Message,
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !showPassword;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword;
        }

        private void lnkLogin_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (LoginForm login = new LoginForm ())
            {
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
