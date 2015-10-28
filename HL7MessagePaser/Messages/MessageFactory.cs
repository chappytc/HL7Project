using System;
using System.Collections.Generic;
using System.Linq;
using HL7MessagePaser.Segments;

namespace HL7MessagePaser.Messages
{
    public class MessageFactory
    {
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

                // First segment of a message should always be a MSH segment.
                if (segments[0].StartsWith("MSH"))
                {
                    // Determine the field delimiter for the message.
                    char fieldSeparator = segments[0].Substring(3, 1).ToCharArray()[0];

                    // Split the MSH into fields.
                    string[] fields = segments[0].Split(fieldSeparator);

                    // Field 3 will tell us what message driver we need to use.
                    // Field 11 will tell us what HL7 version to use.
                    if (fields.Length > 11)
                    {
                        string driverName = fields[3];
                        string version = fields[11];

                        // Using custom attributes on the defined HL7 Message classes, we
                        // can find the proper class to create an instance of. Doing it this
                        // way, this factory class does not have to be updated each time a
                        // new message driver is added.
                        var types = from a in AppDomain.CurrentDomain.GetAssemblies()
                            from t in a.GetTypes()
                            where t.IsDefined(typeof (HL7MessageAttribute), true)
                            select t;

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
