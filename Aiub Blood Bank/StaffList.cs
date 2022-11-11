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
    public partial class StaffList : Form
    {
        int id;
        string name;
        BindingList<Staff> staffs;
        public StaffList(string _name = "Profile", int id = 0)
        {
            InitializeComponent();
            this.id = id;
            this.name =profileNameLabel.Text= _name;
        }

        private void StaffList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(name, id);
            adminDashboard.Show();
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

        class Staff
        {
            public string Name { get; set; }
            public string Contact { get; set; }
            public bool Verified { get; set; }
            public bool Admin { get; set; }
            public int id { get; set; }
        }

        private void loadstaff()
        {
            staffs = new BindingList<Staff>();
            string query = @"SELECT name, mobile, isVerified, isAdmin, id FROM staff WHERE id != @id ORDER BY id";
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
                              
                                staffs.Add(new Staff { Name = dr.GetString(0), Contact = dr.GetString(1), Verified = dr.GetBoolean(2), Admin = dr.GetBoolean(3), id = dr.GetInt32(4) });
                            }
                            dataGridView.DataSource = staffs;
                            dataGridView.AllowUserToAddRows = false;
                            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                            button.Name = "button";
                            button.HeaderText = "Delete";
                            button.Text = "Delete";
                            button.UseColumnTextForButtonValue = true;
                            dataGridView.Columns.Add(button);
                            dataGridView.Columns["id"].Visible = false;
                        }
                    }
                }
            }
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            loadstaff();
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
                    string query = "DELETE FROM staff WHERE Id = @id";
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    AdminDashboard form = new AdminDashboard(name, this.id);
                    form.Show();
                    Hide();


                }
                return;
            }

            if (e.ColumnIndex == 2)
            {
                int id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell) dataGridView.Rows[e.RowIndex].Cells[2];
                bool isChecked = Convert.ToBoolean(checkCell.Value);
                string query = "UPDATE staff SET isVerified = @isVerified WHERE Id = @id";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@isVerified", !isChecked);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return;
            }

            if (e.ColumnIndex == 3)
            {
                int id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView.Rows[e.RowIndex].Cells[3];
                bool isChecked = Convert.ToBoolean(checkCell.Value);
                string query = "UPDATE staff SET isAdmin = @isAdmin WHERE Id = @id";
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@isAdmin", !isChecked);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return;
            }
        }
    }
}
