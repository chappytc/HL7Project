using System;
using System.Linq;
using HL7Data;
using HL7Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HL7UnitTests.DataLayer
{
    [TestClass]
    public class DataLayerTests
    {
        [TestMethod]
        public void CanInsertNewPatientRecord()
        {
            var name = new PersonName();
            name.FirstName = "Thomas";
            name.LastName = "Chapman";
            name.MiddleName = "C";

            var newDiagnosis1 = new Diagnosis();
            newDiagnosis1.SetId = 9998;
            newDiagnosis1.DiagnosisDateTime = DateTime.Now;
            newDiagnosis1.Description = "Test Diagnosis 1";
            newDiagnosis1.Clinician = "Dr. Test";

            var newDiagnosis2 = new Diagnosis();
            newDiagnosis2.SetId = 9998;
            newDiagnosis2.DiagnosisDateTime = DateTime.Now;
            newDiagnosis2.Description = "Test Diagnosis 2";
            newDiagnosis2.Clinician = "Dr. Assert";

            var newPatientVisit = new PatientVisit();
            newPatientVisit.SetId = 9998;
            newPatientVisit.Location.Bed = "1";
            newPatientVisit.Location.Building = "5";
            newPatientVisit.Location.Facility = "UMC";
            newPatientVisit.Location.Floor = "2";
            newPatientVisit.Location.LocationDescription = "General";
            newPatientVisit.Location.LocationStatus = "Active";
            newPatientVisit.Location.Room = "2112";            

            var newPatient = new Patient();
            newPatient.ExternalPatientId = "123456789";
            newPatient.InternalPatientId = "987654321";
            newPatient.Address.Address1 = "1917 Churchill Downs";
            newPatient.Address.Address2 = "";
            newPatient.Address.City = "Lebanon";
            newPatient.Address.State = "TN";
            newPatient.Address.PostalCode = "37087";
            newPatient.Gender = "M";
            newPatient.DateOfBirth = Convert.ToDateTime("11/23/1976");
            newPatient.PrimaryPhoneNumber.AreaCode = "615";
            newPatient.PrimaryPhoneNumber.CountryCode = "1";
            newPatient.PrimaryPhoneNumber.LineNumber = "496-4071";
            newPatient.Names.Add(name);
            newPatient.Diagnosis.Add(newDiagnosis1);
            newPatient.Diagnosis.Add(newDiagnosis2);
            newPatient.PatientVisit.Add(newPatientVisit);

            IHL7UnitOfWork uow = new HL7UnitOfWork();
            uow.Patients.Add(newPatient);
            uow.Commit();            

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetPatientsWithExternalId123456789()
        {
            IHL7UnitOfWork uow = new HL7UnitOfWork();

            Patient patient = uow.Patients.GetPatientByExternalId("123456789");

            Assert.AreEqual("987654321", patient.InternalPatientId);
            Assert.AreEqual("THOMAS", patient.Names[0].FirstName.ToUpper());
            Assert.AreEqual("TEST DIAGNOSIS 1", patient.Diagnosis[0].Description.ToUpper());
            Assert.AreEqual("2112", patient.PatientVisit[0].Location.Room);
        }

        [TestMethod]
        public void UpdatePatientsWithExternalId123456789()
        {
            IHL7UnitOfWork uow = new HL7UnitOfWork();

            Patient patientNotModified = uow.Patients.GetPatientByExternalId("123456789");

            patientNotModified.Address.Address1 = "904 Bonnie Blue Way";

            uow.Patients.Update(patientNotModified);

            uow.Commit();

            Patient patientModified = uow.Patients.GetPatientByExternalId("123456789");

            Assert.AreEqual("904 Bonnie Blue Way", patientModified.Address.Address1);
        }

        [TestMethod]
        public void DeleteAllPatientsWithExternalId123456789()
        {
            IHL7UnitOfWork uow = new HL7UnitOfWork();

            int recordsRemoved = uow.Patients.RemovePatientByExternalId("123456789");

            uow.Commit();

            Assert.IsTrue(recordsRemoved > 0);
        }

        [TestMethod]
        public void CanInsertNewDiagnosisRecord()
        {
            string clinicianName = "Dr. Test";

            IHL7UnitOfWork uow = new HL7UnitOfWork();
            int recordCountBefore = uow.Diagnoses.GetDiagnosesForClinician(clinicianName).Count();

            var newDiagnosis = new Diagnosis();
            newDiagnosis.SetId = 9999;
            newDiagnosis.DiagnosisDateTime = DateTime.Now;
            newDiagnosis.Description = "Test Diagnosis";
            newDiagnosis.Clinician = clinicianName;
                        
            uow.Diagnoses.Add(newDiagnosis);
            uow.Commit();

            Assert.IsTrue(uow.Diagnoses.GetDiagnosesForClinician(clinicianName).Count() == (recordCountBefore + 1));

        }

        [TestMethod]
        public void DeleteAllDiagnosisRecordsForSetId9999()
        {
            IHL7UnitOfWork uow = new HL7UnitOfWork();
            int recordsRemoved = uow.Diagnoses.RemoveAllDiagnosisForSetId(9999);
            uow.Commit();

            Assert.IsTrue(recordsRemoved > 0);
        }
    }
}
