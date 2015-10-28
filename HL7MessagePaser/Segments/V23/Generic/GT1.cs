using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class GT1 : Abstracts.GT1
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


        public override int GetSetId()
        {
            int parsedInt;
            int.TryParse(GetField(1), out parsedInt);

            return parsedInt;
        }

        public override ExtendedCompositeIdWithCheckDigit GetGuarantorNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(2);
        }

        public override ExtendedPersonName GetGuarantorName()
        {
            return GetExtendedPersonName(3);
        }

        public override ExtendedPersonName GetGuarantorSpouseName()
        {
            return GetExtendedPersonName(4);
        }

        public override ExtendedAddress GetGuarantorAddress()
        {
            return GetExtendedAddress(5);
        }

        public override ExtendedPhoneNumber GetGuarantorHomePhoneNumber()
        {
            return GetExtendedPhoneNumber(6);
        }

        public override ExtendedPhoneNumber GetGuarantorBusinessPhoneNumber()
        {
            return GetExtendedPhoneNumber(7);
        }

        public override DateTime? GetGuarantorDateOfBirth()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(8), "yyyyMMddHHmmss");
        }

        public override string GetGuarantorSex()
        {
            return GetField(9);
        }

        public override string GetGuarantorType()
        {
            return GetField(10);
        }

        public override string GetGuarantorRelationship()
        {
            return GetField(11);
        }

        public override string GetGuarantorSSN()
        {
            return GetField(12);
        }

        public override DateTime? GetGuarantorBeginDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(13), "yyyyMMddHHmmss");
        }

        public override DateTime? GetGuarantorEndDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(14), "yyyyMMddHHmmss");
        }

        public override int GetGuarantorPriority()
        {
            int parsedInt;
            int.TryParse(GetField(15), out parsedInt);

            return parsedInt;
        }

        public override ExtendedPersonName GetGuarantorEmployerName()
        {
            return GetExtendedPersonName(16);
        }

        public override ExtendedAddress GetGuarantorEmployerAddress()
        {
            return GetExtendedAddress(17);
        }

        public override ExtendedPhoneNumber GetGuarantorEmployerPhoneNumber()
        {
            return GetExtendedPhoneNumber(18);
        }

        public override ExtendedCompositeIdWithCheckDigit GetGuarantorEmployeeIDNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(19);
        }

        public override string GetGuarantorEmploymentStatus()
        {
            return GetField(20);
        }

        public override ExtendedOrganization GetGuarantorOrganizationName()
        {
            return GetExtendedOrganization(21);
        }

        public override string GetGuarantorBillingHoldFlag()
        {
            return GetField(22);
        }

        public override string GetGuarantorCreditRatingCode()
        {
            return GetField(23);
        }

        public override DateTime? GetGuarantorDeathDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(24), "yyyyMMddHHmmss");
        }

        public override string GetGuarantorDeathFlag()
        {
            return GetField(25);
        }

        public override string GetGuarantorChargeAdjustmentCode()
        {
            return GetField(26);
        }

        public override string GetGuarantorHouseholdAnnualIncome()
        {
            return GetField(27);
        }

        public override int GetGuarantorHouseholdSize()
        {
            int parsedInt;
            int.TryParse(GetField(28), out parsedInt);

            return parsedInt;
        }

        public override ExtendedCompositeIdWithCheckDigit GetGuarantorEmployerIDNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(29);
        }

        public override string GetGuarantorMaritalStatusCode()
        {
            return GetField(30);
        }

        public override DateTime? GetGuarantorHireEffectiveDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(31), "yyyyMMddHHmmss");
        }

        public override DateTime? GetEmploymentStopDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(32), "yyyyMMddHHmmss");
        }

        public override string GetLivingDependency()
        {
            return GetField(33);
        }

        public override string GetAmbulatoryStatus()
        {
            return GetField(34);
        }

        public override string GetCitizenship()
        {
            return GetField(35);
        }

        public override string GetPrimaryLanguage()
        {
            return GetField(36);
        }

        public override string GetLivingArrangement()
        {
            return GetField(37);
        }

        public override string GetPublicityIndicator()
        {
            return GetField(38);
        }

        public override string GetProtectionIndicator()
        {
            return GetField(39);
        }

        public override string GetStudentIndicator()
        {
            return GetField(40);
        }

        public override string GetReligion()
        {
            return GetField(41);
        }

        public override ExtendedPersonName GetMothersMaidenName()
        {
            return GetExtendedPersonName(42);
        }

        public override string GetNationality()
        {
            return GetField(43);
        }

        public override string GetEthnicGroup()
        {
            return GetField(44);
        }

        public override ExtendedPersonName GetContactPersonName()
        {
            return GetExtendedPersonName(45);
        }

        public override ExtendedPhoneNumber GetContactPersonPhoneNumber()
        {
            return GetExtendedPhoneNumber(46);
        }

        public override string GetContactReason()
        {
            return GetField(47);
        }

        public override string GetContactRelationship()
        {
            return GetField(48);
        }

        public override string GetJobTitle()
        {
            return GetField(49);
        }

        public override string GetJobCodeClass()
        {
            return GetField(50);
        }

        public override ExtendedOrganization GetGuarantorEmployerOrganizationName()
        {
            return GetExtendedOrganization(51);
        }

        public override string GetHandicap()
        {
            return GetField(52);
        }

        public override string GetJobStatus()
        {
            return GetField(53);
        }

        public override string GetGuarantorFinancialClass()
        {
            return GetField(54);
        }

        public override string GetGuarantorRace()
        {
            return GetField(55);
        }
    }
}
