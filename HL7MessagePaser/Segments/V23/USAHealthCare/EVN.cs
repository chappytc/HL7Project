namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class EVN : Generic.EVN
    {
        public EVN(string mshSegment)
            : base(mshSegment)
        {

        }

        public EVN(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
