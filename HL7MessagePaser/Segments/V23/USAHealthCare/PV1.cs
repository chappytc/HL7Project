namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class PV1 : Generic.PV1
    {
        public PV1(string mshSegment)
            : base(mshSegment)
        {

        }

        public PV1(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
