namespace HL7MessagePaser.Types
{
    public class ExtendedPhoneNumber : PhoneNumber
    {
        public string EmailAddress { get; set; }
        public string TelecommunicationUseCode { get; set; }
        public string TelecommunicationEquipmentType { get; set; }
    }
}
