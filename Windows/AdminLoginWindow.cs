using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagement
{
    public partial class AdminLoginWindow : Form
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
        }

        private void CancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (AdminPassword.Text == "")
            {
                MessageBox.Show("Enter Administrator Password");
            }
            else if (AdminPassword.Text == "DentistPassword")
            {
                UserWindow user = new UserWindow();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
