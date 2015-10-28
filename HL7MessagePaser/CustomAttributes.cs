using System;

namespace HL7MessagePaser
{
    [AttributeUsage(AttributeTargets.Class |
                       AttributeTargets.Struct,
                       AllowMultiple = true)  // multiuse attribute
    ]
    public class HL7MessageAttribute : Attribute
    {
        private string _healthCareProvider;
        private string _version;

        public HL7MessageAttribute(string healthCareProvider, string version)
        {
            _healthCareProvider = healthCareProvider;
            _version = version;
        }

        public string HealthCareProvider
        {
            get { return _healthCareProvider; }
        }

        public string Version
        {
            get { return _version; }
        }
    }

    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Struct,
        AllowMultiple = true) // multiuse attribute
    ]
    public class HL7SegmentFactoryAttribute : Attribute
    {
        private string _driverType;

        public HL7SegmentFactoryAttribute(string driverType)
        {
            _driverType = driverType;
        }

        public string DriverType
        {
            get { return _driverType; }
        }
    }
}
