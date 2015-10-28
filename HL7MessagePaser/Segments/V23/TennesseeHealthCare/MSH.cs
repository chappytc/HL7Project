using System;

namespace HL7MessagePaser.Segments.V23.TennesseeHealthCare
{
    public class MSH : Generic.MSH
    {
        public MSH(string mshSegment)
            : base(mshSegment)
        {
        }

        new public DateTime? GetMessageDateTime()
        {
            // The date is in the format of MMDDYYYYHHmmss; 01012015043000 = Jan 1, 2015 4:30:00
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(6), "MMddyyyyHHmmss");
        }
    }
}
