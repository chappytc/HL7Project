using HL7MessagePaser.Enums;

namespace HL7MessagePaser.Messages.V23
{
    [HL7Message("Generic23HealthCare", "2.3")]
    public class GenericHealthCareMessage : Message
    {
        public GenericHealthCareMessage(string message) : base(message)
        {
            _driverType = DriverTypes.GenericV23;
        }
    }
}
