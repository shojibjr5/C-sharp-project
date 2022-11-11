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
    public partial class StaffDonorList : Form
    {
        BindingList<Donor> donor;
        string name;
        int id;
        public StaffDonorList(string _name = "Profile",int id=0)
        {
            InitializeComponent();
            name = profileNameLabel.Text = _name;
            this.id = id;

        }

        private void StaffDonorList_FormClosing(object sender, FormClosingEventArgs e)
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
            StaffProfile staffProfile = new StaffProfile(name,id);
            staffProfile.Show();
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
        private void StaffDonorList_Load(object sender, EventArgs e)
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
                    StaffDashboard form = new StaffDashboard();
                    form.Show();
                    Hide();
                }
            }
        }
    }
}
