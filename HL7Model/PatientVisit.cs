using System.ComponentModel.DataAnnotations;

namespace HL7Model
{
    public class PatientVisit
    {
        [Key]
        public int PatientVisitId { get; set; }
        public int SetId { get; set; }
        public PersonLocation Location { get; set; }

        public PatientVisit()
        {
            Location = new PersonLocation();
        }
    }
}
