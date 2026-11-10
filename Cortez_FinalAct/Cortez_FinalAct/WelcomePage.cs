using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cortez_FinalAct
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.ShowDialog();
        }
    }
}
