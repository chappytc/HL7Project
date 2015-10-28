namespace HL7MessagePaser.Segments.V23.USAHealthCare
{
    public class DG1 : Generic.DG1
    {
        public DG1(string mshSegment)
            : base(mshSegment)
        {

        }

        public DG1(string mshSegment, SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
