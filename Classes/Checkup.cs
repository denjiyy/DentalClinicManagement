using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalClinicManagement.Classes
{
    //[Serializable]
    public class Checkup
    {
        //[XmlElement("Tooth")]
        public List<Tooth>? TeethChecked { get; set; }

        public void CheckTeeth(List<Tooth> teeth, List<ToothStatus> toothStatuses)
        {
            for (int i = 0; i < teeth.Count; i++)
            {
                Tooth tooth = teeth[i];
                ToothStatus toothStatus = toothStatuses[i];

                if (toothStatus.GetStatus() == "Decayed")
                {
                    toothStatus.SetStatus("Healthy");
                }
                else if (toothStatus.GetStatus() == "Missing")
                {
                    MessageBox.Show($"Tooth {tooth.ToothNumber} is missing. We recommend a replacement.");
                }
                else if (toothStatus.GetStatus() == "Crown")
                {
                    if (tooth.Notes == "Loose")
                    {
                        MessageBox.Show($"The crown on tooth {tooth.ToothNumber} is loose. We recommend a replacement.");
                    }
                    else if (tooth.Notes == "Damaged")
                    {
                        MessageBox.Show($"The crown on tooth {tooth.ToothNumber} is damaged. We recommend a repair or replacement.");
                    }
                }
            }
        }
    }
    //[Serializable]
    public class TeethCheckup : Checkup
    {
        //[XmlElement("Tooth")]
        public List<Tooth> Teeth { get; set; }

        public TeethCheckup()
        {
            Teeth = new List<Tooth>();
        }

        public void AddTooth(Tooth tooth)
        {
            Teeth.Add(tooth);
        }

        public void RemoveTooth(Tooth tooth)
        {
            Teeth.Remove(tooth);
        }

        public void CheckAllTeeth()
        {
            foreach (Tooth tooth in Teeth)
            {
                if (tooth.ToothStatus.GetStatus() == "Decayed")
                {
                    tooth.FillCavity();
                }
                else if (tooth.ToothStatus.GetStatus() == "Missing")
                {
                    // Не прави нищо...
                }
                else if (tooth.ToothStatus.GetStatus() == "Crown")
                {
                    tooth.PerformRootCanal();
                }
            }
        }

        public List<int> GetMissingTeeth()
        {
            List<int> missingTeeth = new List<int>();

            foreach (Tooth tooth in Teeth)
            {
                if (tooth.ToothStatus.GetStatus() == "Missing")
                {
                    missingTeeth.Add(tooth.ToothNumber);
                }
            }

            return missingTeeth;
        }
    }

    //[Serializable]
    public class Tooth
    {
        public int ToothNumber { get; set; }
        public ToothStatus ToothStatus { get; set; }
        public string CrownStatus { get; set; }
        public string Notes { get; set; }
        public void FillCavity()
        {
            if (ToothStatus.GetStatus() == "Decayed")
            {
                MessageBox.Show($"Tooth {ToothNumber} has decay. Filling cavity now...");
                ToothStatus.SetStatus("Healthy");
            }
            else
            {
                MessageBox.Show($"Tooth {ToothNumber} does not have decay.");
            }
        }

        public void PerformRootCanal()
        {
            if (ToothStatus.GetStatus() == "Crown")
            {
                MessageBox.Show($"Tooth {ToothNumber} has a crown. Performing root canal now...");
                ToothStatus.SetStatus("Healthy");
            }
            else
            {
                MessageBox.Show($"Tooth {ToothNumber} does not have a crown.");
            }
        }

        public void TreatPulpitis()
        {
            if (ToothStatus.GetStatus() == "Pulpitis")
            {
                MessageBox.Show($"Tooth {ToothNumber} has pulpitis. Treating now...");
                ToothStatus.SetStatus("Healthy");
            }
            else
            {
                MessageBox.Show($"Tooth {ToothNumber} does not have pulpitis.");
            }
        }

        public void RemoveDentalTartar()
        {
            if (ToothStatus.GetStatus() == "Tartar")
            {
                MessageBox.Show($"Tooth {ToothNumber} has tartar. Removing now...");
                ToothStatus.SetStatus("Healthy");
            }
            else
            {
                MessageBox.Show($"Tooth {ToothNumber} does not have tartar.");
            }
        }

        public Tooth(int toothNumber, ToothStatus toothStatus, string crownStatus, string notes)
        {
            ToothNumber = toothNumber;
            ToothStatus = toothStatus;
            CrownStatus = crownStatus;
            Notes = notes;
        }

        public string GetCrownStatus()
        {
            return CrownStatus;
        }
    }


    //[Serializable]
    public class ToothStatus : Checkup
    {
        //[XmlElement("Status")]
        public string Status { get; set; }

        /*public ToothStatus()
        {

        }*/
        
        public ToothStatus(string status)
        {
            Status = status;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string status)
        {
            Status = status;
        }

        public List<string> GetPossibleStatuses()
        {
            List<string> possibleStatuses = new List<string>();
            switch (Status)
            {
                case "Decayed":
                    possibleStatuses.Add("Healthy");
                    possibleStatuses.Add("Loose");
                    possibleStatuses.Add("Damaged");
                    break;
                case "Crown":
                    possibleStatuses.Add("Loose");
                    possibleStatuses.Add("Damaged");
                    break;
                case "Filled":
                    possibleStatuses.Add("Healthy");
                    possibleStatuses.Add("Loose");
                    possibleStatuses.Add("Damaged");
                    break;
                case "Pulpitis":
                    possibleStatuses.Add("Healthy");
                    possibleStatuses.Add("Loose");
                    possibleStatuses.Add("Damaged");
                    break;
                case "Other":
                    possibleStatuses.Add("Explain in the notes");
                    break;
                default:
                    possibleStatuses.Add("Not eligible");
                    break;
            }
            return possibleStatuses;
        }


        /*public int GetNumber()
        {
            string? firstChar = Status ? Substring(0, 1);
            if (firstChar == null)
            {
                throw new Exception("Unable to get number from ToothStatus");
            }
            int asciiCode = (int)firstChar[0];
            return asciiCode;
        }*/
    }
}
