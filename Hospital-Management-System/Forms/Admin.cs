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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
             

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Patient form open");
            //this.Hide();
            Patients ps = new Patients();
            ps.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Appointments form open");
             this.Hide();
             Appointments ap = new Appointments();
            ap.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Billing form open");
            this.Hide();
            Billing bp = new Billing();
            bp.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management form open");
            this.Hide();
            UserManagement um = new UserManagement();
            um.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
