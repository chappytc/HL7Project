using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class PID : Abstracts.PID
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

        public override string GetSetPatientId()
        {
            return GetField(1);
        }

        public override string GetExternalPatientId()
        {
            return GetField(2);
        }

        public override string GetInternalPatientId()
        {
            return GetField(3);
        }

        public override string GetAlternatePatientId()
        {
            return GetField(4);
        }

        public override ExtendedPersonName GetPatientName()
        {
            return GetExtendedPersonName(5);
        }

        public override string GetMothersMaidenName()
        {
            return GetField(6);
        }

        public override DateTime? GetDateOfBirth()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(7), "yyyyMMdd");
        }

        public override string GetGender()
        {
            return GetField(8);
        }

        public override string GetPatientAlias()
        {
            return GetField(9);
        }

        public override string GetRace()
        {
            return GetField(10);
        }

        public override ExtendedAddress GetPatientAddress()
        {
            return GetExtendedAddress(11);
        }

        public override string GetCountyCode()
        {
            return GetField(12);
        }

        public override ExtendedPhoneNumber GetHomePhoneNumber()
        {
            return GetExtendedPhoneNumber(13);
        }

        public override ExtendedPhoneNumber GetBusinessPhoneNumber()
        {
            return GetExtendedPhoneNumber(14);
        }

        public override string GetPrimaryLanguage()
        {
            return GetField(15);
        }

        public override string GetMaritalStatus()
        {
            return GetField(16);
        }

        public override string GetReligion()
        {
            return GetField(17);
        }

        public override string GetPatientAccountNumber()
        {
            return GetField(18);
        }

        public override string GetSSN()
        {
            return GetField(19);
        }

        public override string GetDriversLicenseNumber()
        {
            return GetField(20);
        }

        public override string GetMothersIdentifier()
        {
            return GetField(21);
        }

        public override string GetEthnicGroup()
        {
            return GetField(22);
        }

        public override string GetBirthPlace()
        {
            return GetField(23);
        }

        public override string GetMultipleBirthIndicator()
        {
            return GetField(24);
        }

        public override string GetBirthOrder()
        {
            return GetField(25);
        }

        public override string GetCitizenship()
        {
            return GetField(26);
        }

        public override string GetPatientDeathIndicator()
        {
            return GetField(27);
        }

        public override string GetVeteransMilitaryStatus()
        {
            return GetField(28);
        }

        public override string GetNationality()
        {
            return GetField(29);
        }

        public override DateTime? GetPatientDeathDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(30), "yyyyMMddHHmmss");
        }
    }
}
