using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.LessImportantClasses;

namespace DentalClinicManagement
{
    public partial class PatientWindow : Form
    {
        public PatientWindow()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void Populate()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from PatientTable";
            DataSet dataSet = patient.ShowPatient(query);
            PatientDGV.DataSource = dataSet.Tables[0];
        }
        private void PatientWindow_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void SaveButtonTreatment_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO PatientTable (PatientName, PatientPhone, PatientAddress, PatientBirthdate, PatientGender, PatientAllergies) VALUES ('" + NameText.Text + "','" + PhoneText.Text + "','" + AddressText.Text + "','" + BirthdateText.Value.Date.ToString("yyyy-MM-dd") + "','" + GenderBox.SelectedItem.ToString() + "','" + AllergiesText.Text + "')";
            PatientFunctions patient = new PatientFunctions();
            try
            {
                patient.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameText.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneText.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressText.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderBox.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            AllergiesText.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (NameText.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTable where PatientID=" + key + "";
                    patient.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Deleted");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "Update PatientTable set PatientName='" + NameText.Text + "',PatientPhone='" + PhoneText.Text + "',PatientAddress='" + AddressText.Text + "',PatientBirthdate='" + BirthdateText.Value.Date.ToString("yyyy-MM-dd") + "',PatientGender='" + GenderBox.SelectedItem.ToString() + "', PatientAllergies='" + AllergiesText.Text + "' where PatientID=" + key + "";
                    patient.UpdatePatient(query);
                    MessageBox.Show("Patient Successfully Updated");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void Filter()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from PatientTable where PatientName like '%" + FilterByPatientTextBox.Text + "%'";
            DataSet dataSet = patient.ShowPatient(query);
            PatientDGV.DataSource = dataSet.Tables[0];
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

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoardWindow dashBoard = new DashBoardWindow();
            dashBoard.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AppointmentsWindow appointment = new AppointmentsWindow();
            appointment.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TreatmentWindow treatment = new TreatmentWindow();
            treatment.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            CheckupWindow checkup = new CheckupWindow();
            checkup.Show();
            this.Hide();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserWindow usr = new();
            usr.Show();
            this.Hide();
        }
    }
}
