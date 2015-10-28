using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.TennesseeHealthCare
{
    public class GT1 : Generic.GT1
    {
        public GT1(string mshSegment)
            : base(mshSegment)
        {

        }

        public GT1(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }

        new public ExtendedPhoneNumber GetGuarantorHomePhoneNumber()
        {
            // For some reason, Tennessee Health Care swapped country code and area code in the Guarantor Home Phone Number.
            // So, override the GuarantorHomePhoneNumber() method with a new method that deals with the swapped positions.
            ExtendedPhoneNumber xpn = new ExtendedPhoneNumber();

            string fieldValue = GetField(5);

            xpn.TelecommunicationUseCode = GetComponent(fieldValue, 1);
            xpn.TelecommunicationEquipmentType = GetComponent(fieldValue, 2);
            xpn.EmailAddress = GetComponent(fieldValue, 3);
            xpn.CountryCode = GetComponent(fieldValue, 5);
            xpn.AreaCode = GetComponent(fieldValue, 4);
            xpn.LineNumber = GetComponent(fieldValue, 6);
            xpn.Extension = GetComponent(fieldValue, 7);
            xpn.Notes = GetComponent(fieldValue, 8);

            return xpn;
        }
    }
}
