using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DentalClinicManagement.Classes;
using DentalClinicManagement.Windows;

namespace DentalClinicManagement
{
    public partial class AppointmentsWindow : Form
    {
        private readonly List<AppointmentRecord> records = new List<AppointmentRecord>();
        List<Dentist> dentists = new List<Dentist>();
        //private readonly Dentist? _selectedDentist;
        public DataTable? dentistTable;
        public PerformStatusCheckWindow? _chooseDentistWindow;

        private bool _treatmentsListBoxPopulated = false;
        public AppointmentsWindow()
        {
            InitializeComponent();
            PopulateTreatmentsList();
            PopulateGenderList();

            dentistTable?.Columns.Add("Name", typeof(string));
            dentistTable?.Columns.Add("Gender", typeof(string));
            dentistTable?.Columns.Add("Age", typeof(int));
            dentistTable?.Columns.Add("Specialization", typeof(string));
            DentistDGV.DataSource = dentistTable;
            AppointmentTime.Value = DateTime.Now;
            AppointmentDate.Value = DateTime.Now;

            dentists.Add(new Dentist("Dr. Nikolai Yanev", "Male", 45, "Surgical"));
            dentists.Add(new Dentist("Dr. Yana Radulova", "Female", 35, "Pediatric"));
            dentists.Add(new Dentist("Dr. Lazar Todorov", "Male", 28, "Orthodonty"));
            if (dentistCb != null)
                foreach (Dentist d in dentists)
                    dentistCb.Items.Add(d);

            dentistCb.DisplayMember = "Name";
        }

