
namespace Aiub_Blood_Bank
{
    partial class StaffPatientList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPatientList));
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.aiubLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.transferBloodButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.collectBloodButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.addDonorButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(12, 28);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(107, 20);
            this.profileNameLabel.TabIndex = 52;
            this.profileNameLabel.Text = "Staff(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(377, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(220, 43);
            this.aiubLabel.TabIndex = 51;
            this.aiubLabel.Text = "Patient List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bloodStockButton);
            this.panel1.Controls.Add(this.transferBloodButton);
            this.panel1.Controls.Add(this.patientListButton);
            this.panel1.Controls.Add(this.addPatientButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.collectBloodButton);
            this.panel1.Controls.Add(this.donorListButton);
            this.panel1.Controls.Add(this.addDonorButton);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 373);
            this.panel1.TabIndex = 64;
            // 
            // bloodStockButton
            // 
            this.bloodStockButton.BackColor = System.Drawing.Color.LightGray;
            this.bloodStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockButton.ForeColor = System.Drawing.Color.White;
            this.bloodStockButton.Location = new System.Drawing.Point(4, 325);
            this.bloodStockButton.Name = "bloodStockButton";
            this.bloodStockButton.Size = new System.Drawing.Size(168, 40);
            this.bloodStockButton.TabIndex = 63;
            this.bloodStockButton.Text = "Blood Stock";
            this.bloodStockButton.UseVisualStyleBackColor = false;
            this.bloodStockButton.Click += new System.EventHandler(this.bloodStockButton_Click);
            // 
            // transferBloodButton
            // 
            this.transferBloodButton.BackColor = System.Drawing.Color.LightGray;
            this.transferBloodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferBloodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBloodButton.ForeColor = System.Drawing.Color.White;
            this.transferBloodButton.Location = new System.Drawing.Point(4, 279);
            this.transferBloodButton.Name = "transferBloodButton";
            this.transferBloodButton.Size = new System.Drawing.Size(168, 40);
            this.transferBloodButton.TabIndex = 6;
            this.transferBloodButton.Text = "Transfer Blood";
            this.transferBloodButton.UseVisualStyleBackColor = false;
            this.transferBloodButton.Click += new System.EventHandler(this.transferBloodButton_Click);
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.DarkGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(4, 233);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(168, 40);
            this.patientListButton.TabIndex = 5;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.LightGray;
            this.addPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.ForeColor = System.Drawing.Color.White;
            this.addPatientButton.Location = new System.Drawing.Point(4, 187);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(168, 40);
            this.addPatientButton.TabIndex = 4;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.LightGray;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(4, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(168, 40);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // collectBloodButton
            // 
            this.collectBloodButton.BackColor = System.Drawing.Color.LightGray;
            this.collectBloodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectBloodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectBloodButton.ForeColor = System.Drawing.Color.White;
            this.collectBloodButton.Location = new System.Drawing.Point(4, 141);
            this.collectBloodButton.Name = "collectBloodButton";
            this.collectBloodButton.Size = new System.Drawing.Size(168, 40);
            this.collectBloodButton.TabIndex = 2;
            this.collectBloodButton.Text = "Collect Blood";
            this.collectBloodButton.UseVisualStyleBackColor = false;
            this.collectBloodButton.Click += new System.EventHandler(this.collectBloodButton_Click);
            // 
            // donorListButton
            // 
            this.donorListButton.BackColor = System.Drawing.Color.LightGray;
            this.donorListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donorListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorListButton.ForeColor = System.Drawing.Color.White;
            this.donorListButton.Location = new System.Drawing.Point(4, 95);
            this.donorListButton.Name = "donorListButton";
            this.donorListButton.Size = new System.Drawing.Size(168, 40);
            this.donorListButton.TabIndex = 1;
            this.donorListButton.Text = "Donor List";
            this.donorListButton.UseVisualStyleBackColor = false;
            this.donorListButton.Click += new System.EventHandler(this.donorListButton_Click);
            // 
            // addDonorButton
            // 
            this.addDonorButton.BackColor = System.Drawing.Color.LightGray;
            this.addDonorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDonorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDonorButton.ForeColor = System.Drawing.Color.White;
            this.addDonorButton.Location = new System.Drawing.Point(4, 49);
            this.addDonorButton.Name = "addDonorButton";
            this.addDonorButton.Size = new System.Drawing.Size(168, 40);
            this.addDonorButton.TabIndex = 0;
            this.addDonorButton.Text = "Add Donor";
            this.addDonorButton.UseVisualStyleBackColor = false;
            this.addDonorButton.Click += new System.EventHandler(this.addDonorButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(276, 123);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(546, 365);
            this.dataGridView.TabIndex = 65;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // StaffPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "StaffPatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aiub Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffPatientList_FormClosing);
            this.Load += new System.EventHandler(this.StaffPatientList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bloodStockButton;
        private System.Windows.Forms.Button transferBloodButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button collectBloodButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button addDonorButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}