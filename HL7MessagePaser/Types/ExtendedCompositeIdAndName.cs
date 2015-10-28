namespace HL7MessagePaser.Types
{
    public class ExtendedCompositeIdAndName : CompositeIdAndName
    {
        public string NameTypeCode { get; set; }
        public string IdentifierCheckDigit { get; set; }
        public string IdentifierCheckDigitScheme { get; set; }
        public string IdentifierTypeCode { get; set; }
        public string AssigningFacility { get; set; }
    }
}
