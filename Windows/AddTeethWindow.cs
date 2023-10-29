using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.LessImportantClasses;
using DentalClinicManagement.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalClinicManagement
{
    public partial class AddTeethWindow : Form
    {
        private TeethCheckup? checkup;

        public ToothUserControl? newToothControl;
        private UndoRedoStack<FlowLayoutPanel> undoRedoStack = new UndoRedoStack<FlowLayoutPanel>();
        //private ToothStatus? toothStatuses;
        private CheckupWindow? checkupWindow;

        List<string>? toothStatus = new List<string>() { "Decayed", "Missing", "Filled", "Crown", "Pulpitis", "Tartar", "Other" };

        public AddTeethWindow(TeethCheckup checkup, CheckupWindow checkupWindow)
        {
            InitializeComponent();
            //teethCombobox.Items.Clear();
            teethCombobox.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8",
                                                       "9", "10", "11", "12", "13", "14", "15", "16",
                                                       "17", "18", "19", "20", "21", "22", "23", "24",
                                                       "25", "26", "27", "28", "29", "30", "31", "32" });

            this.checkup = checkup;
            this.checkupWindow = checkupWindow;
            statusCombobox.DataSource = toothStatus;
            statusCombobox.SelectedIndex = 0;
        }

        private void teethCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = statusCombobox.SelectedItem.ToString();
                ToothStatus ts = new ToothStatus(selectedStatus);
                List<string> possibleStats = ts.GetPossibleStatuses();
                comboBox1.DataSource = null;
                comboBox1.DataSource = possibleStats;
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            checkupWindow?.Show();
        }

        private void addTooth_Click(object sender, EventArgs e)
        {
            try
            {
                int toothNumber = int.Parse(teethCombobox?.SelectedItem?.ToString());
                string status = statusCombobox?.SelectedItem?.ToString();
                string notes = notesTextbox.Text.Trim();
                string crownStatus = comboBox1?.SelectedItem?.ToString();
                ToothStatus toothStatus = new(status);
                Tooth newTooth = new(toothNumber, new ToothStatus(status), notes, crownStatus);
                ToothUserControl newToothControl = new(newTooth);
                checkup?.AddTooth(newTooth);

                Control panel = checkupWindow?.GetTeethPanel();
                if (panel == null)
                {
                    throw new Exception("Failed to get the teeth panel.");
                }

                panel.Controls.Add(newToothControl);
                undoRedoStack.Push(newToothControl);

                checkupWindow?.LoadTeeth();
                checkupWindow?.SetTeethCheckup(checkup);

                checkupWindow?.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeethWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
