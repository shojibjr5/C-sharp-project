
namespace Aiub_Blood_Bank
{
    partial class AddDonor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDonor));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.transferBloodButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.collectBloodButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.addDonorButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.bgComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.bgLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.ForeColor = System.Drawing.Color.Black;
            this.aiubLabel.Location = new System.Drawing.Point(367, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(210, 43);
            this.aiubLabel.TabIndex = 0;
            this.aiubLabel.Text = "Add Donor";
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
            this.profileNameLabel.TabIndex = 8;
            this.profileNameLabel.Text = "Staff(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
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
            this.panel1.TabIndex = 63;
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
            this.addDonorButton.BackColor = System.Drawing.Color.DarkGray;
            this.addDonorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDonorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDonorButton.ForeColor = System.Drawing.Color.White;
            this.addDonorButton.Location = new System.Drawing.Point(4, 49);
            this.addDonorButton.Name = "addDonorButton";
            this.addDonorButton.Size = new System.Drawing.Size(168, 40);
            this.addDonorButton.TabIndex = 0;
            this.addDonorButton.Text = "Add Donor";
            this.addDonorButton.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.genderPanel);
            this.panel.Controls.Add(this.bgComboBox);
            this.panel.Controls.Add(this.saveButton);
            this.panel.Controls.Add(this.addressTextBox);
            this.panel.Controls.Add(this.dobDateTimePicker);
            this.panel.Controls.Add(this.mobileTextBox);
            this.panel.Controls.Add(this.nameTextBox);
            this.panel.Controls.Add(this.addressLabel);
            this.panel.Controls.Add(this.bgLabel);
            this.panel.Controls.Add(this.genderLabel);
            this.panel.Controls.Add(this.dobLabel);
            this.panel.Controls.Add(this.mobileLabel);
            this.panel.Controls.Add(this.nameLabel);
            this.panel.Location = new System.Drawing.Point(237, 107);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(481, 389);
            this.panel.TabIndex = 64;
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.White;
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(219, 157);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(169, 29);
            this.genderPanel.TabIndex = 49;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(94, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 20);
            this.femaleRadioButton.TabIndex = 40;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(56, 20);
            this.maleRadioButton.TabIndex = 39;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // bgComboBox
            // 
            this.bgComboBox.FormattingEnabled = true;
            this.bgComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bgComboBox.Location = new System.Drawing.Point(219, 192);
            this.bgComboBox.Name = "bgComboBox";
            this.bgComboBox.Size = new System.Drawing.Size(169, 21);
            this.bgComboBox.TabIndex = 30;
            this.bgComboBox.Text = "Select blood group";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Red;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(196, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 38);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(219, 224);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(169, 62);
            this.addressTextBox.TabIndex = 28;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(219, 118);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2021, 8, 14, 21, 15, 45, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(169, 22);
            this.dobDateTimePicker.TabIndex = 26;
            this.dobDateTimePicker.Value = new System.DateTime(2021, 8, 14, 0, 0, 0, 0);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(219, 78);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(169, 22);
            this.mobileTextBox.TabIndex = 23;
            this.mobileTextBox.Leave += new System.EventHandler(this.mobileTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(219, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 22);
            this.nameTextBox.TabIndex = 22;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(118, 227);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 16);
            this.addressLabel.TabIndex = 21;
            this.addressLabel.Text = "Address";
            // 
            // bgLabel
            // 
            this.bgLabel.AutoSize = true;
            this.bgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgLabel.ForeColor = System.Drawing.Color.White;
            this.bgLabel.Location = new System.Drawing.Point(91, 192);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(93, 16);
            this.bgLabel.TabIndex = 20;
            this.bgLabel.Text = "Blood group";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(125, 157);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(59, 16);
            this.genderLabel.TabIndex = 19;
            this.genderLabel.Text = "Gender";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.White;
            this.dobLabel.Location = new System.Drawing.Point(92, 124);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(92, 16);
            this.dobLabel.TabIndex = 18;
            this.dobLabel.Text = "Date of birth";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.ForeColor = System.Drawing.Color.White;
            this.mobileLabel.Location = new System.Drawing.Point(129, 84);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(55, 16);
            this.mobileLabel.TabIndex = 17;
            this.mobileLabel.Text = "Moblie";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(135, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "AddDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aiub Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDonor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bloodStockButton;
        private System.Windows.Forms.Button transferBloodButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button collectBloodButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox bgComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label bgLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button addDonorButton;
    }
}