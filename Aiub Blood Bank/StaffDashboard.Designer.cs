
namespace Aiub_Blood_Bank
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.addDonorButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.collectBloodButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.transferBloodButton = new System.Windows.Forms.Button();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(287, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(374, 43);
            this.aiubLabel.TabIndex = 0;
            this.aiubLabel.Text = "AIUB BLOOD BANK";
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(35, 29);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(128, 24);
            this.profileNameLabel.TabIndex = 1;
            this.profileNameLabel.Text = "Staff(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // addDonorButton
            // 
            this.addDonorButton.BackColor = System.Drawing.Color.LightGray;
            this.addDonorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDonorButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDonorButton.ForeColor = System.Drawing.Color.White;
            this.addDonorButton.Location = new System.Drawing.Point(111, 163);
            this.addDonorButton.Name = "addDonorButton";
            this.addDonorButton.Size = new System.Drawing.Size(190, 60);
            this.addDonorButton.TabIndex = 2;
            this.addDonorButton.Text = "Add Donor";
            this.addDonorButton.UseVisualStyleBackColor = false;
            this.addDonorButton.Click += new System.EventHandler(this.addDonorButton_Click);
            // 
            // donorListButton
            // 
            this.donorListButton.BackColor = System.Drawing.Color.LightGray;
            this.donorListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donorListButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorListButton.ForeColor = System.Drawing.Color.White;
            this.donorListButton.Location = new System.Drawing.Point(389, 163);
            this.donorListButton.Name = "donorListButton";
            this.donorListButton.Size = new System.Drawing.Size(190, 60);
            this.donorListButton.TabIndex = 3;
            this.donorListButton.Text = "Donor List";
            this.donorListButton.UseVisualStyleBackColor = false;
            this.donorListButton.Click += new System.EventHandler(this.donorListButton_Click);
            // 
            // collectBloodButton
            // 
            this.collectBloodButton.BackColor = System.Drawing.Color.LightGray;
            this.collectBloodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectBloodButton.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectBloodButton.ForeColor = System.Drawing.Color.White;
            this.collectBloodButton.Location = new System.Drawing.Point(672, 163);
            this.collectBloodButton.Name = "collectBloodButton";
            this.collectBloodButton.Size = new System.Drawing.Size(190, 60);
            this.collectBloodButton.TabIndex = 4;
            this.collectBloodButton.Text = "Collect Blood";
            this.collectBloodButton.UseVisualStyleBackColor = false;
            this.collectBloodButton.Click += new System.EventHandler(this.collectBloodButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.LightGray;
            this.addPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPatientButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.ForeColor = System.Drawing.Color.White;
            this.addPatientButton.Location = new System.Drawing.Point(111, 268);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(190, 60);
            this.addPatientButton.TabIndex = 5;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.LightGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(389, 268);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(190, 60);
            this.patientListButton.TabIndex = 6;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            this.patientListButton.Click += new System.EventHandler(this.patientListButton_Click);
            // 
            // transferBloodButton
            // 
            this.transferBloodButton.BackColor = System.Drawing.Color.LightGray;
            this.transferBloodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferBloodButton.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBloodButton.ForeColor = System.Drawing.Color.White;
            this.transferBloodButton.Location = new System.Drawing.Point(672, 268);
            this.transferBloodButton.Name = "transferBloodButton";
            this.transferBloodButton.Size = new System.Drawing.Size(190, 60);
            this.transferBloodButton.TabIndex = 7;
            this.transferBloodButton.Text = "Transfer Blood";
            this.transferBloodButton.UseVisualStyleBackColor = false;
            this.transferBloodButton.Click += new System.EventHandler(this.transferBloodButton_Click);
            // 
            // bloodStockButton
            // 
            this.bloodStockButton.BackColor = System.Drawing.Color.LightGray;
            this.bloodStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodStockButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockButton.ForeColor = System.Drawing.Color.White;
            this.bloodStockButton.Location = new System.Drawing.Point(389, 368);
            this.bloodStockButton.Name = "bloodStockButton";
            this.bloodStockButton.Size = new System.Drawing.Size(190, 60);
            this.bloodStockButton.TabIndex = 8;
            this.bloodStockButton.Text = "Blood Stock";
            this.bloodStockButton.UseVisualStyleBackColor = false;
            this.bloodStockButton.Click += new System.EventHandler(this.bloodStockButton_Click);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.bloodStockButton);
            this.Controls.Add(this.transferBloodButton);
            this.Controls.Add(this.patientListButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.collectBloodButton);
            this.Controls.Add(this.donorListButton);
            this.Controls.Add(this.addDonorButton);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffDashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Button addDonorButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button collectBloodButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button transferBloodButton;
        private System.Windows.Forms.Button bloodStockButton;
    }
}