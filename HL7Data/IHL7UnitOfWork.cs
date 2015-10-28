using HL7Data.Repositories.Interfaces;
using HL7Model;

namespace HL7Data
{
    public interface IHL7UnitOfWork
    {
        /// <summary>
        /// Save pending changes.
        /// </summary>
        void Commit();

        IPatientRepository Patients { get; }
        IDiagnosisRepository Diagnoses { get; }
    }
}
