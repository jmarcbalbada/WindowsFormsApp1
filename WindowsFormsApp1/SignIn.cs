using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim();
            string password = passwordText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                validationLabel.Text = "Please enter both username and password.";
                validationLabel.ForeColor = Color.Red;
                return;
            }

            if (DataManager.users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                validationLabel.Text = "Login successful!";
                validationLabel.ForeColor = Color.Green;

                MessageBox.Show("Welcome, " + username + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();  
            }
            else
            {
                validationLabel.Text = "Invalid username or password.";
                validationLabel.ForeColor = Color.Red;
            }
        }

    }
}
