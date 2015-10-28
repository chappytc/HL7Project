using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class NK1 : Abstracts.NK1
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

        public override int GetSetId()
        {
            int parsedInt;
            int.TryParse(GetField(1), out parsedInt);

            return parsedInt;
        }

        public override ExtendedPersonName GetName()
        {
            return GetExtendedPersonName(2);
        }

        public override CodedElement GetRelationship()
        {
            return GetCodedElement(3);
        }

        public override ExtendedAddress GetAddress()
        {
            return GetExtendedAddress(4);
        }

        public override ExtendedPhoneNumber GetPhoneNumber()
        {
            return GetExtendedPhoneNumber(5);
        }

        public override ExtendedPhoneNumber GetBusinessPhoneNumber()
        {
            return GetExtendedPhoneNumber(6);
        }

        public override CodedElement GetContactRole()
        {
            return GetCodedElement(7);
        }

        public override DateTime? GetStartDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(8), "yyyyMMddHHmmss");
        }

        public override DateTime? GetEndDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(9), "yyyyMMddHHmmss");
        }

        public override string GetNextOfKinAssociatedPartiesJobTitle()
        {
            return GetField(10);
        }

        public override JobCodeClass GetNextOfKinAssociatedPartiesJobCodeClass()
        {
            return GetJobCodeClass(11);
        }

        public override ExtendedOrganization GetNextOfKinAssociatedPartiesEmployeeNumber()
        {
            return GetExtendedOrganization(12);
        }

        public override ExtendedCompositeIdWithCheckDigit GetOrganizationName()
        {
            return GetExtendedCompositeIdWithCheckDigit(13);
        }

        public override string GetMaritalStatus()
        {
            return GetField(14);
        }

        public override string GetSex()
        {
            return GetField(15);
        }

        public override DateTime? GetDateTimeOfBirth()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(16), "yyyyMMddHHmmss");
        }

        public override string GetLivingDependency()
        {
            return GetField(17);
        }

        public override string GetAmbulatoryStatus()
        {
            return GetField(18);
        }

        public override string GetCitizenship()
        {
            return GetField(19);
        }

        public override CodedElement GetPrimaryLanguage()
        {
            return GetCodedElement(20);
        }

        public override string GetLivingArrangement()
        {
            return GetField(21);
        }

        public override string GetPublicityIndicator()
        {
            return GetField(22);
        }

        public override string GetProtectionIndicator()
        {
            return GetField(23);
        }

        public override string GetStudentIndicator()
        {
            return GetField(24);
        }

        public override string GetReligion()
        {
            return GetField(25);
        }

        public override ExtendedPersonName GetMothersMaidenName()
        {
            return GetExtendedPersonName(26);
        }

        public override CodedElement GetNationality()
        {
            return GetCodedElement(27);
        }

        public override string GetEthnicGroup()
        {
            return GetField(28);
        }

        public override CodedElement GetContactReason()
        {
            return GetCodedElement(29);
        }

        public override ExtendedPersonName GetContactPersonsName()
        {
            return GetExtendedPersonName(30);
        }

        public override ExtendedPhoneNumber GetContactPersonsTelephoneNumber()
        {
            return GetExtendedPhoneNumber(31);
        }

        public override ExtendedAddress GetContactPersonsAddress()
        {
            return GetExtendedAddress(32);
        }

        public override ExtendedCompositeIdWithCheckDigit GetNextOfKinAssociatedPartysIdentifiers()
        {
            return GetExtendedCompositeIdWithCheckDigit(33);
        }

        public override string GetJobStatus()
        {
            return GetField(34);
        }

        public override string GetRace()
        {
            return GetField(35);
        }

        public override string GetHandicap()
        {
            return GetField(36);
        }

        public override string GetContactPersonSocialSecurityNumber()
        {
            return GetField(37);
        }
    }
}
