namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class IN1 : Generic.IN1
    {
        public IN1(string mshSegment)
            : base(mshSegment)
        {

        }

        public IN1(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
