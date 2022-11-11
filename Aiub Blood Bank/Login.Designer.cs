
namespace Aiub_Blood_Bank
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.aiubPictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aiubPictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(150, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(647, 75);
            this.aiubLabel.TabIndex = 2;
            this.aiubLabel.Text = "AIUB BLOOD BANK";
            // 
            // aiubPictureBox
            // 
            this.aiubPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aiubPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiubPictureBox.Image = global::Aiub_Blood_Bank.Properties.Resources.AIUB;
            this.aiubPictureBox.Location = new System.Drawing.Point(408, 76);
            this.aiubPictureBox.Name = "aiubPictureBox";
            this.aiubPictureBox.Size = new System.Drawing.Size(115, 112);
            this.aiubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiubPictureBox.TabIndex = 3;
            this.aiubPictureBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.signInButton);
            this.panel.Controls.Add(this.passwordTextBox);
            this.panel.Controls.Add(this.userNameTextBox);
            this.panel.Controls.Add(this.passwordLabel);
            this.panel.Controls.Add(this.userNameLabel);
            this.panel.Location = new System.Drawing.Point(289, 194);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(365, 303);
            this.panel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signUpLabel);
            this.panel1.Controls.Add(this.regLabel);
            this.panel1.Location = new System.Drawing.Point(80, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 40);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(174, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "now!";
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(129, 14);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(50, 13);
            this.signUpLabel.TabIndex = 14;
            this.signUpLabel.Text = "Sign up";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Location = new System.Drawing.Point(6, 14);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(127, 13);
            this.regLabel.TabIndex = 13;
            this.regLabel.Text = "Don\'t have any account?";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Red;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.Transparent;
            this.signInButton.Location = new System.Drawing.Point(149, 166);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(85, 33);
            this.signInButton.TabIndex = 10;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(158, 117);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(161, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(158, 73);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(161, 22);
            this.userNameTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(45, 117);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 20);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(45, 73);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 20);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.aiubPictureBox);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.aiubPictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.PictureBox aiubPictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

