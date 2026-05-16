using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Forms
{
    public partial class Patients : Form
    {
        private int patientId = 1;
        DataTable patientTable = new DataTable();
        DataAccess dataAccess;

        public Patients()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            //dgvPatients.DataSource = null;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name");
                return;
            }

            string patientId = txtPatientId.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = cmbGender.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string bloodGroup = cmbBloodGroup.Text.Trim();

            string password = "123456";
            string userRole = "Patient";

            string userName = firstName + lastName;

            var sql = $"Insert into Users (FirstName, LastName,  Age, Gender, Phone, Address, BloodGroup,Password,UserName, Role) values('{firstName}','{lastName}','{age}','{gender}','{phone} ',' {address}',' {bloodGroup}',' {password}','{userName}','{userRole}'); ";

            try
            {
                int rowCount = dataAccess.ExecuteNonQuery(sql);
                if (rowCount > 0)
                {
                    MessageBox.Show($"Welcome, {firstName} {lastName}. Your Registration Complited.");
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

            MessageBox.Show("Patient added successfully");
            ClearFields();








        }

            private void ClearFields()
        {
            txtPatientId.Clear();
            txtFirstName.Clear();
            txtAge.Text= "";
            cmbGender.SelectedIndex = 0;
            txtPhone.Clear();
            txtAddress.Clear();
            cmbBloodGroup.SelectedIndex =0 ;
        }
            
        

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

                txtPatientId.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                cmbGender.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
                cmbBloodGroup.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            var sql = "select * from users order by id desc";

            var rr = dataAccess.Execute(sql);
            var rows = rr.Rows;

            var employeeList = rr.Rows.Cast<DataRow>()
                .Select(row => new 
                {
                    PatientId = Convert.ToInt32(row["Id"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Role = row["Role"].ToString(),
                    Age = row["Age"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Gender = row["Gender"].ToString(),
                    BloodG = row["BloodGroup"].ToString(),
                })
                .ToList();


            dgvPatients.Columns.Clear();

            //dgvPatients.Columns.Add("PatientId", "Patient ID");
            //dgvPatients.Columns.Add("FirstName", "First Name");
            //dgvPatients.Columns.Add("Age", "Age");
            //dgvPatients.Columns.Add("Gender", "Gender");
            //dgvPatients.Columns.Add("Phone", "Phone");
            //dgvPatients.Columns.Add("Address", "Address");
            //dgvPatients.Columns.Add("BloodGroup", "Blood Group");
            //dgvPatients.Columns.Add("CreatedAt", "Created At");

            //dgvPatients.DataSource = patientTable;
            dgvPatients.DataSource = employeeList;

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbBloodGroup.Items.Add("A+");
            cmbBloodGroup.Items.Add("A-");
            cmbBloodGroup.Items.Add("B+");
            cmbBloodGroup.Items.Add("B-");
            cmbBloodGroup.Items.Add("O+");
            cmbBloodGroup.Items.Add("O-");
            cmbBloodGroup.Items.Add("AB+");
            cmbBloodGroup.Items.Add("AB-");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient first");
                return;
            }

            DataGridViewRow row = dgvPatients.CurrentRow;

            row.Cells[1].Value = txtFirstName.Text;
            row.Cells[2].Value = txtAge.Text;
            row.Cells[3].Value = cmbGender.Text;
            row.Cells[4].Value = txtPhone.Text;
            row.Cells[5].Value = txtAddress.Text;
            row.Cells[6].Value = cmbBloodGroup.Text;

            MessageBox.Show("Patient updated successfully");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient first");
                return;
            }

            dgvPatients.Rows.Remove(dgvPatients.CurrentRow);

            MessageBox.Show("Patient deleted successfully");
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtPhone.Clear();
            txtAddress.Clear();
            cmbBloodGroup.Text = "";
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
        }

        private void txtBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

