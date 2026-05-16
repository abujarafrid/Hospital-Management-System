namespace Hospital_Management_System.Forms
{
    partial class Appointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Problem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(62, 228);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(35, 13);
            this.Notes.TabIndex = 6;
            this.Notes.Text = "Notes";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(152, 22);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentId.TabIndex = 7;
            this.txtAppointmentId.TextChanged += new System.EventHandler(this.txtAppointmentId_TextChanged);
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.FormattingEnabled = true;
            this.cmbPatientName.Location = new System.Drawing.Point(152, 62);
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(121, 21);
            this.cmbPatientName.TabIndex = 8;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(152, 102);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoctor.TabIndex = 9;
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(152, 130);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointment.TabIndex = 10;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(152, 156);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(100, 20);
            this.txtProblem.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(152, 189);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 12;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(152, 220);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 20);
            this.txtNotes.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(369, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 352);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(886, 178);
            this.dgvAppointments.TabIndex = 18;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 542);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbPatientName);
            this.Controls.Add(this.txtAppointmentId);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.ComboBox cmbPatientName;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}