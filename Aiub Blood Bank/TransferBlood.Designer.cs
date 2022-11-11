
namespace Aiub_Blood_Bank
{
    partial class TransferBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferBlood));
            this.Label = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.patientNameComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bgLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.transferBloodButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.collectBloodButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.addDonorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(337, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(285, 43);
            this.Label.TabIndex = 61;
            this.Label.Text = "Transfer Blood";
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
            this.profileNameLabel.TabIndex = 62;
            this.profileNameLabel.Text = "Staff(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.Red;
            this.transferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferButton.Enabled = false;
            this.transferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.ForeColor = System.Drawing.Color.Transparent;
            this.transferButton.Location = new System.Drawing.Point(462, 250);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(118, 38);
            this.transferButton.TabIndex = 70;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // patientNameComboBox
            // 
            this.patientNameComboBox.FormattingEnabled = true;
            this.patientNameComboBox.Location = new System.Drawing.Point(406, 172);
            this.patientNameComboBox.Name = "patientNameComboBox";
            this.patientNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.patientNameComboBox.TabIndex = 69;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(299, 172);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 16);
            this.nameLabel.TabIndex = 68;
            this.nameLabel.Text = "Patient Name";
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(646, 172);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.bloodGroupComboBox.TabIndex = 72;
            this.bloodGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.bloodGroupComboBox_SelectedIndexChanged);
            // 
            // bgLabel
            // 
            this.bgLabel.AutoSize = true;
            this.bgLabel.BackColor = System.Drawing.Color.Transparent;
            this.bgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgLabel.ForeColor = System.Drawing.Color.White;
            this.bgLabel.Location = new System.Drawing.Point(545, 172);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(95, 16);
            this.bgLabel.TabIndex = 71;
            this.bgLabel.Text = "Blood Group";
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
            this.panel1.TabIndex = 73;
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
            this.transferBloodButton.BackColor = System.Drawing.Color.DarkGray;
            this.transferBloodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferBloodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBloodButton.ForeColor = System.Drawing.Color.White;
            this.transferBloodButton.Location = new System.Drawing.Point(4, 279);
            this.transferBloodButton.Name = "transferBloodButton";
            this.transferBloodButton.Size = new System.Drawing.Size(168, 40);
            this.transferBloodButton.TabIndex = 6;
            this.transferBloodButton.Text = "Transfer Blood";
            this.transferBloodButton.UseVisualStyleBackColor = false;
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.LightGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(4, 233);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(168, 40);
            this.patientListButton.TabIndex = 5;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            this.patientListButton.Click += new System.EventHandler(this.patientListButton_Click);
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
            // TransferBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.bgLabel);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.patientNameComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "TransferBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aiub Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransferBlood_FormClosing);
            this.Load += new System.EventHandler(this.TransferBlood_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.ComboBox patientNameComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bgLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bloodStockButton;
        private System.Windows.Forms.Button transferBloodButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button collectBloodButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button addDonorButton;
    }
}