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
    public partial class AdminDashboard : Form
    {
        int id;
        string name;

        public AdminDashboard(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            this.id = id;
            this.name = profileNameLabel.Text = _name;
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(name,id);
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

        private void bloodStockButton_Click(object sender, EventArgs e)
        {
            AdminBloodStock adminBloodStock = new AdminBloodStock(name, id);
            adminBloodStock.Show();
            this.Hide();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(name, id);
            adminProfile.Show();
            this.Hide();
        }
    }
}
