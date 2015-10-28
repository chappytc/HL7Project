using System.Linq;
using HL7Model;

namespace HL7Data.Repositories.Interfaces
{
    public interface IDiagnosisRepository : IRepository<Diagnosis>
    {
        IQueryable<Diagnosis> GetDiagnosesForClinician(string clinician);
        int RemoveAllDiagnosisForSetId(int setId);
    }
}
