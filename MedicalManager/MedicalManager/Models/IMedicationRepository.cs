using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalManager.Models
{
    public interface IMedicationRepository
    {
        Medication GetMedication(int Id);
        IEnumerable<Medication> GetAllMedication();
        Medication AddMedication(Medication medication);
        Medication UpdateMedication(Medication medication);
        Medication DeleteMedication(int id);
    }
}
