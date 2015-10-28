namespace HL7MessagePaser.Segments.V23.TennesseeHealthCare
{
    public class NK1 : Generic.NK1
    {
        public NK1(string mshSegment)
            : base(mshSegment)
        {

        }

        public NK1(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }
    }
}
