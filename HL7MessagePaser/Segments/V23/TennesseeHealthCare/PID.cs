using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.TennesseeHealthCare
{
    public class PID : Generic.PID
    {
        public PID(string mshSegment)
            : base(mshSegment)
        {

        }

        public PID(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }

        public override ExtendedPersonName GetPatientName()
        {
            // Tennessee Health care only sends the first name, middle initial, and last name, in that order.
            // Since it is not the standard v2.3 format...
            ExtendedPersonName xpn = new ExtendedPersonName();

            string fieldValue = GetField(5);
            
            xpn.GivenName = GetComponent(fieldValue, 0);
            xpn.MiddleNameOrInitial = GetComponent(fieldValue, 1);
            xpn.FamilyName = GetComponent(fieldValue, 2);

            return xpn;
        }
    }
}
