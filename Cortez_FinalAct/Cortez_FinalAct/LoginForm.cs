
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cortez_FinalAct
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Check empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (OleDbConnection connection =
                    DBConnection.GetConnection())
                {
                    connection.Open();

                    // Check account credentials
                    string query =
                        "SELECT COUNT(*) FROM Users " +
                        "WHERE Username = ? AND [Password] = ?";

                    using (OleDbCommand command =
                        new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add(
                            "?", OleDbType.VarWChar, 50
                        ).Value = username;

                        command.Parameters.Add(
                            "?", OleDbType.VarWChar, 255
                        ).Value = password;

                        int result = Convert.ToInt32(
                            command.ExecuteScalar()
                        );

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Login successful! Welcome back.",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Open Dashboard
                            this.Hide();

                            using (DashboardForm dashboard =
                                new DashboardForm())
                            {
                                dashboard.ShowDialog();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Incorrect username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to log in.\n\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Show or hide password
        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        // Open Sign Up form
        private void lnkSignUp_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SignUpForm signup = new SignUpForm())
            {
                this.Hide();
                signup.ShowDialog();
                this.Show();
            }
        }

        // Return to Welcome Page
        private void btnBack_Click(object sender, EventArgs e)
        {
            using (WelcomePage welcome = new WelcomePage())
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }
    }
}