        private void PopulateGenderList()
        {
            GenderCombobox.DataSource = new List<string> { "Male", "Female" };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = AppointmentDate.Value;

            if (dentistCb.SelectedItem == null)
            {
                MessageBox.Show("Please select a dentist.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(UserName.Text))
            {
                MessageBox.Show("Please enter a patient name.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(AgeTextBox.Text, out int age) == false)
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckForExistingAppointments(selectedDate))
            {
                DialogResult result = MessageBox.Show("There is already an appointment scheduled for this date. Do you want to continue?",
                                                      "Existing Appointment",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            Appointment app = new();
            app.Patient = UserName.Text;
            app.Date = AppointmentDate.Value;
            Dentist dentist = new();
            bool check = false;
            try
            {
                //Appointment app = new();
                //app.Patient = UserName.Text;
                //app.Date = AppointmentDate.Value;
                //Dentist dentist = new();
                dentist.BookAppointment(app);
                check = dentist.BookAppointment(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error booking appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (check)
            {
                AppointmentRecord record = new AppointmentRecord();
                record.PatientName = UserName.Text;
                record.Treatment = ((Treatment)TreatmentListBox?.SelectedItem)?.Type?.ToString() ?? "";
                record.Treatment = (TreatmentListBox.SelectedItem as Treatment)?.Type?.ToString() ?? "";
                record.Date = selectedDate;
                record.Age = age;
                record.Allergies = AllergiesTb.Text;
                record.Time = AppointmentTime.Value;
                record.Gender = GenderCombobox.SelectedItem?.ToString() ?? "";

                if (app.Treatments?.Exists(t => t.Type?.ToLower() == AllergiesTb.Text.ToLower()) == true)
                {
                    MessageBox.Show($"The allergy '{AllergiesTb.Text}' is already a treatment type. Please enter a different allergy.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                records.Add(record);

                AppointmentDGV.DataSource = records;

                UserName.Text = "";
                TreatmentListBox?.ClearSelected();

                if (CheckForExistingAppointments(selectedDate))
                {
                    SaveButton.Text = "Save (Existing Appointment)";
                }
                else
                {
                    SaveButton.Text = "Save";
                }

                if (check == true)
                {
                    Treatment? treatment = (Treatment?)TreatmentListBox?.SelectedItem;
                    Patient? pat = new Patient { Name = UserName.Text };
                    Dentist? dent = new Dentist();
                    dent?.TreatPatient(pat, treatment);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppointmentDGV.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in AppointmentDGV.SelectedRows)
                    {
                        records.RemoveAt(row.Index);
                    }

                    AppointmentDGV.DataSource = null;
                    AppointmentDGV.DataSource = records;

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            UserName.Text = "";
            AgeTextBox.Text = "";
            GenderCombobox.SelectedItem = null;
            AppointmentTime.Value = DateTime.Now;
            AppointmentDate.Value = DateTime.Now;
            dentistCb.SelectedItem = null;
        }
        private void AppointmentWindow_Load(object sender, EventArgs e)
        {
            PopulateTreatmentsList();
        }
        private void PopulateTreatmentsList()
        {
            if (!_treatmentsListBoxPopulated)
            {
                List<Treatment> treatments = new List<Treatment>();
                Appointment appointment = new Appointment();
                appointment.Treatments = treatments;
                appointment.AddTreatments();
                TreatmentListBox.DataSource = treatments;
                TreatmentListBox.DisplayMember = "Type";
                TreatmentListBox.ValueMember = "Type";

                _treatmentsListBoxPopulated = true;
            }
        }

        private void TreatmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreatmentListBox.DisplayMember = "Type";
            TreatmentListBox.SelectionMode = SelectionMode.One;
            string? selectedTreatment = TreatmentListBox.SelectedItem?.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientWindow patient = new PatientWindow();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TreatmentWindow treatment = new TreatmentWindow();
            treatment.Show();
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
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void SaveToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML files (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Dentist selectedDentist = (Dentist)dentistCb.SelectedItem;

                List<Dentist> filteredDentists = dentists.Where(d => d.Name == selectedDentist.Name).ToList();

                Save recordsToSave = new Save();
                recordsToSave.Appointments = records;
                recordsToSave.Dentists = filteredDentists;

                XmlSerializer serializer = new XmlSerializer(typeof(Save));
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    serializer.Serialize(writer, recordsToSave);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CheckupWindow checkup = new CheckupWindow();
            checkup.Show();
            this.Hide();
        }

        public string SetDentistName()
        {
            return Name;
        }


        private void SelectDentist_Click(object sender, EventArgs e)
        {
            PerformStatusCheckWindow dentist = new();
            dentist.Show();
            this.Hide();
        }

        private void dentistCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DentistDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool CheckForExistingAppointments(DateTime date)
        {
            foreach (AppointmentRecord record in records)
            {
                if (record.Date.Date == date.Date)
                {
                    return true;
                }
            }

            return false;
        }

        private void SaveDentist_Click(object sender, EventArgs e)
        {

        }

        private void dentistCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dentistCb.SelectedItem != null)
            {
                DataTable newDentistTable = new DataTable();
                newDentistTable.Columns.Add("Name", typeof(string));
                newDentistTable.Columns.Add("Specialization", typeof(string));
                newDentistTable.Columns.Add("Age", typeof(int));
                newDentistTable.Columns.Add("Gender", typeof(string));

                Dentist selectedDentist = (Dentist)dentistCb.SelectedItem;
                newDentistTable.Rows.Add(selectedDentist.Name, selectedDentist.Specialty, selectedDentist.Age, selectedDentist.Gender);

                DentistDGV.DataSource = newDentistTable;
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files (*.xml)|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Save));
                using (StreamReader reader = new StreamReader(dialog.FileName))
                {
                    Save loadedData = (Save)serializer.Deserialize(reader);

                    records.Clear();
                    records.AddRange(loadedData.Appointments);

                    AppointmentDGV.DataSource = null;
                    AppointmentDGV.DataSource = records;

                    DentistDGV.DataSource = null;
                    DentistDGV.DataSource = loadedData.Dentists;
                }
            }
        }
    }
    public class AppointmentRecord
    {
        public string? PatientName { get; set; }
        public int? Age { get; set; }
        public string? Treatment { get; set; }
        public string? Gender { get; set; }
        public string? Allergies { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
    public class Save
    {
        public List<AppointmentRecord>? Appointments { get; set; }
        public List<Dentist>? Dentists { get; set; }
    }
}
