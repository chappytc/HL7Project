namespace HL7MessagePaser.Types
{
    public class CodedElement
    {
        public string Identifier { get; set; }
        public string Text { get; set; }
        public string NameOfCodingSystem  { get; set; }
        public string AlternateIdentifier { get; set; }
        public string AlternateText { get; set; }
        public string AlternateNameOfCodingSystem { get; set; }
    }
}
