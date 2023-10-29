using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagement.Classes
{
    public class DentalComponents
    {
        public int ToothNumber { get; set; }
        public bool IsHealthy { get; set; }

    }

    public abstract class Procedure
    {
        public int ToothNumber { get; set; }
        public string? ProcedureName { get; set; }
        public float Cost { get; set; }
        public abstract void DoProcedure(DentalStatus status);
    }

    public class DentalStatus
    {
        public List<DentalComponents> Teeth { get; } = new List<DentalComponents>();

        public void AddComponent(DentalComponents component)
        {
            Teeth.Add(component);
        }

        public void RemoveComponent(DentalComponents component)
        {
            Teeth.Remove(component);
        }
    }

    public class FillingProcedure : Procedure
    {
        public override void DoProcedure(DentalStatus status)
        {
            MessageBox.Show($"Performing filling procedure on tooth number {ToothNumber}...");
            MessageBox.Show($"Filling procedure cost: ${Cost}");

            DentalComponents? tooth = status.Teeth?.FirstOrDefault(t => t.ToothNumber == ToothNumber);
            if (tooth != null)
            {
                tooth.IsHealthy = true;
            }
        }
    }

    public class ExtractionProcedure : Procedure
    {
        public override void DoProcedure(DentalStatus status)
        {
            MessageBox.Show($"Performing tooth extraction procedure on tooth number {ToothNumber}...");
            MessageBox.Show($"Tooth extraction procedure cost: ${Cost}");

            DentalComponents? tooth = status.Teeth?.FirstOrDefault(t => t.ToothNumber == ToothNumber);
            if (tooth != null)
            {
                status.RemoveComponent(tooth);
            }
        }
    }
}
