using System;
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

namespace DentalClinicManagement
{
    public partial class DashBoardWindow : Form
    {
        public DashBoardWindow()
        {
            InitializeComponent();
        }

        private void AppointmentProgressCircleBar_ValueChanged(object sender, EventArgs e)
        {

        }
        Connection conn = new Connection();
        private void DashBoardWindow_Load(object sender, EventArgs e)
        {
            AppointmentCircle.Value = 100;
            UserCircle.Value = 100;
            PatientCircle.Value = 100;
            SqlConnection connection = conn.GetConnection();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from PatientTable", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Pending.Text = dataTable.Rows[0][0].ToString();
            SqlDataAdapter adapter2 = new SqlDataAdapter("select count(*) from PatientTable", connection);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            Patient.Text = dataTable2.Rows[0][0].ToString();
            SqlDataAdapter adapter3 = new SqlDataAdapter("select count(*) from UsersTable", connection);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);
            User.Text = dataTable3.Rows[0][0].ToString();
            connection.Close();
        }

        private void NextAppointmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLabelDashBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppointmentsWindow appointment = new AppointmentsWindow();
            appointment.Show();
            this.Hide();
        }

        private void PatientCircle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentCircle_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
