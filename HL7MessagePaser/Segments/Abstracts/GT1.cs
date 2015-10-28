using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Guarantor segment
    /// </summary>
    public abstract class GT1 : SegmentV23
    {
        protected GT1(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.GT1;
        }

        public abstract int GetSetId();
        public abstract ExtendedCompositeIdWithCheckDigit GetGuarantorNumber();
        public abstract ExtendedPersonName GetGuarantorName();
        public abstract ExtendedPersonName GetGuarantorSpouseName();
        public abstract ExtendedAddress GetGuarantorAddress();
        public abstract ExtendedPhoneNumber GetGuarantorHomePhoneNumber();
        public abstract ExtendedPhoneNumber GetGuarantorBusinessPhoneNumber();
        public abstract DateTime? GetGuarantorDateOfBirth();
        public abstract string GetGuarantorSex();
        public abstract string GetGuarantorType();
        public abstract string GetGuarantorRelationship();
        public abstract string GetGuarantorSSN();
        public abstract DateTime? GetGuarantorBeginDate();
        public abstract DateTime? GetGuarantorEndDate();
        public abstract int GetGuarantorPriority();
        public abstract ExtendedPersonName GetGuarantorEmployerName();
        public abstract ExtendedAddress GetGuarantorEmployerAddress();
        public abstract ExtendedPhoneNumber GetGuarantorEmployerPhoneNumber();
        public abstract ExtendedCompositeIdWithCheckDigit GetGuarantorEmployeeIDNumber();
        public abstract string GetGuarantorEmploymentStatus();
        public abstract ExtendedOrganization GetGuarantorOrganizationName();
        public abstract string GetGuarantorBillingHoldFlag();
        public abstract string GetGuarantorCreditRatingCode();
        public abstract DateTime? GetGuarantorDeathDateTime();
        public abstract string GetGuarantorDeathFlag();
        public abstract string GetGuarantorChargeAdjustmentCode();
        public abstract string GetGuarantorHouseholdAnnualIncome();
        public abstract int GetGuarantorHouseholdSize();
        public abstract ExtendedCompositeIdWithCheckDigit GetGuarantorEmployerIDNumber();
        public abstract string GetGuarantorMaritalStatusCode();
        public abstract DateTime? GetGuarantorHireEffectiveDate();
        public abstract DateTime? GetEmploymentStopDate();
        public abstract string GetLivingDependency();
        public abstract string GetAmbulatoryStatus();
        public abstract string GetCitizenship();
        public abstract string GetPrimaryLanguage();
        public abstract string GetLivingArrangement();
        public abstract string GetPublicityIndicator();
        public abstract string GetProtectionIndicator();
        public abstract string GetStudentIndicator();
        public abstract string GetReligion();
        public abstract ExtendedPersonName GetMothersMaidenName();
        public abstract string GetNationality();
        public abstract string GetEthnicGroup();
        public abstract ExtendedPersonName GetContactPersonName();
        public abstract ExtendedPhoneNumber GetContactPersonPhoneNumber();
        public abstract string GetContactReason();
        public abstract string GetContactRelationship();
        public abstract string GetJobTitle();
        public abstract string GetJobCodeClass();
        public abstract ExtendedOrganization GetGuarantorEmployerOrganizationName();
        public abstract string GetHandicap();
        public abstract string GetJobStatus();
        public abstract string GetGuarantorFinancialClass();
        public abstract string GetGuarantorRace();
    }
}
