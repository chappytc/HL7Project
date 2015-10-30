using System;
using System.Collections.Generic;
using System.Linq;
using HL7MessagePaser.Segments;

namespace HL7MessagePaser.Messages
{
    public class MessageFactory
    {
        private const int HEALTHCARE_PROVIDER_MSH_FIELD_INDEX = 3;
        private const int HL7_VERSION_MSH_FIELD_INDEX = 11;

        private const int FIELD_SEPARATOR_START_INDEX = 3;
        private const int FIELD_SEPARATOR_LENGTH = 1;

        private const string MESSAGE_HEADER_SEGMENT_ID = "MSH";

        IEnumerable<Type> GetTypesWith<TAttribute>(bool inherit)
                                      where TAttribute : Attribute
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(TAttribute), inherit)
                   select t;
        }

        public Message MakeMessage(string message)
        {
            Message newMessage = null;

            if (!string.IsNullOrEmpty(message))
            {
                List<string> segments = new List<string>(message.Replace("\r\n", "\r").Split('\r'));

                // First segment of a message should always be a MSH segment. But, just in case it is not,
                // find the first MSH segment in the message and use it.
                string mshSegment = segments.FirstOrDefault(s => s.Contains(MESSAGE_HEADER_SEGMENT_ID));
                if (mshSegment != null)
                {
                    // Determine the field delimiter for the message.
                    char fieldSeparator = mshSegment.Substring(FIELD_SEPARATOR_START_INDEX, FIELD_SEPARATOR_LENGTH).ToCharArray()[0];

                    // Split the MSH into fields.
                    string[] fields = mshSegment.Split(fieldSeparator);

                    // Make sure the MSH has at least enough fields to get us the version number
                    if (fields.Length > HL7_VERSION_MSH_FIELD_INDEX)
                    {
                        string driverName = fields[HEALTHCARE_PROVIDER_MSH_FIELD_INDEX];
                        string version = fields[HL7_VERSION_MSH_FIELD_INDEX];

                        // Using custom attributes on the defined HL7 Message classes, we
                        // can find the proper class to create an instance of. Doing it this
                        // way, this factory class does not have to be updated each time a
                        // new message driver is added.
                        var types = from a in AppDomain.CurrentDomain.GetAssemblies()
                            from t in a.GetTypes()
                            where t.IsDefined(typeof (HL7MessageAttribute), true)
                            select t;

                        // TODO: Come back and see if there is a performance enhancement
                        foreach (Type t in types)
                        {
                            var attributes = t.GetCustomAttributes(typeof (HL7MessageAttribute), true);
                            foreach (HL7MessageAttribute a in attributes)
                            {
                                if (a.HealthCareProvider == driverName &&
                                    a.Version == version)
                                {
                                    object[] constructorArgs =
                                        {
                                            message
                                        };
                                    object obj = Activator.CreateInstance(t, constructorArgs);

                                    newMessage = (Message)obj;
                                    break;
                                }
                            }
                            if (newMessage != null)
                                break;
                        }
                    }
                }
            }

            if (newMessage != null)
            {
                newMessage.Segments = new List<Segment>();
                newMessage.Parse();
            }

            return newMessage;
        }
    }
}
