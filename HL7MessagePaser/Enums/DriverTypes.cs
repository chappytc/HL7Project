using System.ComponentModel;

namespace HL7MessagePaser.Enums
{
    public enum DriverTypes
    {
        [Description("Unknown")]
        Unknown,

        [Description("Generic23HealthCare")]
        GenericV23,

        [Description("TNHealthCare")]
        TennesseeHealthCare,

        [Description("USAHealthCare")]
        UsaHealthCare
    }
}
