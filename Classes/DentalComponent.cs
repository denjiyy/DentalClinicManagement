using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagement.Classes
{
    public class DentalComponent
    {
        /*public ToothStatus Status { get; set; }

        public DentalComponent(ToothStatus status)
        {
            Status = status;
        }
        */
        public void GetNumber(List<Tooth> teeth)
        {
            int healthyTeethCount = teeth.Count(tooth => tooth.ToothStatus.GetStatus() == "Healthy");
            MessageBox.Show($"The number of healthy teeth is: {healthyTeethCount}");
        }
    }

    /*public enum ToothStatus
    {
        Healthy,
        Decayed,
        Missing,
        Crown
    }*/
}
