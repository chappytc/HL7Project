using System.ComponentModel.DataAnnotations;

namespace HL7Model
{
    public class PersonName
    {
        [Key]
        public int PersonNameId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Degree { get; set; }
    }
}
