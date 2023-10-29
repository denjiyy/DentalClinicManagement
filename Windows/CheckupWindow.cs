using DentalClinicManagement.Classes;
using DentalClinicManagement.LessImportantClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagement
{
    public partial class CheckupWindow : Form
    {
        private TeethCheckup? checkup;
        private Checkup? checkTeeth;
        private TeethCheckup? teethCheckup;
        private List<Tooth> changes = new List<Tooth>();
        private List<ToothStatus> toothStatuses = new List<ToothStatus>();
        private readonly UndoRedoStack<FlowLayoutPanel> undoRedoStack = new UndoRedoStack<FlowLayoutPanel>();
        private int currentChangeIndex = -1;
        public void SetTeethCheckup(TeethCheckup checkup)
        {
            teethCheckup = checkup;
        }
        public CheckupWindow()
        {
            InitializeComponent();

            checkup = new TeethCheckup();

            LoadTeeth();
        }
        public void LoadTeeth()
        {
            try
            {
                TeethLayoutPanel.Controls.Clear();

                if (checkup != null)
                {
                    foreach (Tooth tooth in checkup.Teeth)
                    {
                        var toothControl = new ToothUserControl(tooth);

                        toothControl.NotesLabel.Text = "Notes: " + tooth.CrownStatus.ToString();
                        toothControl.crownStatusLabel.Text = "Crown: " + tooth.Notes.ToString();
                        toothControl.toothNumberLabel.Text = "Tooth: " + tooth.ToothNumber.ToString();
                        toothControl.statusLabel.Text = "Status: " + tooth.ToothStatus.GetStatus().ToString();
                        toothControl.Tag = tooth;

                        TeethLayoutPanel.Controls.Add(toothControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckupWindow_Load(object sender, EventArgs e)
        {
            LoadTeeth();
        }

        private void CheckupToothButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkup?.CheckAllTeeth();

                foreach (Tooth t in checkup.Teeth)
                {
                    t.TreatPulpitis();
                    t.RemoveDentalTartar();
                    t.PerformRootCanal();
                }

                checkTeeth?.CheckTeeth(checkup.Teeth, toothStatuses);
                LoadTeeth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveTeethButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkup != null)
                {
                    if (checkup.Teeth.Count > 0)
                    {
                        Tooth toothToRemove = checkup.Teeth[checkup.Teeth.Count - 1];
                        checkup.RemoveTooth(toothToRemove);
                        changes.Add(toothToRemove);
                        currentChangeIndex++;

                    }

                    LoadTeeth();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ApplyChanges()
        {
            TeethLayoutPanel.SuspendLayout();

            TeethLayoutPanel.Controls.Clear();

            foreach (Tooth tooth in checkup.Teeth)
            {
                ToothUserControl toothControl = new ToothUserControl(tooth);

                toothControl.NotesLabel.Text = tooth.Notes;

                toothControl.Tag = tooth;

                TeethLayoutPanel.Controls.Add(toothControl);
            }

            if (currentChangeIndex >= 0 && currentChangeIndex < changes.Count)
            {
                Tooth removedTooth = changes[currentChangeIndex];
                foreach (Control control in TeethLayoutPanel.Controls)
                {
                    if (control.Controls.Count > 0 && control.Controls[0] is ToothUserControl toothControl)
                    {
                        if (toothControl.Tooth == removedTooth)
                        {
                            TeethLayoutPanel.Controls.Remove(control);
                            break;
                        }
                    }
                }
            }

            TeethLayoutPanel.ResumeLayout();
        }

        private void MissingTeethButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkup != null)
                {
                    List<int> missingTeeth = checkup.GetMissingTeeth();

                    if (missingTeeth.Count > 0)
                    {
                        MessageBox.Show("The following teeth are missing:\n" + string.Join(", ", missingTeeth));
                    }
                    else
                    {
                        MessageBox.Show("No teeth are missing.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TeethLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AppointmentsWindow patient = new();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TreatmentWindow treatment = new TreatmentWindow();
            treatment.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CheckupWindow checkup = new CheckupWindow();
            checkup.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoardWindow dash = new();
            dash.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Hide();
        }

        private void AddTeeth_Click(object sender, EventArgs e)
        {
            AddTeethWindow teethWindow = new(checkup, this);
            teethWindow.Show();
            this.Hide();

            if (teethWindow.newToothControl != null)
            {
                FlowLayoutPanel newPanel = new FlowLayoutPanel();
                newPanel.Controls.Add(teethWindow.newToothControl);
                TeethLayoutPanel.Controls.Add(newPanel);
            }
            //LoadTeeth();
        }

        private void GetNumber_Click(object sender, EventArgs e)
        {
            DentalComponent component = new();
            component.GetNumber(changes);
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            undoRedoStack.Redo(TeethLayoutPanel);
            try
            {
                if (currentChangeIndex < changes.Count - 1)
                {
                    currentChangeIndex--;
                    ApplyChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TeethLayoutPanel.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public FlowLayoutPanel GetTeethPanel()
        {
            return TeethLayoutPanel;
        }

    }
}
