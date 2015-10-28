namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class IN2 : Generic.IN2
    {
        public IN2(string mshSegment)
            : base(mshSegment)
        {

        }

        public IN2(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
