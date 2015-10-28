namespace HL7MessagePaser.Types
{
    public class ExtendedCompositeIdWithCheckDigit : CompositeIdWithCheckDigit
    {
        public string IdentifierTypeCode { get; set; }
        public string AssigningFacility { get; set; }
    }
}
