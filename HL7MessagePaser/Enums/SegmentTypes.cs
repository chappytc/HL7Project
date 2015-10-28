using System.ComponentModel;

namespace HL7MessagePaser.Enums
{
    public enum SegmentTypes
    {
        [Description("Unknown")]
        Unknown,

        [Description("MSH")]
        MSH,

        [Description("DG1")]
        DG1,

        [Description("EVN")]
        EVN,

        [Description("GT1")]
        GT1,

        [Description("IN1")]
        IN1,

        [Description("IN2")]
        IN2,

        [Description("NK1")]
        NK1,

        [Description("PID")]
        PID,

        [Description("PV1")]
        PV1
    }
}
