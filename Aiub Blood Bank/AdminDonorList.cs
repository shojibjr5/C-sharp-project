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
    public partial class AdminDonorList : Form
    {
        BindingList<Donor> donor;
        int id;
        string name;
        public AdminDonorList(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            this.id = id;
            this.name = profileNameLabel.Text = _name;
        }
        private void AdminDonorList_FormClosing(object sender, FormClosingEventArgs e)
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
            AdminProfile adminProfile = new AdminProfile(name,id);
            adminProfile.Show();
            this.Hide();
        }

        class Donor
        {
            public string Name { get; set; }
            public string Contact { get; set; }
            public string Blood_Group { get; set; }
            public string Address { get; set; }
            public DateTime Last_Donated { get; set; }
            public int id { get; set; }
        }

        private void AdminDonorList_Load(object sender, EventArgs e)
        {
            loadPatient();
        }
        private void loadPatient()
        {
            donor = new BindingList<Donor>();
            string query = @"SELECT name, mobile, bg, address, id FROM donor ORDER BY id";
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
                                donor.Add(new Donor { Name = dr.GetString(0), Contact = dr.GetString(1), Blood_Group = dr.GetString(2), Address = dr.GetString(3), id = dr.GetInt32(4) });
                            }
                            dataGridView.DataSource = donor;
                            dataGridView.AllowUserToAddRows = false;
                            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                            button.Name = "button";
                            button.HeaderText = "Delete";
                            button.Text = "Delete";
                            button.UseColumnTextForButtonValue = true;
                            dataGridView.Columns.Add(button);
                            dataGridView.Columns["id"].Visible = false;
                            dataGridView.ClearSelection();
                        }
                    }
                }

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string message = "Delete this record permanently?";
                string title = "Delete Item";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM patient WHERE Id = @id";
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    Hide();
                }
            }
        }
    }
}
