using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace Aiub_Blood_Bank
{
    public partial class AddDonor : Form
    {
        string name;
        int id;
        public AddDonor(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            name = profileNameLabel.Text = _name;
            this.id=id;

        }

        private void AddDonor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(name,id);
            staffDashboard.Show();
            this.Hide();
        }

        private void donorListButton_Click(object sender, EventArgs e)
        {
            StaffDonorList staffDonorList = new StaffDonorList(name, id);
            staffDonorList.Show();
            this.Hide();
        }

        private void collectBloodButton_Click(object sender, EventArgs e)
        {
            CollectBlood collectBlood = new CollectBlood(name, id);
            collectBlood.Show();
            this.Hide();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient(name, id);
            addPatient.Show();
            this.Hide();
        }

        private void patientListButton_Click(object sender, EventArgs e)
        {
            StaffPatientList staffPatientList = new StaffPatientList(name, id);
            staffPatientList.Show();
            this.Hide();
        }

        private void transferBloodButton_Click(object sender, EventArgs e)
        {
            TransferBlood transferBlood = new TransferBlood(name, id);
            transferBlood.Show();
            this.Hide();
        }

        private void bloodStockButton_Click(object sender, EventArgs e)
        {
            StaffBloodStock staffBloodStock = new StaffBloodStock(name, id);
            staffBloodStock.Show();
            this.Hide();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            StaffProfile staffProfile = new StaffProfile(name, id);
            staffProfile.Show();
            this.Hide();
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
        //End of regex validation..........
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                errorProvider.SetError(this.nameTextBox, "Name Is Empty");
                return;
            }
            else if (mobileTextBox.Text == "")
            {
                errorProvider.SetError(this.mobileTextBox, "Mobile Number Is Empty");
                return;
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                errorProvider.SetError(this.genderPanel, "Select Gender");
                return;
            }
            else if (bgComboBox.Text == "")
            {
                errorProvider.SetError(this.bgComboBox, "Blood Group Is Empty");
                return;
            }
            else if (addressTextBox.Text == "")
            {
                errorProvider.SetError(this.addressTextBox, "Address Is Empty");
                return;
            }
            else
            {
                errorProvider.Clear();
                string gender = maleRadioButton.Checked == true ? "male" : "female";
                DateTime date = Convert.ToDateTime(dobDateTimePicker.Text);
                string query = "INSERT INTO donor (name, mobile, dob, gender, bg, address) VALUES (@name, @mobile, @dob, @gender, @bg, @address)";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@mobile", mobileTextBox.Text);
                        cmd.Parameters.AddWithValue("@dob", date);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@bg", bgComboBox.Text);
                        cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("New Donor Added Succesfully!!");
                nameTextBox.Text = "";
                mobileTextBox.Text = "";
                bgComboBox.Text = "";
                addressTextBox.Text = "";
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
            }
        }

        
    }
}
