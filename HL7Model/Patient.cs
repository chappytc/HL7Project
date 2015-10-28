using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HL7Model
{
    public class Patient
    {
        public Patient()
        {
            Names = new List<PersonName>();
            Diagnosis = new List<Diagnosis>();
            PatientVisit = new List<PatientVisit>();
            Address = new Address();
            PrimaryPhoneNumber = new PhoneNumber();
            SecondaryPhoneNumber = new PhoneNumber();
        }

        [Key]
        public int PatientId { get; set; }
        public string ExternalPatientId { get; set; }
        public string InternalPatientId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public PhoneNumber PrimaryPhoneNumber { get; set; }
        public PhoneNumber SecondaryPhoneNumber { get; set; }

        public List<PersonName> Names { get; set; }
        public List<Diagnosis> Diagnosis { get; set; }
        public List<PatientVisit> PatientVisit { get; set; }
    }
}
