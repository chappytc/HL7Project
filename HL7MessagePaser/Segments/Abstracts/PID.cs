using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Patient Identification
    /// </summary>
    public abstract class PID : SegmentV23
    {
        protected PID(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.PID;
        }

        public abstract string GetSetPatientId();
        public abstract string GetExternalPatientId();
        public abstract string GetInternalPatientId();
        public abstract string GetAlternatePatientId();
        public abstract ExtendedPersonName GetPatientName();
        public abstract string GetMothersMaidenName();
        public abstract DateTime? GetDateOfBirth();
        public abstract string GetGender();
        public abstract string GetPatientAlias();
        public abstract string GetRace();
        public abstract ExtendedAddress GetPatientAddress();
        public abstract string GetCountyCode();
        public abstract ExtendedPhoneNumber GetHomePhoneNumber();
        public abstract ExtendedPhoneNumber GetBusinessPhoneNumber();
        public abstract string GetPrimaryLanguage();
        public abstract string GetMaritalStatus();
        public abstract string GetReligion();
        public abstract string GetPatientAccountNumber();
        public abstract string GetSSN();
        public abstract string GetDriversLicenseNumber();
        public abstract string GetMothersIdentifier();
        public abstract string GetEthnicGroup();
        public abstract string GetBirthPlace();
        public abstract string GetMultipleBirthIndicator();
        public abstract string GetBirthOrder();
        public abstract string GetCitizenship();
        public abstract string GetPatientDeathIndicator();
        public abstract string GetVeteransMilitaryStatus();
        public abstract string GetNationality();
        public abstract DateTime? GetPatientDeathDateTime();
    }
}
