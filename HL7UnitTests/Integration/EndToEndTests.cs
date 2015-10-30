using System;
using HL7Data;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Messages;
using HL7MessagePaser.Segments.Abstracts;
using HL7MessagePaser.Types;
using HL7Model;
using HL7UnitTests.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Address = HL7MessagePaser.Types.Address;
using PersonLocation = HL7MessagePaser.Types.PersonLocation;
using PhoneNumber = HL7MessagePaser.Types.PhoneNumber;

namespace HL7UnitTests.Integration
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void ConsumeMessage_PersistPatientInfoToDatabase_RetrievePatientInfo_IsSuccess()
        {
            // Consume a message
            MessageFactory messageFactory = new MessageFactory();
            Message newMessage = messageFactory.MakeMessage(TestMessages.TennesseeHealthCare_ADT_A01);

            // Parse some segments
            PID pidSegment = (PID)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PID);           
            DG1 dg1Segment = (DG1)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.DG1);
            PV1 pv1Segment = (PV1)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PV1);

            // Populate some models with the parsed data
            ExtendedPersonName patientExtendedPersonName = pidSegment.GetPatientName();
            var name = new HL7Model.PersonName();
            name.FirstName = patientExtendedPersonName.GivenName;
            name.LastName = patientExtendedPersonName.FamilyName;
            name.MiddleName = patientExtendedPersonName.MiddleNameOrInitial;

            var newDiagnosis1 = new HL7Model.Diagnosis();
            newDiagnosis1.SetId = dg1Segment.GetSetId();
            newDiagnosis1.DiagnosisDateTime = dg1Segment.GetDiagnosisDateTime();
            newDiagnosis1.Description = dg1Segment.GetDiagnosisDescription();
            newDiagnosis1.Clinician = dg1Segment.GetDiagnosingClinician();

            PersonLocation patientLocation = pv1Segment.GetAssignedPatientLocation();
            var newPatientVisit = new HL7Model.PatientVisit();
            newPatientVisit.SetId = pv1Segment.GetSetID();
            newPatientVisit.Location.Bed = patientLocation.Bed;
            newPatientVisit.Location.Building = patientLocation.Building;
            newPatientVisit.Location.Facility = patientLocation.Facility;
            newPatientVisit.Location.Floor = patientLocation.Floor;
            newPatientVisit.Location.LocationDescription = patientLocation.LocationDescription;
            newPatientVisit.Location.LocationStatus = patientLocation.LocationStatus;
            newPatientVisit.Location.Room = patientLocation.Room;

            Address patientAddress = pidSegment.GetPatientAddress();
            PhoneNumber patientPhoneNumber = pidSegment.GetHomePhoneNumber();
            var newPatient = new HL7Model.Patient();
            newPatient.ExternalPatientId = pidSegment.GetExternalPatientId();
            newPatient.InternalPatientId = pidSegment.GetInternalPatientId();
            newPatient.Address.Address1 = patientAddress.Address1;
            newPatient.Address.Address2 = patientAddress.Address2;
            newPatient.Address.City = patientAddress.City;
            newPatient.Address.State = patientAddress.State;
            newPatient.Address.PostalCode = patientAddress.ZipCode;
            newPatient.Gender = pidSegment.GetGender();
            newPatient.DateOfBirth = pidSegment.GetDateOfBirth();
            newPatient.PrimaryPhoneNumber.AreaCode = patientPhoneNumber.AreaCode;
            newPatient.PrimaryPhoneNumber.CountryCode = patientPhoneNumber.CountryCode;
            newPatient.PrimaryPhoneNumber.LineNumber = patientPhoneNumber.LineNumber;
            newPatient.Names.Add(name);
            newPatient.Diagnosis.Add(newDiagnosis1);
            newPatient.PatientVisit.Add(newPatientVisit);

            // Commit the patient to the database
            IHL7UnitOfWork uow = new HL7UnitOfWork();
            uow.Patients.Add(newPatient);
            uow.Commit();

            // Retrieve the patient back from the database
            Patient patient = uow.Patients.GetPatientByExternalId(pidSegment.GetExternalPatientId());

            // Assert that the data retrieved from the database is the same as what went in.
            Assert.AreEqual(pidSegment.GetInternalPatientId(), patient.InternalPatientId);
            Assert.AreEqual(patientExtendedPersonName.GivenName, patient.Names[0].FirstName);
            Assert.AreEqual(dg1Segment.GetDiagnosisDescription(), patient.Diagnosis[0].Description);
            Assert.AreEqual(patientLocation.Room, patient.PatientVisit[0].Location.Room);
        }
    }
}
