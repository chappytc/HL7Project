namespace HL7MessagePaser.Types
{
    public class MessageType
    {
        private string _type;
        public string Type
        {
            get { return _type; }
        }

        private string _triggerEvent;
        public string TriggerEvent
        {
            get { return _triggerEvent; }
        }

        public MessageType(string type, string triggerEvent)
        {
            _type = type;
            _triggerEvent = triggerEvent;
        }
    }
}
