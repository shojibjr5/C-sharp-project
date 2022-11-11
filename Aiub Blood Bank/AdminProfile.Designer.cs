
namespace Aiub_Blood_Bank
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.currentPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.changePassLabel = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.bgComboBox = new System.Windows.Forms.ComboBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.bgLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(291, 4);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(374, 43);
            this.aiubLabel.TabIndex = 26;
            this.aiubLabel.Text = "AIUB BLOOD BANK";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.passwordPanel);
            this.panel.Controls.Add(this.changePassLabel);
            this.panel.Controls.Add(this.genderPanel);
            this.panel.Controls.Add(this.bgComboBox);
            this.panel.Controls.Add(this.logOutButton);
            this.panel.Controls.Add(this.backButton);
            this.panel.Controls.Add(this.saveButton);
            this.panel.Controls.Add(this.addressTextBox);
            this.panel.Controls.Add(this.emailTextBox);
            this.panel.Controls.Add(this.mobileTextBox);
            this.panel.Controls.Add(this.dobDateTimePicker);
            this.panel.Controls.Add(this.userNameTextBox);
            this.panel.Controls.Add(this.nameTextBox);
            this.panel.Controls.Add(this.genderLabel);
            this.panel.Controls.Add(this.bgLabel);
            this.panel.Controls.Add(this.mobileLabel);
            this.panel.Controls.Add(this.emailLabel);
            this.panel.Controls.Add(this.addressLabel);
            this.panel.Controls.Add(this.dobLabel);
            this.panel.Controls.Add(this.userNameLabel);
            this.panel.Controls.Add(this.nameLabel);
            this.panel.Location = new System.Drawing.Point(238, 66);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(490, 443);
            this.panel.TabIndex = 29;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.newPassTextBox);
            this.passwordPanel.Controls.Add(this.currentPassTextBox);
            this.passwordPanel.Controls.Add(this.newPassLabel);
            this.passwordPanel.Controls.Add(this.currentPasswordLabel);
            this.passwordPanel.Location = new System.Drawing.Point(19, 325);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(447, 71);
            this.passwordPanel.TabIndex = 52;
            this.passwordPanel.Visible = false;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTextBox.Location = new System.Drawing.Point(225, 40);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '*';
            this.newPassTextBox.Size = new System.Drawing.Size(168, 22);
            this.newPassTextBox.TabIndex = 49;
            // 
            // currentPassTextBox
            // 
            this.currentPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassTextBox.Location = new System.Drawing.Point(225, 8);
            this.currentPassTextBox.Name = "currentPassTextBox";
            this.currentPassTextBox.PasswordChar = '*';
            this.currentPassTextBox.Size = new System.Drawing.Size(168, 22);
            this.currentPassTextBox.TabIndex = 48;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.ForeColor = System.Drawing.Color.White;
            this.newPassLabel.Location = new System.Drawing.Point(54, 40);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(110, 16);
            this.newPassLabel.TabIndex = 47;
            this.newPassLabel.Text = "New Password";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.currentPasswordLabel.Location = new System.Drawing.Point(56, 8);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(129, 16);
            this.currentPasswordLabel.TabIndex = 46;
            this.currentPasswordLabel.Text = "Current Password";
            // 
            // changePassLabel
            // 
            this.changePassLabel.AutoSize = true;
            this.changePassLabel.BackColor = System.Drawing.Color.White;
            this.changePassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassLabel.ForeColor = System.Drawing.Color.Black;
            this.changePassLabel.Location = new System.Drawing.Point(162, 309);
            this.changePassLabel.Name = "changePassLabel";
            this.changePassLabel.Size = new System.Drawing.Size(179, 13);
            this.changePassLabel.TabIndex = 51;
            this.changePassLabel.Text = "I want to change my password";
            this.changePassLabel.Click += new System.EventHandler(this.changePassLabel_Click);
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.White;
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(239, 97);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(168, 26);
            this.genderPanel.TabIndex = 50;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(93, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 20);
            this.femaleRadioButton.TabIndex = 40;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.maleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(56, 20);
            this.maleRadioButton.TabIndex = 39;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = false;
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
            this.bgComboBox.Location = new System.Drawing.Point(239, 129);
            this.bgComboBox.Name = "bgComboBox";
            this.bgComboBox.Size = new System.Drawing.Size(168, 21);
            this.bgComboBox.TabIndex = 49;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightGray;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logOutButton.Location = new System.Drawing.Point(314, 402);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 38);
            this.logOutButton.TabIndex = 48;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(179, 402);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 38);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Red;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(49, 402);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 38);
            this.saveButton.TabIndex = 46;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(239, 230);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 56);
            this.addressTextBox.TabIndex = 43;
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(239, 194);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 22);
            this.emailTextBox.TabIndex = 42;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(239, 161);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(168, 22);
            this.mobileTextBox.TabIndex = 41;
            this.mobileTextBox.Leave += new System.EventHandler(this.mobileTextBox_Leave);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(239, 63);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.dobDateTimePicker.TabIndex = 37;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(239, 30);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(168, 22);
            this.userNameTextBox.TabIndex = 36;
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(239, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 22);
            this.nameTextBox.TabIndex = 35;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(68, 97);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(59, 16);
            this.genderLabel.TabIndex = 33;
            this.genderLabel.Text = "Gender";
            // 
            // bgLabel
            // 
            this.bgLabel.AutoSize = true;
            this.bgLabel.BackColor = System.Drawing.Color.Transparent;
            this.bgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgLabel.ForeColor = System.Drawing.Color.White;
            this.bgLabel.Location = new System.Drawing.Point(70, 129);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(95, 16);
            this.bgLabel.TabIndex = 32;
            this.bgLabel.Text = "Blood Group";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.ForeColor = System.Drawing.Color.White;
            this.mobileLabel.Location = new System.Drawing.Point(70, 165);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(55, 16);
            this.mobileLabel.TabIndex = 31;
            this.mobileLabel.Text = "Mobile";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(70, 194);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 16);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(70, 230);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 16);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Address";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.White;
            this.dobLabel.Location = new System.Drawing.Point(68, 67);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(92, 16);
            this.dobLabel.TabIndex = 27;
            this.dobLabel.Text = "Date of birth";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(68, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(86, 16);
            this.userNameLabel.TabIndex = 26;
            this.userNameLabel.Text = "User Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(68, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Aiub_Blood_Bank.Properties.Resources.profile_pic;
            this.pictureBox1.Location = new System.Drawing.Point(24, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Admin";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "AdminProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminProfile_FormClosing);
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox currentPassTextBox;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.Label changePassLabel;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.ComboBox bgComboBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label bgLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}