
namespace Aiub_Blood_Bank
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.bgComboBox = new System.Windows.Forms.ComboBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.tcCheckBox = new System.Windows.Forms.CheckBox();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(289, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(374, 43);
            this.aiubLabel.TabIndex = 10;
            this.aiubLabel.Text = "AIUB BLOOD BANK";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(827, 456);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 38);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.passwordPanel);
            this.panel.Controls.Add(this.genderPanel);
            this.panel.Controls.Add(this.bgComboBox);
            this.panel.Controls.Add(this.signUpButton);
            this.panel.Controls.Add(this.tcCheckBox);
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
            this.panel.Location = new System.Drawing.Point(240, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(473, 454);
            this.panel.TabIndex = 24;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.confirmPassTextBox);
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.confirmPassLabel);
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Location = new System.Drawing.Point(59, 294);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(364, 74);
            this.passwordPanel.TabIndex = 49;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTextBox.Location = new System.Drawing.Point(175, 42);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.PasswordChar = '*';
            this.confirmPassTextBox.Size = new System.Drawing.Size(168, 22);
            this.confirmPassTextBox.TabIndex = 48;
            this.confirmPassTextBox.Leave += new System.EventHandler(this.confirmPassTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(175, 10);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(168, 22);
            this.passwordTextBox.TabIndex = 47;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLabel.Location = new System.Drawing.Point(4, 42);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(132, 16);
            this.confirmPassLabel.TabIndex = 46;
            this.confirmPassLabel.Text = "Confirm Password";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(6, 10);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 16);
            this.passwordLabel.TabIndex = 45;
            this.passwordLabel.Text = "Password";
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.White;
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(237, 101);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(168, 31);
            this.genderPanel.TabIndex = 48;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(94, 8);
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
            this.maleRadioButton.Location = new System.Drawing.Point(3, 8);
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
            this.bgComboBox.Location = new System.Drawing.Point(237, 144);
            this.bgComboBox.Name = "bgComboBox";
            this.bgComboBox.Size = new System.Drawing.Size(168, 21);
            this.bgComboBox.TabIndex = 47;
            this.bgComboBox.Text = "Select Blood Group";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Red;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Enabled = false;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.Transparent;
            this.signUpButton.Location = new System.Drawing.Point(178, 400);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(118, 38);
            this.signUpButton.TabIndex = 46;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // tcCheckBox
            // 
            this.tcCheckBox.AutoSize = true;
            this.tcCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCheckBox.Location = new System.Drawing.Point(120, 374);
            this.tcCheckBox.Name = "tcCheckBox";
            this.tcCheckBox.Size = new System.Drawing.Size(233, 20);
            this.tcCheckBox.TabIndex = 45;
            this.tcCheckBox.Text = "I agree all the terms and conditions";
            this.tcCheckBox.UseVisualStyleBackColor = true;
            this.tcCheckBox.CheckedChanged += new System.EventHandler(this.tcCheckBox_CheckedChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(237, 240);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 48);
            this.addressTextBox.TabIndex = 42;
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(237, 204);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 22);
            this.emailTextBox.TabIndex = 41;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(237, 171);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(168, 22);
            this.mobileTextBox.TabIndex = 40;
            this.mobileTextBox.Leave += new System.EventHandler(this.mobileTextBox_Leave);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(237, 73);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.dobDateTimePicker.TabIndex = 36;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(237, 40);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(168, 22);
            this.userNameTextBox.TabIndex = 35;
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(237, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 22);
            this.nameTextBox.TabIndex = 34;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(66, 107);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(59, 16);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "Gender";
            // 
            // bgLabel
            // 
            this.bgLabel.AutoSize = true;
            this.bgLabel.BackColor = System.Drawing.Color.Transparent;
            this.bgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgLabel.Location = new System.Drawing.Point(68, 139);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(95, 16);
            this.bgLabel.TabIndex = 31;
            this.bgLabel.Text = "Blood Group";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.Location = new System.Drawing.Point(68, 175);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(55, 16);
            this.mobileLabel.TabIndex = 30;
            this.mobileLabel.Text = "Mobile";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(68, 204);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 16);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(68, 240);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 16);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "Address";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(66, 77);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(92, 16);
            this.dobLabel.TabIndex = 26;
            this.dobLabel.Text = "Date of birth";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(66, 45);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(86, 16);
            this.userNameLabel.TabIndex = 25;
            this.userNameLabel.Text = "User Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(66, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.Registration_About;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.CheckBox tcCheckBox;
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
        private System.Windows.Forms.ComboBox bgComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}