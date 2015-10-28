namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class PID : Generic.PID
    {
        public PID(string mshSegment)
            : base(mshSegment)
        {

        }

        public PID(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
