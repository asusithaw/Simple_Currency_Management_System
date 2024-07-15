using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_Currency_Exchange_System.Entities;

namespace Simple_Currency_Exchange_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login() 
        {
            try
            {
                User.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                new MainForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
