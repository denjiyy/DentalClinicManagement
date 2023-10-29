using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DentalClinicManagement.LessImportantClasses;

namespace DentalClinicManagement
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void AdminLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLoginWindow login = new AdminLoginWindow();
            login.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(UserPassword.Text))
            {
                MessageBox.Show("Please enter both a Username and a Password");
                return;
            }
            SqlConnection conn = connection.GetConnection();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from UsersTable where UsersName='" + UserName.Text + "' and UsersPassword='" + UserPassword.Text + "'", conn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            if (data.Rows[0][0].ToString() == "1")
            {
                AppointmentsWindow appointment = new AppointmentsWindow();
                appointment.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
                UserName.Text = "";
                UserPassword.Text = "";
            }
            conn.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}