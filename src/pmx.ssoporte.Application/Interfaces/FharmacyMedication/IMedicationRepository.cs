using pmx.ssoporte.Domain.Entities;


namespace pmx.ssoporte.Application.Interfaces.FharmacyMedication
{
    public interface IMedicationRepository
    {
        Task<IEnumerable<Medication>> GetAllMedicationsAsync();
        Task<Medication> GetMedicationByIdAsync(int id);
    }
}
