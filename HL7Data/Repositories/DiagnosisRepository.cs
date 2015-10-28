using System;
using System.Data.Entity;
using System.Linq;
using HL7Data.Repositories.Interfaces;
using HL7Model;

namespace HL7Data.Repositories
{
    public class DiagnosisRepository : HL7Repository<Diagnosis>, IDiagnosisRepository
    {
        public DiagnosisRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Diagnosis> GetDiagnosesForClinician(string clinician)
        {
            return GetAll().Where(d => d.Clinician.ToUpper() == clinician.ToUpper());
        }

        public int RemoveAllDiagnosisForSetId(int setId)
        {
            IQueryable<Diagnosis> matches = GetAll().Where(d => d.SetId == setId);
            foreach (Diagnosis d in matches)
            {
                Delete(d);
            }

            return matches.Count();
        }
    }
}
