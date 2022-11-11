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
    public partial class StaffProfile : Form
    {
        string name, password;
        int id;
        public StaffProfile(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            name = _name;
            this.id = id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(name, id);
            staffDashboard.Show();
            this.Hide();
        }

        private void StaffProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changePassLabel_Click(object sender, EventArgs e)
        {
            passwordPanel.Visible = !passwordPanel.Visible;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
                new Login().Show();
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]";
            if (Regex.IsMatch(nameTextBox.Text, pattern))
            {
                errorProvider.Clear();

            }
            else
            {
                errorProvider.SetError(this.nameTextBox, "Name must be character");
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


        // End of regex validator...................................................
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (nameTextBox.Text == "")
            {
                errorProvider.SetError(this.nameTextBox, "Name Is Empty");
                return;
            }
            else if (userNameTextBox.Text == "")
            {
                errorProvider.SetError(this.userNameTextBox, "User Name Is Empty");
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
            else if (addressTextBox.Text == "")
            {
                errorProvider.SetError(this.addressTextBox, "Address Is Empty");
                return;
            }
            else if (passwordPanel.Visible == true)
            {
                if (currentPassTextBox.Text == "")
                {
                    errorProvider.SetError(this.currentPassTextBox, "Current Password Is Empty");
                    return;
                }
                else if (newPassTextBox.Text == "")
                {
                    errorProvider.SetError(this.newPassTextBox, "New Password Is Empty");
                    return;
                }
                else if (newPassTextBox.Text != "")
                {
                    string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
                    if (Regex.IsMatch(newPassTextBox.Text, pattern))
                    {
                        errorProvider.Clear();

                    }
                    else
                    {
                        errorProvider.SetError(this.newPassTextBox, "Password must be atleast 8 characters and contains atleast one Upper case,lower case and number.");
                        error = true;
                        return;

                    }

                }

                else
                {
                    errorProvider.Clear();

                }
            }
            //////// End of empty validator using errorProvider 
            if(!error)
            {
                errorProvider.Clear();
                string gender = maleRadioButton.Checked == true ? "male" : "female";
                if (!passwordPanel.Visible)
                {
                    string query = @"UPDATE staff SET name = @name, username = @userName, dob = @dob, gender = @gender, bg = @bg, mobile = @mobile, email = @email, address = @address WHERE id = @id";
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                            cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@dob", dobDateTimePicker.Text);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@bg", bgComboBox.Text);
                            cmd.Parameters.AddWithValue("@mobile", mobileTextBox.Text);
                            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                            cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Profile updated");
                        }
                    }
                } 
                else
                {
                    if (!password.Equals(currentPassTextBox.Text))
                        MessageBox.Show("Current pass doesn't match");
                    else
                    {
                        string query = @"UPDATE staff SET name = @name, username = @userName, dob = @dob, gender = @gender, bg = @bg, mobile = @mobile, email = @email, address = @address, password = @password WHERE id = @id";
                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                                cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                                cmd.Parameters.AddWithValue("@dob", dobDateTimePicker.Text);
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@bg", bgComboBox.Text);
                                cmd.Parameters.AddWithValue("@mobile", mobileTextBox.Text);
                                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                                cmd.Parameters.AddWithValue("@password", newPassTextBox.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Profile and password updated");
                            }
                        }
                    }
                }
            }
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM staff WHERE id = @id";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                nameTextBox.Text = dr.GetString(1);
                                userNameTextBox.Text = dr.GetString(2);
                                dobDateTimePicker.Text = dr.GetString(3);
                                if (dr.GetString(4) == "male")
                                    maleRadioButton.Checked = true;
                                else
                                    femaleRadioButton.Checked = true;
                                bgComboBox.Text = dr.GetString(5);
                                mobileTextBox.Text = dr.GetString(6);
                                emailTextBox.Text = dr.GetString(7);
                                addressTextBox.Text = dr.GetString(8);
                                password = dr.GetString(9);
                            }
                        }
                    }
                }

            }
        }
    }
}
