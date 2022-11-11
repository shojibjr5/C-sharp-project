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
    public partial class TransferBlood : Form
    {
        string name;
        int id;
        public TransferBlood(string _name = "Profile", int id=0)
        {
            InitializeComponent();
            name = profileNameLabel.Text = _name;
            this.id = id;

        }

        private void TransferBlood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard(name, id);
            staffDashboard.Show();
            this.Hide();
        }

        private void addDonorButton_Click(object sender, EventArgs e)
        {
            AddDonor addDonor = new AddDonor(name, id);
            addDonor.Show();
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

        private void TransferBlood_Load(object sender, EventArgs e)
        {
            string query = @"SELECT name FROM patient ORDER BY name";
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
                                patientNameComboBox.Items.Add(dr.GetString(0));
                            }
                        }
                    }
                }

            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            string bg = bloodGroupComboBox.GetItemText(bloodGroupComboBox.SelectedItem);
            string query = @"UPDATE bloodStock SET quantity = quantity - 1 WHERE bg = @bg";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bg", bg);
                    cmd.ExecuteReader();
                    MessageBox.Show(bg + " blood transfered succesfully");
                    bloodGroupComboBox.Text = "";
                }

            }
        }

        private void bloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox) sender;
            string bg = bloodGroupComboBox.Items[cmb.SelectedIndex].ToString();
            string query = @"SELECT quantity FROM bloodStock WHERE bg = @bg";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bg", bg);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                transferButton.Enabled = dr.GetInt32(0) == 0 ? false : true;
                            }
                        }
                    }
                }

            }
        }
    }
}
