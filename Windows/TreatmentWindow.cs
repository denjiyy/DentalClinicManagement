using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.LessImportantClasses;

namespace DentalClinicManagement
{
    public partial class TreatmentWindow : Form
    {
        public TreatmentWindow()
        {
            InitializeComponent();
        }

        private void SaveButtonTreatment_Click(object sender, EventArgs e)
        {
            string treatmentName = TreatmentText.Text;
            string treatmentCost = CostText.Text;
            string treatmentDescription = TreatmentDescText.Text;

            if (string.IsNullOrWhiteSpace(treatmentName) || string.IsNullOrWhiteSpace(treatmentCost) || string.IsNullOrWhiteSpace(treatmentDescription))
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }

            string query = "INSERT INTO TreatmentTable (TreatmentName, TreatmentCost, TreatmentDescription) " +
               $"VALUES ('{treatmentName}', '{treatmentCost}', '{treatmentDescription}')";

            PatientFunctions patient = new PatientFunctions();

            try
            {
                patient.AddPatient(query);
                MessageBox.Show("Treatment Successfully Added");
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
            string query = "select * from TreatmentTable";
            DataSet dataSet = patient.ShowPatient(query);
            TreatmentDGV.DataSource = dataSet.Tables[0];
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            Populate();
        }
        int key = 0;
        private void Delete_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTable where TreatmentID=" + key + "";
                    patient.DeletePatient(query);
                    MessageBox.Show("Treatment Successfully Deleted");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Update TreatmentTable set TreatmentName='" + TreatmentText.Text + "',TreatmentCost='" + CostText.Text + "',TreatmentDescription='" + TreatmentDescText.Text + "' where TreatmentID='" + key + "'";
                    patient.UpdatePatient(query);
                    MessageBox.Show("Treatment Successfully Updated");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatmentText.Text = TreatmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostText.Text = TreatmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatmentDescText.Text = TreatmentDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (TreatmentText.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreatmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Filter()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from TreatmentTable where TreatmentName like '%" + FilterByPatientTextBox.Text + "%'";
            DataSet dataSet = patient.ShowPatient(query);
            TreatmentDGV.DataSource = dataSet.Tables[0];
        }
        void FilterByPatientTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientWindow patient = new PatientWindow();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AppointmentsWindow appointment = new AppointmentsWindow();
            appointment.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoardWindow dashBoard = new DashBoardWindow();
            dashBoard.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void TreatmentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TreatmentDescText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TreatmentWindow_Load(object sender, EventArgs e)
        {
            Populate();
            Filter();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CheckupWindow treatment = new();
            treatment.Show();
            this.Hide();
        }
    }
}

