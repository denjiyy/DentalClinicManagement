using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.Classes;

namespace DentalClinicManagement.Windows
{
    public partial class PerformStatusCheckWindow : Form
    {
        private readonly DentalStatus? _status;
        public PerformStatusCheckWindow()
        {
            InitializeComponent();
            _status = new DentalStatus();
            for (int i = 0; i < 32; i++)
            {
                _status.AddComponent(new DentalComponents { ToothNumber = i, IsHealthy = true });
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FillingButton_Click(object sender, EventArgs e)
        {
            try
            {
                int toothNumber = int.Parse(EnterTeeth.Text);
                if (!int.TryParse(EnterTeeth.Text, out toothNumber))
                {
                    MessageBox.Show("Invalid tooth number.", "Error");
                    return;
                }
                float cost = float.Parse(textBox1.Text);
                if (!float.TryParse(textBox1.Text, out cost))
                {
                    MessageBox.Show("Invalid cost", "Error");
                    return;
                }

                var filling = new FillingProcedure
                {
                    ToothNumber = toothNumber,
                    ProcedureName = "Filling",
                    Cost = cost,
                };

                filling.DoProcedure(_status);

                MessageBox.Show($"Tooth {toothNumber} filled successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppointmentsWindow appointmentsWindow = new();
            appointmentsWindow.Show();
            this.Hide();
        }

        private void ExtractionButton_Click(object sender, EventArgs e)
        {
            try
            {
                int toothNumber = int.Parse(EnterTeeth.Text);
                float cost = float.Parse(textBox1.Text);

                var extraction = new ExtractionProcedure
                {
                    ToothNumber = toothNumber,
                    Cost = cost,
                    ProcedureName = "Extraction"
                };

                extraction?.DoProcedure(_status);

                MessageBox.Show($"Tooth {toothNumber} extracted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allergiesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnterTeeth_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EnterTeeth.Text))
            {
                int toothNumber;
                if (!int.TryParse(EnterTeeth.Text, out toothNumber) || toothNumber < 1 || toothNumber > 32)
                {
                    MessageBox.Show("Invalid tooth number.", "Error");
                    EnterTeeth.Text = string.Empty;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
