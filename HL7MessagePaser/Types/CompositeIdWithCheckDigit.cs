namespace HL7MessagePaser.Types
{
    public class CompositeIdWithCheckDigit
    {
        public int Id { get; set; }
        public int CheckDigit { get; set; }
        public string CheckDigitScheme { get; set; }
        public string AssigningAuthority { get; set; }
    }
}
