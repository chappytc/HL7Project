namespace HL7MessagePaser.Types
{
    public class ExtendedAddress : Address
    {
        public string CountyOrParishCode { get; set; }
        public string CensusTract { get; set; }
    }
}
