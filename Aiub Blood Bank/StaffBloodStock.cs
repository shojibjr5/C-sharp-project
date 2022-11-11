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
    public partial class StaffBloodStock : Form
    {
        string name;
        int id;
        public StaffBloodStock(string _name = "Profile",int id=0)
        {
            InitializeComponent();
            name = profileNameLabel.Text = _name;
            this.id = id;

        }

        private void StaffBloodStock_FormClosing(object sender, FormClosingEventArgs e)
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

        private void transferBloodButton_Click(object sender, EventArgs e)
        {
            TransferBlood transferBlood = new TransferBlood(name, id);
            transferBlood.Show();
            this.Hide();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            StaffProfile staffProfile = new StaffProfile(name, id);
            staffProfile.Show();
            this.Hide();
        }

        private void StaffBloodStock_Load(object sender, EventArgs e)
        {
            string query = @"SELECT bg, quantity FROM bloodStock";
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
                                switch (dr.GetString(0))
                                {
                                    case "A+":
                                        apcount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "A-":
                                        anCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "B+":
                                        bpCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "B-":
                                        bnCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "AB+":
                                        abpCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "AB-":
                                        abnCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "O+":
                                        opCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    case "O-":
                                        onCount.Text = dr.GetInt32(1).ToString();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
