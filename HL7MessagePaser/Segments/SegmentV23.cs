using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments
{
    public class SegmentV23 : Segment
    {
        public SegmentV23(string segment)
            : base(segment)
        {

        }

        internal ExtendedPersonName GetExtendedPersonName(int fieldIndex)
        {
            ExtendedPersonName xpn = new ExtendedPersonName();

            string fieldValue = GetField(fieldIndex);

            xpn.FamilyName = GetComponent(fieldValue, 0);
            xpn.GivenName = GetComponent(fieldValue, 1);
            xpn.MiddleNameOrInitial = GetComponent(fieldValue, 2);
            xpn.Suffix = GetComponent(fieldValue, 3);
            xpn.Prefix = GetComponent(fieldValue, 4);
            xpn.Degree = GetComponent(fieldValue, 5);
            xpn.NameTypeCode = GetComponent(fieldValue, 6);

            return xpn;
        }

        internal ExtendedAddress GetExtendedAddress(int fieldIndex)
        {
            ExtendedAddress address = new ExtendedAddress();

            string fieldValue = GetField(fieldIndex);

            address.Address1 = GetComponent(fieldValue, 0);
            address.Address2 = GetComponent(fieldValue, 1);
            address.City = GetComponent(fieldValue, 2);
            address.State = GetComponent(fieldValue, 3);
            address.ZipCode = GetComponent(fieldValue, 4);

            return address;
        }

        internal ExtendedCompositeIdWithCheckDigit GetExtendedCompositeIdWithCheckDigit(int fieldIndex)
        {
            ExtendedCompositeIdWithCheckDigit cx = new ExtendedCompositeIdWithCheckDigit();

            string fieldValue = GetField(fieldIndex);

            int parsedInt;

            int.TryParse(GetComponent(fieldValue, 0), out parsedInt);
            cx.Id = parsedInt;

            int.TryParse(GetComponent(fieldValue, 1), out parsedInt);
            cx.CheckDigit = parsedInt;

            cx.CheckDigitScheme = GetComponent(fieldValue, 2);
            cx.AssigningAuthority = GetComponent(fieldValue, 3);
            cx.IdentifierTypeCode = GetComponent(fieldValue, 4);
            cx.AssigningFacility = GetComponent(fieldValue, 5);

            return cx;
        }

        internal CodedElement GetCodedElement(int fieldIndex)
        {
            CodedElement ce = new CodedElement();

            string fieldValue = GetField(fieldIndex);

            ce.Identifier = GetComponent(fieldValue, 0);
            ce.Text = GetComponent(fieldValue, 1);
            ce.NameOfCodingSystem = GetComponent(fieldValue, 2);
            ce.AlternateIdentifier = GetComponent(fieldValue, 3);
            ce.AlternateText = GetComponent(fieldValue, 4);
            ce.AlternateNameOfCodingSystem = GetComponent(fieldValue, 5);

            return ce;
        }

        internal ExtendedPhoneNumber GetExtendedPhoneNumber(int fieldIndex)
        {
            ExtendedPhoneNumber xpn = new ExtendedPhoneNumber();

            string fieldValue = GetField(fieldIndex);

            //[NN][(999)]999-9999[X99999][B99999][C any text]
            string legacyPhoneNumber = GetComponent(fieldValue, 0);

            xpn.TelecommunicationUseCode = GetComponent(fieldValue, 1);
            xpn.TelecommunicationEquipmentType = GetComponent(fieldValue, 2);
            xpn.EmailAddress = GetComponent(fieldValue, 3);
            xpn.CountryCode = GetComponent(fieldValue, 4);
            xpn.AreaCode = GetComponent(fieldValue, 5);
            xpn.LineNumber = GetComponent(fieldValue, 6);
            xpn.Extension = GetComponent(fieldValue, 7);
            xpn.Notes = GetComponent(fieldValue, 8);

            return xpn;
        }

        internal ExtendedOrganization GetExtendedOrganization(int fieldIndex)
        {
            ExtendedOrganization xo = new ExtendedOrganization();

            string fieldValue = GetField(fieldIndex);

            xo.OrganizationName = GetComponent(fieldValue, 0);
            xo.NameTypeCode = GetComponent(fieldValue, 1);

            int parsedInt;
            int.TryParse(GetComponent(fieldValue, 2), out parsedInt);
            xo.Id = parsedInt;

            int.TryParse(GetComponent(fieldValue, 3), out parsedInt);
            xo.CheckDigit = parsedInt;

            xo.CheckDigitScheme = GetComponent(fieldValue, 4);
            xo.AssigningAuthority = GetComponent(fieldValue, 5);
            xo.IdentifierTypeCode = GetComponent(fieldValue, 6);
            xo.AssigningFacilityId = GetComponent(fieldValue, 7);
            return xo;
        }

        internal JobCodeClass GetJobCodeClass(int fieldIndex)
        {
            JobCodeClass jcc = new JobCodeClass();

            string fieldValue = GetField(fieldIndex);

            jcc.JobCode = GetComponent(fieldValue, 0);
            jcc.JobClass = GetComponent(fieldValue, 1);

            return jcc;
        }

        internal ExtendedCompositeIdAndName GetExtendedCompositeIdAndName(int fieldIndex)
        {
            ExtendedCompositeIdAndName xcn = new ExtendedCompositeIdAndName();

            string fieldValue = GetField(fieldIndex);

            xcn.Id = GetComponent(fieldValue, 1);
            xcn.FamilyName = GetComponent(fieldValue, 2);
            xcn.GivenName = GetComponent(fieldValue, 3);
            xcn.MiddleNameOrInitial = GetComponent(fieldValue, 4);
            xcn.Suffix = GetComponent(fieldValue, 5);
            xcn.Prefix = GetComponent(fieldValue, 6);
            xcn.Degree = GetComponent(fieldValue, 7);
            xcn.SourceTable = GetComponent(fieldValue, 8);
            xcn.AssigningAuthority = GetComponent(fieldValue, 9);

            return xcn;
        }

        internal PersonLocation GetPersonLocation(int fieldIndex)
        {
            PersonLocation pl = new PersonLocation();

            string fieldValue = GetField(fieldIndex);

            pl.PointOfCare = GetComponent(fieldValue, 0);
            pl.Room = GetComponent(fieldValue, 1);
            pl.Bed = GetComponent(fieldValue, 2);
            pl.Facility = GetComponent(fieldValue, 3);
            pl.LocationStatus = GetComponent(fieldValue, 4);
            pl.PersonLocationType = GetComponent(fieldValue, 5);
            pl.Building = GetComponent(fieldValue, 6);
            pl.Floor = GetComponent(fieldValue, 7);
            pl.LocationDescription = GetComponent(fieldValue, 8);

            return pl;
        }
    }
}
