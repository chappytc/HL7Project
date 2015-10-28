using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Data.Repositories.Interfaces;
using HL7Model;

namespace HL7Data.Repositories
{
    class PatientRepository : HL7Repository<Patient>, IPatientRepository
    {
        public PatientRepository(DbContext dbContext) : base(dbContext)
        {
            
        }

        public Patient GetPatientById(int patientId)
        {
            return GetAll()
                .Include("Names")
                .Include("Diagnosis")
                .Include("PatientVisit")
                .FirstOrDefault(p => p.PatientId == patientId);
        }

        public Patient GetPatientByExternalId(string externalId)
        {
            return GetAll()
                .Include("Names")
                .Include("Diagnosis")
                .Include("PatientVisit")
                .FirstOrDefault(p => p.ExternalPatientId == externalId);
        }

        public int RemovePatientByExternalId(string externalId)
        {
            IQueryable<Patient> matches = GetAll().Where(p => p.ExternalPatientId == externalId);
            foreach (Patient p in matches)
            {
                Delete(p);
            }

            return matches.Count();
        }
    }
}
