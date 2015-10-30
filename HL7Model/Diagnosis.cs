using System;
using System.ComponentModel.DataAnnotations;

namespace HL7Model
{
    public class Diagnosis
    {
        [Key]
        public int DiagnosisId { get; set; }
        public int SetId { get; set; }
        public string Description { get; set; }
        public DateTime? DiagnosisDateTime { get; set; }
        public string Clinician { get; set; }
    }
}
