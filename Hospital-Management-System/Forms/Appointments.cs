using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Forms
{
    public partial class Appointments : Form
    {
        private int patientId = 1;
        DataTable patientTable = new DataTable();
        DataAccess dataAccess;
        public Appointments()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAppointmentId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter patient id");
                return;
            }
            string appointmentId = txtAppointmentId.Text.Trim();
            string patientName = cmbPatientName.Text.Trim();
            string doctor = cmbDoctor.Text.Trim();
            string date = dtpAppointment.Text.Trim();
            string problem = txtProblem.Text.Trim();
            string status = cmbStatus.Text.Trim();
            string note = txtNotes.Text.Trim();

            string sql = $"Insert into Appointments (Patient, Doctor, Date, Problem, Status, Note) values('{patientName}','{doctor}','{date}','{problem}','{status}','{note}'); ";
            try
            {
                int rowCount = dataAccess.ExecuteNonQuery(sql);
                if (rowCount > 0)
                {
                    MessageBox.Show($"Welcome, {patientName}! Your Appointment {appointmentId} is Completed.");
                }
                else
                {
                    MessageBox.Show("Registration Failed!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            
           
        }

        private void txtAppointmentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
