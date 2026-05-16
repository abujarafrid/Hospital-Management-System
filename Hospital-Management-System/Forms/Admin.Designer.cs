namespace Hospital_Management_System.Forms
{
    partial class Admin
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
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(20, 18);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(165, 46);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAppointments.Location = new System.Drawing.Point(20, 89);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(165, 45);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBilling.Location = new System.Drawing.Point(20, 172);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(165, 40);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserManagement.Location = new System.Drawing.Point(20, 237);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(165, 41);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(20, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 38);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome,  Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hospital Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.btnAppointments);
            this.panel1.Controls.Add(this.btnBilling);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 404);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 119);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1030, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}