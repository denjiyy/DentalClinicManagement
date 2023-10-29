using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DentalClinicManagement.Classes
{
    [Serializable]
    public abstract class Person : ISerializable
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public Person() {}
        public Person(string? name, string? gender, int? age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
        public abstract void TreatPatient(Patient patient, Treatment treatment);

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("Gender", Gender, typeof(string));
            info.AddValue("Age", Age, typeof(int));
        }

        protected Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string?)info.GetValue("Name", typeof(string));
            Gender = (string?)info.GetValue("Gender", typeof(string));
            Age = (int?)info.GetValue("Age", typeof(int));
        }
    }

    [Serializable]
    public class Patient : Person
    {
        public List<Appointment>? Appointments { get; set; }
        public string? Allergies { get; set; }
        public Patient() { }
        public Patient(string? name, string? gender, int? age) : base(name, gender, age)
        {
            Appointments = new List<Appointment>();
        }
        
        public void AddTreatment(Treatment treatment)
        {
            if (Appointments == null)
            {
                Appointments = new List<Appointment>();
            }

            bool alreadyReceived = Appointments
                 .SelectMany(x => x.Treatments ?? Enumerable.Empty<Treatment>())
                 .Any(y => y.Type == treatment.Type);

            if (alreadyReceived)
            {
                MessageBox.Show($"Patient {Name} has already received {treatment.Type} treatment.");
                return;
            }

            MessageBox.Show($"Adding {treatment?.Type} treatment to patient {Name}'s records.");
        }

        public override void TreatPatient(Patient patient, Treatment treatment)
        {
            try
            {
                TreatPatient(patient, treatment);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    [Serializable]
    public class Dentist : Person
    {
        public List<Appointment>? Appointments { get; set; }
        public string? Specialty { get; set; }
        public Dentist() { }
        public Dentist(string? name, string? gender, int? age, string? specialty) : base(name!, gender!, age!)
        {
            Appointments = new List<Appointment>();
            Specialty = specialty;
        }

        public bool BookAppointment(Appointment appointment)
        {
            if (appointment.Date < DateTime.Now)
            {
                MessageBox.Show("Cannot book an appointment in the past, or on the same day.");
                return false;
            }
            bool conflictExists = Appointments?.Any(a =>
                 a.Date == appointment.Date ||
                 (a.Date < appointment.Date && a.Date.AddHours(1) > appointment.Date) ||
                 (a.Date > appointment.Date && appointment.Date.AddHours(1) > a.Date)
            ) ?? false;

            if (conflictExists)
            {
                MessageBox.Show("Appointment conflicts with an existing appointment.");
                return false;
            }

            MessageBox.Show($"Booking appointment for patient {Name} on {appointment.Date}");
            Appointments?.Add(appointment);
            return true;
        }

        public override void TreatPatient(Patient patient, Treatment treatment)
        {
            MessageBox.Show($"Performing {treatment?.Type} treatment on patient {patient?.Name}");
            patient?.AddTreatment(treatment);
            MessageBox.Show("Updating patient records...");
        }
    }
    [Serializable]
    public class Appointment
    {
        public Appointment() { }
        public string? Patient { get; set; }
        public Dentist? Dentist { get; set; }
        public DateTime Date { get; set; }
        public List<Treatment>? Treatments { get; set; }
        public Appointment(DateTime? date)
        {
            Date = date ?? DateTime.MinValue;
            Treatments = new List<Treatment>();
            AddTreatments();
        }

        public void AddTreatments()
        {
            Treatments?.Add(new Treatment { Type = "Cleaning Tartar" });
            Treatments?.Add(new Treatment { Type = "Teeth Whitening" });
            Treatments?.Add(new Treatment { Type = "Filling Cavities" });
            Treatments?.Add(new Treatment { Type = "Root Canal Therapy" });
            Treatments?.Add(new Treatment { Type = "Tooth Removal" });
            Treatments?.Add(new Treatment { Type = "Braces" });
            Treatments?.Add(new Treatment { Type = "Dental Implants" });
            Treatments?.Add(new Treatment { Type = "Removal of Wisdom Teeth" });
            Treatments?.Add(new Treatment { Type = "Treatment of Crowns and Bridges" });
        }
    }

    [Serializable]
    public class Treatment
    {
        public Treatment() { }
        public string? Type { get; set; }
    }
}
