namespace HL7MessagePaser.Types
{
    public class ExtendedOrganization
    {
        public string OrganizationName { get; set; }
        public string NameTypeCode { get; set; }
        public int Id { get; set; }
        public int CheckDigit { get; set; }
        public string CheckDigitScheme { get; set; }
        public string AssigningAuthority { get; set; }
        public string IdentifierTypeCode { get; set; }
        public string AssigningFacilityId { get; set; }
    }
}
