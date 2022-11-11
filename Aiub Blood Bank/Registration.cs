using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Aiub_Blood_Bank
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //Starting of regex validatior...............................................
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
             string pattern = "^[a-zA-Z]";
            if (Regex.IsMatch(nameTextBox.Text, pattern))
            {
                errorProvider.Clear();
                
            }
            else
            {
                errorProvider.SetError(this.nameTextBox,"Name must be character");
                return;              
            }          
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z]";
            if (Regex.IsMatch(userNameTextBox.Text, pattern))
            {
                errorProvider.Clear();
                
            }
            else
            {
                errorProvider.SetError(this.userNameTextBox, "User Name must be small character");
                return;
            }
        }

        private void mobileTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^[0-9]*$";
            if (Regex.IsMatch(mobileTextBox.Text, pattern))
            {
                errorProvider.Clear();
                

            }
            else
            {
                errorProvider.SetError(this.mobileTextBox, "Mobile number must be integer");
                return;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (Regex.IsMatch(emailTextBox.Text, pattern))
            {
                errorProvider.Clear();
                
            }
            else
            {
                errorProvider.SetError(this.emailTextBox, "Give a valid mail address");
                return;
            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z0-9*$]";
            if (Regex.IsMatch(addressTextBox.Text, pattern))
            {
                errorProvider.Clear();
                
            }
            else
            {
                errorProvider.SetError(this.addressTextBox, "Input address");
                return;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
            if (Regex.IsMatch(passwordTextBox.Text, pattern))
            {
                errorProvider.Clear();

            }
            else
            {
                errorProvider.SetError(this.passwordTextBox, "Password must be atleast 8 characters and contains atleast one Upper case,lower case and number.");
                return;
            }
        }

        private void confirmPassTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
            if (Regex.IsMatch(confirmPassTextBox.Text, pattern))
            {
                errorProvider.Clear();

            }
            else
            {
                errorProvider.SetError(this.confirmPassTextBox, "Confirm password must be atleast 8 characters and contains atleast one Upper case,lower and number");
                return;
            }
        }


        // End of regex validator...................................................

        private void tcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (signUpButton.Enabled == false)
            {
                signUpButton.Enabled = true;
            }
            else
            {
                signUpButton.Enabled = false;
            }
        }

        // Empty validator using errorProvider............................

        private void signUpButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text=="")
            {
                errorProvider.SetError(this.nameTextBox, "Name Is Empty");
                return;
            }
            else if (userNameTextBox.Text == "")
            {
                errorProvider.SetError(this.userNameTextBox, "User Name Is Empty");
                return;
            }
            else if(dobDateTimePicker.Text=="")
            {
                errorProvider.SetError(this.dobDateTimePicker, "Select Birth Date");
                return;
            }
            else if(maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                errorProvider.SetError(this.genderPanel, "Select Gender");
                return;
            }
            else if (bgComboBox.Text == "")
            {
                errorProvider.SetError(this.bgComboBox, "Blood Group Is Empty");
                return;
            }
            else if (mobileTextBox.Text == "")
            {
                errorProvider.SetError(this.mobileTextBox, "Mobile Number Is Empty");
                return;
            }
            else if (emailTextBox.Text == "")
            {
                errorProvider.SetError(this.emailTextBox, "Mail Address Is Empty");
                return;
            }
            else if(addressTextBox.Text=="")
            {
                errorProvider.SetError(this.addressTextBox, "Address Is Empty");
                return;
            }
            else if(passwordTextBox.Text =="")
            {
                errorProvider.SetError(this.passwordTextBox, "Password Is Empty");
                return;
            }
            else if (confirmPassTextBox.Text == "")
            {
                errorProvider.SetError(this.confirmPassTextBox, "Confirm Password Is Empty");
                return;
            }
            else if(passwordTextBox.Text != confirmPassTextBox.Text)
            {
                errorProvider.SetError(this.passwordPanel, "Password Does Not Matched");
                return;
            }
            //////// End of empty validator using errorProvider 
            else
            {
                errorProvider.Clear();
                string query = @"SELECT TOP 1 username FROM staff WHERE username = @username";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", userNameTextBox.Text);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    if(dr.GetString(0).Equals(userNameTextBox.Text))
                                    {
                                        MessageBox.Show("Username already registered");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }

                string gender = maleRadioButton.Checked == true ? "male" : "female";
                query = "INSERT INTO staff (name, username, dob, gender, bg, mobile, email, address, password) VALUES (@name, @username, @dob, @gender, @bg, @mobile, @email, @address, @password)";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@username", userNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@dob", dobDateTimePicker.Text);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@bg", bgComboBox.Text);
                        cmd.Parameters.AddWithValue("@mobile", mobileTextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                Login login = new Login();
                login.Show();
                this.Hide();
            }


        }
    }
}
