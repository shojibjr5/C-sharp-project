using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Aiub_Blood_Bank
{
    public partial class Login : Form
    {
        public int id;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                errorProvider.SetError(this.userNameTextBox, "User Name Is Empty");
                return;
            }
            else if (passwordTextBox.Text == "")
            {
                errorProvider.SetError(this.passwordTextBox, "Password Is Empty");
                return;
            }
            else
            {
                errorProvider.Clear();
                string username = "", password = "", name="";
                bool isAdmin = true;
                string usernameInput = userNameTextBox.Text;
                string passwordInput = passwordTextBox.Text;
                string query = @"SELECT TOP 1 username, password,isAdmin, name, id FROM staff WHERE username = @username";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameInput);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    username = dr.GetString(0);
                                    password = dr.GetString(1);
                                    isAdmin = dr.GetBoolean(2);
                                    name = dr.GetString(3);
                                    id = dr.GetInt32(4);
                                }
                            }
                        } 

                    } 

                }

                if (!username.Equals(usernameInput) || !password.Equals(passwordInput))
                {
                    MessageBox.Show("Invalid User Name or Password!!");
                }
                else
                {
                    if(isAdmin)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard(name, id);
                        Hide();
                        adminDashboard.Show();
                    }
                    else
                    {
                        StaffDashboard staffDashboard = new StaffDashboard(name, id);
                        Hide();
                        staffDashboard.Show();
                    }
                } 
            }
        }
    }
}
