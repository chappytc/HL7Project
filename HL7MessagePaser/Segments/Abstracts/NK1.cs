using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Next of kin segment
    /// </summary>
    public abstract class NK1 : SegmentV23
    {
        protected NK1(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.NK1;
        }

        public abstract int GetSetId();
        public abstract ExtendedPersonName GetName();
        public abstract CodedElement GetRelationship();
        public abstract ExtendedAddress GetAddress();
        public abstract ExtendedPhoneNumber GetPhoneNumber();
        public abstract ExtendedPhoneNumber GetBusinessPhoneNumber();
        public abstract CodedElement GetContactRole();
        public abstract DateTime? GetStartDate();
        public abstract DateTime? GetEndDate();
        public abstract string GetNextOfKinAssociatedPartiesJobTitle();
        public abstract JobCodeClass GetNextOfKinAssociatedPartiesJobCodeClass();
        public abstract ExtendedOrganization GetNextOfKinAssociatedPartiesEmployeeNumber();
        public abstract ExtendedCompositeIdWithCheckDigit GetOrganizationName();
        public abstract string GetMaritalStatus();
        public abstract string GetSex();
        public abstract DateTime? GetDateTimeOfBirth();
        public abstract string GetLivingDependency();
        public abstract string GetAmbulatoryStatus();
        public abstract string GetCitizenship();
        public abstract CodedElement GetPrimaryLanguage();
        public abstract string GetLivingArrangement();
        public abstract string GetPublicityIndicator();
        public abstract string GetProtectionIndicator();
        public abstract string GetStudentIndicator();
        public abstract string GetReligion();
        public abstract ExtendedPersonName GetMothersMaidenName();
        public abstract CodedElement GetNationality();
        public abstract string GetEthnicGroup();
        public abstract CodedElement GetContactReason();
        public abstract ExtendedPersonName GetContactPersonsName();
        public abstract ExtendedPhoneNumber GetContactPersonsTelephoneNumber();
        public abstract ExtendedAddress GetContactPersonsAddress();
        public abstract ExtendedCompositeIdWithCheckDigit GetNextOfKinAssociatedPartysIdentifiers();
        public abstract string GetJobStatus();
        public abstract string GetRace();
        public abstract string GetHandicap();
        public abstract string GetContactPersonSocialSecurityNumber();
    }
}
