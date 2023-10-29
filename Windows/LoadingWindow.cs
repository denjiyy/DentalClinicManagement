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
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();
        }
        int startingPoint = 0;
        private void Loading_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startingPoint += 1;
            Loading.Value = startingPoint;
            if (Loading.Value == 100)
            {
                Loading.Value = 0;
                timer1.Stop();
                LoginWindow login = new LoginWindow();
                login.Show();
                this.Hide();
            }
        }

        private void LoadingWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
