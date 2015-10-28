using HL7MessagePaser.Enums;

namespace HL7MessagePaser.Messages.V23
{
    [HL7Message("TNHealthCare", "2.3")]
    [HL7Message("TNHealthSystems", "2.3")]
    public class TennesseeHealthCareMessage : Message
    {
        public TennesseeHealthCareMessage(string message) : base(message)
        {
            _driverType = DriverTypes.TennesseeHealthCare;
        }
    }
}
