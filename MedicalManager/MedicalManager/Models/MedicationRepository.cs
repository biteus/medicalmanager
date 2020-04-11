using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalManager.Models
{
    public class MedicationRepository : IMedicationRepository
    {
        private readonly MedicalManagerDBContext _dbContext;

        public MedicationRepository(MedicalManagerDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        Medication IMedicationRepository.AddMedication(Medication medication)
        {
            _dbContext.Medications.Add(medication);
            _dbContext.SaveChanges();
            return medication;
        }

        Medication IMedicationRepository.DeleteMedication(int id)
        {
            Medication medication = _dbContext.Medications.Find(id);
            if(medication != null)
            {
                _dbContext.Medications.Remove(medication);
                _dbContext.SaveChanges();
            }
            return medication;
        }

        IEnumerable<Medication> IMedicationRepository.GetAllMedication()
        {
            return _dbContext.Medications;
        }

        Medication IMedicationRepository.GetMedication(int id)
        {
            return _dbContext.Medications.Find(id);
        }

        Medication IMedicationRepository.UpdateMedication(Medication medicationUpdate)
        {
            var updatedMedication = _dbContext.Medications.Attach(medicationUpdate);
            updatedMedication.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return medicationUpdate;
        }
    }
}
