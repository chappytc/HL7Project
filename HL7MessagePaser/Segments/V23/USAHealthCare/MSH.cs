using System;

namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class MSH : Generic.MSH
    {
        public MSH(string mshSegment)
            : base(mshSegment)
        {

        }

        new public DateTime? GetMessageDateTime()
        {
            // The date is in the format of yyyyMMddhhmmss; 20050110045504 == Jan 10, 2005 4:55:04
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(6), "yyyyMMddhhmmss");
        }
    }
}
