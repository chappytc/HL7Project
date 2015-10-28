namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class GT1 : Generic.GT1
    {
        public GT1(string mshSegment)
            : base(mshSegment)
        {

        }

        public GT1(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
