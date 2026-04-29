using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;
            string password = txtPassword.Text;

            if (userID == "101" && password == "1234")
            {
                MessageBox.Show("Login Successful!");

                //AdminDashboard dashboard = new AdminDashboard();
                //dashboard.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid User ID or Password.");
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
