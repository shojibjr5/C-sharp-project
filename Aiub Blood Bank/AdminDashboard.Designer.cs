
namespace Aiub_Blood_Bank
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.aiubLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.staffListButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(303, 9);
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
            this.profileNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(12, 28);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(112, 19);
            this.profileNameLabel.TabIndex = 1;
            this.profileNameLabel.Text = "Admin(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // staffListButton
            // 
            this.staffListButton.BackColor = System.Drawing.Color.LightGray;
            this.staffListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffListButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffListButton.ForeColor = System.Drawing.Color.White;
            this.staffListButton.Location = new System.Drawing.Point(26, 204);
            this.staffListButton.Name = "staffListButton";
            this.staffListButton.Size = new System.Drawing.Size(190, 60);
            this.staffListButton.TabIndex = 2;
            this.staffListButton.Text = "Staff list";
            this.staffListButton.UseVisualStyleBackColor = false;
            this.staffListButton.Click += new System.EventHandler(this.staffListButton_Click);
            // 
            // donorListButton
            // 
            this.donorListButton.BackColor = System.Drawing.Color.LightGray;
            this.donorListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donorListButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorListButton.ForeColor = System.Drawing.Color.White;
            this.donorListButton.Location = new System.Drawing.Point(252, 204);
            this.donorListButton.Name = "donorListButton";
            this.donorListButton.Size = new System.Drawing.Size(190, 60);
            this.donorListButton.TabIndex = 3;
            this.donorListButton.Text = "Donor List";
            this.donorListButton.UseVisualStyleBackColor = false;
            this.donorListButton.Click += new System.EventHandler(this.donorListButton_Click);
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.LightGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(477, 204);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(190, 60);
            this.patientListButton.TabIndex = 4;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            this.patientListButton.Click += new System.EventHandler(this.patientListButton_Click);
            // 
            // bloodStockButton
            // 
            this.bloodStockButton.BackColor = System.Drawing.Color.LightGray;
            this.bloodStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodStockButton.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockButton.ForeColor = System.Drawing.Color.White;
            this.bloodStockButton.Location = new System.Drawing.Point(706, 204);
            this.bloodStockButton.Name = "bloodStockButton";
            this.bloodStockButton.Size = new System.Drawing.Size(190, 60);
            this.bloodStockButton.TabIndex = 5;
            this.bloodStockButton.Text = "Blood Stock";
            this.bloodStockButton.UseVisualStyleBackColor = false;
            this.bloodStockButton.Click += new System.EventHandler(this.bloodStockButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.bloodStockButton);
            this.Controls.Add(this.patientListButton);
            this.Controls.Add(this.donorListButton);
            this.Controls.Add(this.staffListButton);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.aiubLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Button staffListButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button bloodStockButton;
    }
}