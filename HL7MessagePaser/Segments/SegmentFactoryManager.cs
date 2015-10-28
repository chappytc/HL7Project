using System;
using System.Linq;
using HL7MessagePaser.Enums;

namespace HL7MessagePaser.Segments
{
    public class SegmentFactoryManager
    {
        private SegmentDelimiters _delimiters;
        public SegmentDelimiters Delimiters
        {
            get { return _delimiters; }
            set { _delimiters = value; }
        }

        public SegmentFactoryManager()
        {
            _delimiters = new SegmentDelimiters();
        }

        public SegmentFactoryManager(SegmentDelimiters delimiters)
        {
            _delimiters = delimiters;
        }

        public SegmentFactory GetFactory(DriverTypes driverType)
        {
            SegmentFactory newFactory = null;

            string driverTypeDescription = EnumUtils.stringValueOf(driverType);

            // Using custom attributes on the defined HL7 Segment Factory classes, we
            // can find the proper class to create an instance of. Doing it this
            // way, this factory class does not have to be updated each time a
            // new driver type is added.
            var types = from a in AppDomain.CurrentDomain.GetAssemblies()
                        from t in a.GetTypes()
                        where t.IsDefined(typeof(HL7SegmentFactoryAttribute), true)
                        select t;

            foreach (Type t in types)
            {
                var attributes = t.GetCustomAttributes(typeof(HL7SegmentFactoryAttribute), true);
                foreach (HL7SegmentFactoryAttribute a in attributes)
                {
                    if (a.DriverType == driverTypeDescription)
                    {
                        object[] constructorArgs =
                                        {
                                           _delimiters
                                        };
                        object obj = Activator.CreateInstance(t, constructorArgs);

                        newFactory = (SegmentFactory)obj;
                        break;
                    }
                }
                if (newFactory != null)
                    break;
            }

            return newFactory;
        }
    }
}
