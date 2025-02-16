using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public bool isUpdate = false;

        public SignUp()   
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update button clicked!");
        }

        private bool isValid()
        {
            bool valid = true;


            // for text boxes
            if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(addressText.Text) 
                || string.IsNullOrEmpty(emailText.Text) || string.IsNullOrEmpty(ageText.Text)
                || string.IsNullOrEmpty(usernameText.Text) || string.IsNullOrEmpty(passwordText.Text)
                || string.IsNullOrEmpty(sayingText.Text))
            {
                valid = false;
            }

            if(maleButton.Checked == false && femaleButton.Checked == false)
            {

                valid = false;
            }

            if(volleyballButton.Checked == false && basketballButton.Checked == false)
            {
                valid = false;
            }

            if (!colorComboText.Items.Contains(colorComboText.Text))
            {
                valid = false;
            }

            if(birthdayText.Value == null)
            {
                valid = false;
            }

            return valid;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // check if add
            if (!this.isUpdate)
            {
                bool isValidForm = this.isValid();
                if (isValidForm)
                {
                    if (!DataManager.IsUsernameTaken(usernameText.Text))
                    {
                        // add to hash
                        bool added = DataManager.AddUser(usernameText.Text, passwordText.Text);
                        // pwede siya masulod
                        DataManager.UserData.Rows.Add(
                            nameText.Text,
                            addressText.Text,
                            emailText.Text,
                            ageText.Text,
                            usernameText.Text,
                            passwordText.Text,
                            sayingText.Text,
                            colorComboText.Text,
                            maleButton.Checked ? "Male" : "Female",
                            volleyballButton.Checked ? "Volleyball" : "Basketball",
                            birthdayText.Value.ToShortDateString()
                        );

                        MessageBox.Show("User Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("not added user exist");
                    }

                }
                else
                {
                    MessageBox.Show("invalid");

                }
            }
            else
            {
                // update record
                foreach (DataRow row in DataManager.UserData.Rows)
                {
                    if (row["username"].ToString() == usernameText.Text)
                    {
                        row["name"] = nameText.Text;
                        row["address"] = addressText.Text;
                        row["email"] = emailText.Text;
                        row["age"] = ageText.Text;
                        row["saying"] = sayingText.Text;
                        row["password"] = passwordText.Text;
                        row["color"] = colorComboText.Text;
                        row["gender"] = maleButton.Checked ? "Male" : "Female";
                        row["sport"] = volleyballButton.Checked ? "Volleyball" : "Basketball";
                        row["birthday"] = birthdayText.Value.ToShortDateString();

                        MessageBox.Show("User Updated Successfully!");
                        break;
                    }
                }

                SetAddMode();
                ClearFields();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void SetUpdateMode(string name, string address, string email, string age,
                          string username, string saying, string color,
                          string gender, string sport, string birthday, string password)
        {
            this.isUpdate = true;
            this.Text = "Update User";
            addButton.Text = "Update";
            label11.Text = "Update user";
            maptoSigninButton.Visible = false;

            nameText.Text = name;
            addressText.Text = address;
            emailText.Text = email;
            ageText.Text = age;
            usernameText.Text = username;
            sayingText.Text = saying;
            colorComboText.Text = color;
            passwordText.Text = password;

            maleButton.Checked = gender == "Male";
            femaleButton.Checked = gender == "Female";

            volleyballButton.Checked = sport == "Volleyball";
            basketballButton.Checked = sport == "Basketball";

            birthdayText.Value = DateTime.Parse(birthday);
        }


        public void SetAddMode()
        {
            this.isUpdate = false;
            this.Text = "Add User";
            addButton.Text = "Add";
            label11.Text = "Add user";
            maptoSigninButton.Visible = true;
        }

        public void ClearFields()
        {
            nameText.Clear();
            addressText.Clear();
            emailText.Clear();
            ageText.Clear();
            usernameText.Clear();
            passwordText.Clear();
            sayingText.Clear();

            maleButton.Checked = false;
            femaleButton.Checked = false;

            volleyballButton.Checked = false;
            basketballButton.Checked = false;

            if (colorComboText.Items.Count > 0)
            {
                colorComboText.SelectedIndex = 0; 
            }
            else
            {
                colorComboText.Text = ""; 
            }

            birthdayText.Value = DateTime.Today;
        }

        private void maptoSigninButton_Click(object sender, EventArgs e)
        {
            SignIn redirectSignin = new SignIn();
            redirectSignin.Show();
        }
    }
}
