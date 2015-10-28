using HL7MessagePaser.Enums;

namespace HL7MessagePaser.Messages.V23
{
    [HL7Message("USAHealthCare", "2.3")]
    public class USAHealthCareMessage : Message
    {        
        public USAHealthCareMessage(string message) : base(message)
        {
            _driverType = DriverTypes.UsaHealthCare;
        }
    }
}
