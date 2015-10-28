namespace HL7MessagePaser.Types
{
    public class CompositeIdAndName : PersonName
    {
        public string Id { get; set; }
        public string SourceTable { get; set; }
        public string AssigningAuthority { get; set; }
    }
}
