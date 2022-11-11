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
    public partial class AdminBloodStock : Form
    {

        int id;
        string name;
        public AdminBloodStock(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            this.id = id;
            this.name = profileNameLabel.Text = _name;
        }

        private void AdminBloodStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(name, id);
            adminDashboard.Show();
            this.Hide();
        }

        private void staffListButton_Click(object sender, EventArgs e)
        {
            StaffList staffList = new StaffList(name, id);
            staffList.Show();
            this.Hide();
        }

        private void donorListButton_Click(object sender, EventArgs e)
        {
            AdminDonorList adminDonorList = new AdminDonorList(name, id);
            adminDonorList.Show();
            this.Hide();
        }

        private void patientListButton_Click(object sender, EventArgs e)
        {
            AdminPatientList adminPatientList = new AdminPatientList(name, id);
            adminPatientList.Show();
            this.Hide();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(name, id);
            adminProfile.Show();
            this.Hide();
        }

        private void AdminBloodStock_Load(object sender, EventArgs e)
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
