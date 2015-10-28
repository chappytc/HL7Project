namespace HL7MessagePaser.Types
{
    public class PhoneNumber
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string LineNumber { get; set; }
        public string Extension { get; set; }
        public string OtherCode { get; set; }
        public string Notes { get; set; }
    }
}
