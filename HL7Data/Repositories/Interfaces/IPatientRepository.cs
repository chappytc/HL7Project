using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Model;

namespace HL7Data.Repositories.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Patient GetPatientById(int patientId);
        int RemovePatientByExternalId(string externalId);
        Patient GetPatientByExternalId(string externalId);
    }
}
