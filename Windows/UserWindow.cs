using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.LessImportantClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DentalClinicManagement
{
    public partial class UserWindow : Form
    {
        public UserWindow()
        {
            InitializeComponent();
        }
        int key = 0;

        private void SaveButtonUser_Click(object sender, EventArgs e)
        {
            string query = "insert into UsersTable values('" + UserName.Text + "','" + UserPassword.Text + "','" + UserPhone.Text + "')";
            PatientFunctions patient = new PatientFunctions();
            try
            {
                patient.AddPatient(query);
                MessageBox.Show("User Successfully Added");
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void Populate()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from UsersTable";

            DataSet dataSet = patient.ShowPatient(query);
            UserDGV.DataSource = dataSet.Tables[0];
            UserDGV.Refresh();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the User");
            }
            else
            {
                try
                {
                    string query = "Update UsersTable set UsersName='" + UserName.Text + "',UsersPassword='" + UserPassword.Text + "',UsersPhone='" + UserPhone.Text + "' where UsersID='" + key + "'";
                    patient.UpdatePatient(query);
                    MessageBox.Show("User Successfully Updated");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the User");
            }
            else
            {
                try
                {
                    string query = "Delete from UsersTable where UsersID=" + key + "";
                    patient.DeletePatient(query);
                    MessageBox.Show("User Successfully Deleted");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserName.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UserPassword.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            UserPhone.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (UserName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            Populate();
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            Populate();
        }
        void Filter()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from UsersTable where UsersName like '%" + FilterByPatientTextBox.Text + "%'";
            DataSet dataSet = patient.ShowPatient(query);
            UserDGV.DataSource = dataSet.Tables[0];
        }
        private void FilterByPatientTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void UserPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientWindow pat = new();
            pat.Show();
            this.Hide();
        }
    }
}
