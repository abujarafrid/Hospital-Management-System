using Hospital_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Resolvers;

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        DataAccess dataAccess;
        private object dt;

        public Login()
        {
            InitializeComponent();
            dataAccess = new DataAccess();  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string userNameInput = txtUserID.Text.Trim();
            //string passwordInput = txtPassword.Text.Trim();

            string userNameInput = "afrid";
            string passwordInput = "123456";

            var sql = "select Id,UserName,Role from Users where UserName='" + userNameInput + "' and Password ='" + passwordInput + "'";

            var datatable = dataAccess.Execute(sql);
            var rows = datatable.Rows;

            string userName = rows[0]["UserName"].ToString();
            //string password = rows[0]["Password"].ToString();
            string userRole = rows[0]["Role"].ToString();
            

 
           
            if (rows.Count > 0 && userRole == "admin")
            {
                MessageBox.Show("Welcome Admin!");

                this.Hide();
                Admin ad = new Admin();
                ad.Show();

                //AdminDashboard dashboard = new AdminDashboard();
                //dashboard.Show();
                //this.Hide();

            }
            if (rows.Count > 0 && userRole == "doctor")
            {
                MessageBox.Show("Welcome Doctor!");

            }
            if (rows.Count > 0 && userRole == "patient")
            {
                MessageBox.Show("Welcome patient!");

            }
            else
            {
                MessageBox.Show("Invalid User ID or Password.");
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
