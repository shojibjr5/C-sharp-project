
namespace Aiub_Blood_Bank
{
    partial class AdminBloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBloodStock));
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.aiubLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.patientListButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.bloodStockButton = new System.Windows.Forms.Button();
            this.donorListButton = new System.Windows.Forms.Button();
            this.staffListButton = new System.Windows.Forms.Button();
            this.abnCount = new System.Windows.Forms.Label();
            this.abpCount = new System.Windows.Forms.Label();
            this.onCount = new System.Windows.Forms.Label();
            this.opCount = new System.Windows.Forms.Label();
            this.bnCount = new System.Windows.Forms.Label();
            this.bpCount = new System.Windows.Forms.Label();
            this.anCount = new System.Windows.Forms.Label();
            this.apcount = new System.Windows.Forms.Label();
            this.abNLabel = new System.Windows.Forms.Label();
            this.abPLabel = new System.Windows.Forms.Label();
            this.oNLabel = new System.Windows.Forms.Label();
            this.oPLabel = new System.Windows.Forms.Label();
            this.bNLabel = new System.Windows.Forms.Label();
            this.bPLabel = new System.Windows.Forms.Label();
            this.aNLabel = new System.Windows.Forms.Label();
            this.aPLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
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
            this.profileNameLabel.Size = new System.Drawing.Size(117, 20);
            this.profileNameLabel.TabIndex = 44;
            this.profileNameLabel.Text = "Admin(Name)";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // aiubLabel
            // 
            this.aiubLabel.AutoSize = true;
            this.aiubLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiubLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubLabel.Location = new System.Drawing.Point(370, 9);
            this.aiubLabel.Name = "aiubLabel";
            this.aiubLabel.Size = new System.Drawing.Size(235, 43);
            this.aiubLabel.TabIndex = 43;
            this.aiubLabel.Text = "Blood Stock";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.patientListButton);
            this.panel.Controls.Add(this.homeButton);
            this.panel.Controls.Add(this.bloodStockButton);
            this.panel.Controls.Add(this.donorListButton);
            this.panel.Controls.Add(this.staffListButton);
            this.panel.Location = new System.Drawing.Point(12, 123);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(177, 235);
            this.panel.TabIndex = 51;
            // 
            // patientListButton
            // 
            this.patientListButton.BackColor = System.Drawing.Color.LightGray;
            this.patientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.ForeColor = System.Drawing.Color.White;
            this.patientListButton.Location = new System.Drawing.Point(4, 141);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(168, 40);
            this.patientListButton.TabIndex = 51;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = false;
            this.patientListButton.Click += new System.EventHandler(this.patientListButton_Click);
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
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // bloodStockButton
            // 
            this.bloodStockButton.BackColor = System.Drawing.Color.DarkGray;
            this.bloodStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloodStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockButton.ForeColor = System.Drawing.Color.White;
            this.bloodStockButton.Location = new System.Drawing.Point(4, 187);
            this.bloodStockButton.Name = "bloodStockButton";
            this.bloodStockButton.Size = new System.Drawing.Size(168, 40);
            this.bloodStockButton.TabIndex = 2;
            this.bloodStockButton.Text = "Blood Stock";
            this.bloodStockButton.UseVisualStyleBackColor = false;
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
            // staffListButton
            // 
            this.staffListButton.BackColor = System.Drawing.Color.LightGray;
            this.staffListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffListButton.ForeColor = System.Drawing.Color.White;
            this.staffListButton.Location = new System.Drawing.Point(4, 49);
            this.staffListButton.Name = "staffListButton";
            this.staffListButton.Size = new System.Drawing.Size(168, 40);
            this.staffListButton.TabIndex = 0;
            this.staffListButton.Text = "Staff List";
            this.staffListButton.UseVisualStyleBackColor = false;
            this.staffListButton.Click += new System.EventHandler(this.staffListButton_Click);
            // 
            // abnCount
            // 
            this.abnCount.AutoSize = true;
            this.abnCount.BackColor = System.Drawing.Color.White;
            this.abnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abnCount.Location = new System.Drawing.Point(777, 288);
            this.abnCount.Name = "abnCount";
            this.abnCount.Size = new System.Drawing.Size(47, 25);
            this.abnCount.TabIndex = 86;
            this.abnCount.Text = "AB-";
            // 
            // abpCount
            // 
            this.abpCount.AutoSize = true;
            this.abpCount.BackColor = System.Drawing.Color.White;
            this.abpCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abpCount.Location = new System.Drawing.Point(656, 288);
            this.abpCount.Name = "abpCount";
            this.abpCount.Size = new System.Drawing.Size(52, 25);
            this.abpCount.TabIndex = 85;
            this.abpCount.Text = "AB+";
            // 
            // onCount
            // 
            this.onCount.AutoSize = true;
            this.onCount.BackColor = System.Drawing.Color.White;
            this.onCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onCount.Location = new System.Drawing.Point(468, 288);
            this.onCount.Name = "onCount";
            this.onCount.Size = new System.Drawing.Size(35, 25);
            this.onCount.TabIndex = 84;
            this.onCount.Text = "O-";
            // 
            // opCount
            // 
            this.opCount.AutoSize = true;
            this.opCount.BackColor = System.Drawing.Color.White;
            this.opCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opCount.Location = new System.Drawing.Point(314, 288);
            this.opCount.Name = "opCount";
            this.opCount.Size = new System.Drawing.Size(40, 25);
            this.opCount.TabIndex = 83;
            this.opCount.Text = "O+";
            // 
            // bnCount
            // 
            this.bnCount.AutoSize = true;
            this.bnCount.BackColor = System.Drawing.Color.White;
            this.bnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCount.Location = new System.Drawing.Point(766, 126);
            this.bnCount.Name = "bnCount";
            this.bnCount.Size = new System.Drawing.Size(33, 25);
            this.bnCount.TabIndex = 82;
            this.bnCount.Text = "B-";
            // 
            // bpCount
            // 
            this.bpCount.AutoSize = true;
            this.bpCount.BackColor = System.Drawing.Color.White;
            this.bpCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpCount.Location = new System.Drawing.Point(642, 126);
            this.bpCount.Name = "bpCount";
            this.bpCount.Size = new System.Drawing.Size(38, 25);
            this.bpCount.TabIndex = 81;
            this.bpCount.Text = "B+";
            // 
            // anCount
            // 
            this.anCount.AutoSize = true;
            this.anCount.BackColor = System.Drawing.Color.White;
            this.anCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anCount.Location = new System.Drawing.Point(467, 126);
            this.anCount.Name = "anCount";
            this.anCount.Size = new System.Drawing.Size(33, 25);
            this.anCount.TabIndex = 80;
            this.anCount.Text = "A-";
            // 
            // apcount
            // 
            this.apcount.AutoSize = true;
            this.apcount.BackColor = System.Drawing.Color.White;
            this.apcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apcount.Location = new System.Drawing.Point(314, 126);
            this.apcount.Name = "apcount";
            this.apcount.Size = new System.Drawing.Size(38, 25);
            this.apcount.TabIndex = 79;
            this.apcount.Text = "A+";
            // 
            // abNLabel
            // 
            this.abNLabel.AutoSize = true;
            this.abNLabel.BackColor = System.Drawing.Color.White;
            this.abNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abNLabel.Location = new System.Drawing.Point(727, 288);
            this.abNLabel.Name = "abNLabel";
            this.abNLabel.Size = new System.Drawing.Size(47, 25);
            this.abNLabel.TabIndex = 78;
            this.abNLabel.Text = "AB-";
            // 
            // abPLabel
            // 
            this.abPLabel.AutoSize = true;
            this.abPLabel.BackColor = System.Drawing.Color.White;
            this.abPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abPLabel.Location = new System.Drawing.Point(598, 288);
            this.abPLabel.Name = "abPLabel";
            this.abPLabel.Size = new System.Drawing.Size(52, 25);
            this.abPLabel.TabIndex = 77;
            this.abPLabel.Text = "AB+";
            // 
            // oNLabel
            // 
            this.oNLabel.AutoSize = true;
            this.oNLabel.BackColor = System.Drawing.Color.White;
            this.oNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oNLabel.Location = new System.Drawing.Point(427, 288);
            this.oNLabel.Name = "oNLabel";
            this.oNLabel.Size = new System.Drawing.Size(35, 25);
            this.oNLabel.TabIndex = 76;
            this.oNLabel.Text = "O-";
            // 
            // oPLabel
            // 
            this.oPLabel.AutoSize = true;
            this.oPLabel.BackColor = System.Drawing.Color.White;
            this.oPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPLabel.Location = new System.Drawing.Point(268, 288);
            this.oPLabel.Name = "oPLabel";
            this.oPLabel.Size = new System.Drawing.Size(40, 25);
            this.oPLabel.TabIndex = 75;
            this.oPLabel.Text = "O+";
            // 
            // bNLabel
            // 
            this.bNLabel.AutoSize = true;
            this.bNLabel.BackColor = System.Drawing.Color.White;
            this.bNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNLabel.Location = new System.Drawing.Point(727, 126);
            this.bNLabel.Name = "bNLabel";
            this.bNLabel.Size = new System.Drawing.Size(33, 25);
            this.bNLabel.TabIndex = 74;
            this.bNLabel.Text = "B-";
            // 
            // bPLabel
            // 
            this.bPLabel.AutoSize = true;
            this.bPLabel.BackColor = System.Drawing.Color.White;
            this.bPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPLabel.Location = new System.Drawing.Point(598, 126);
            this.bPLabel.Name = "bPLabel";
            this.bPLabel.Size = new System.Drawing.Size(38, 25);
            this.bPLabel.TabIndex = 73;
            this.bPLabel.Text = "B+";
            // 
            // aNLabel
            // 
            this.aNLabel.AutoSize = true;
            this.aNLabel.BackColor = System.Drawing.Color.White;
            this.aNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNLabel.Location = new System.Drawing.Point(427, 126);
            this.aNLabel.Name = "aNLabel";
            this.aNLabel.Size = new System.Drawing.Size(33, 25);
            this.aNLabel.TabIndex = 72;
            this.aNLabel.Text = "A-";
            // 
            // aPLabel
            // 
            this.aPLabel.AutoSize = true;
            this.aPLabel.BackColor = System.Drawing.Color.White;
            this.aPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPLabel.Location = new System.Drawing.Point(270, 126);
            this.aPLabel.Name = "aPLabel";
            this.aPLabel.Size = new System.Drawing.Size(38, 25);
            this.aPLabel.TabIndex = 71;
            this.aPLabel.Text = "A+";
            // 
            // AdminBloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aiub_Blood_Bank.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.abnCount);
            this.Controls.Add(this.abpCount);
            this.Controls.Add(this.onCount);
            this.Controls.Add(this.opCount);
            this.Controls.Add(this.bnCount);
            this.Controls.Add(this.bpCount);
            this.Controls.Add(this.anCount);
            this.Controls.Add(this.apcount);
            this.Controls.Add(this.abNLabel);
            this.Controls.Add(this.abPLabel);
            this.Controls.Add(this.oNLabel);
            this.Controls.Add(this.oPLabel);
            this.Controls.Add(this.bNLabel);
            this.Controls.Add(this.bPLabel);
            this.Controls.Add(this.aNLabel);
            this.Controls.Add(this.aPLabel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.aiubLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 560);
            this.Name = "AdminBloodStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aiub Blood Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminBloodStock_FormClosing);
            this.Load += new System.EventHandler(this.AdminBloodStock_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label aiubLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button bloodStockButton;
        private System.Windows.Forms.Button donorListButton;
        private System.Windows.Forms.Button staffListButton;
        private System.Windows.Forms.Label abnCount;
        private System.Windows.Forms.Label abpCount;
        private System.Windows.Forms.Label onCount;
        private System.Windows.Forms.Label opCount;
        private System.Windows.Forms.Label bnCount;
        private System.Windows.Forms.Label bpCount;
        private System.Windows.Forms.Label anCount;
        private System.Windows.Forms.Label apcount;
        private System.Windows.Forms.Label abNLabel;
        private System.Windows.Forms.Label abPLabel;
        private System.Windows.Forms.Label oNLabel;
        private System.Windows.Forms.Label oPLabel;
        private System.Windows.Forms.Label bNLabel;
        private System.Windows.Forms.Label bPLabel;
        private System.Windows.Forms.Label aNLabel;
        private System.Windows.Forms.Label aPLabel;
    }
}