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
    public partial class CollectBlood : Form
    {
        string name;
        int id;
        public CollectBlood(string _name = "Profile", int id=0)
        {
            InitializeComponent();
            name = profileNameLabel.Text = _name;
            this.id=id;
            
        }

        private void CollectBlood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(name,id);
            staffDashboard.Show();
            this.Hide();
        }

        private void addDonorButton_Click(object sender, EventArgs e)
        {
            AddDonor addDonor = new AddDonor(name,id);
            addDonor.Show();
            this.Hide();
        }

        private void donorListButton_Click(object sender, EventArgs e)
        {
            StaffDonorList staffDonorList = new StaffDonorList(name, id);
            staffDonorList.Show();
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

        private void CollectBlood_Load(object sender, EventArgs e)
        {
            string query = @"SELECT name FROM donor ORDER BY name";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                donorNameComboBox.Items.Add(dr.GetString(0));                           
                            }
                        }
                    }
                }

            }
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            string bg = "", donorName = donorNameComboBox.GetItemText(donorNameComboBox.SelectedItem);
            DateTime lastDonated = dateTimePicker.Value.Date;
            string query = @"SELECT bg FROM donor WHERE name = @donorName";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@donorName", donorName);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                bg = dr.GetString(0);
                            }
                        }

                    }
                }

            }
            query = @"UPDATE donor SET last_donated = @lastDonated WHERE name = @donorName";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@lastDonated", lastDonated);
                    cmd.Parameters.AddWithValue("@donorName", donorName);
                    cmd.ExecuteNonQuery();
                }
            }

            query = @"UPDATE bloodStock SET quantity += 1 WHERE bg = @bg";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bg", bg);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(bg + " blood collected");
                }
            }

        }

        private void donorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string name = donorNameComboBox.Items[cmb.SelectedIndex].ToString();
            string query = @"SELECT last_donated FROM donor WHERE name = @name";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                DateTime lastDonated = dr.GetDateTime(0);
                                DateTime current = dateTimePicker.Value;
                                double span = current.Subtract(lastDonated).TotalDays;
                                if (span < 90)
                                    MessageBox.Show("Too soon to donate");
                                else
                                    donateButton.Enabled = true;
                               
                                   
                            }
                        }
                    }
                }

            }
        }
    }
}
