using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class IN1 : Abstracts.IN1
    {
        public IN1(string mshSegment)
            : base(mshSegment)
        {

        }

        public IN1(string mshSegment,SegmentDelimiters delimiters)
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

        public override CodedElement GetInsurancePlanId()
        {
            return GetCodedElement(2);
        }

        public override ExtendedCompositeIdWithCheckDigit GetInsuranceCompanyId()
        {
            return GetExtendedCompositeIdWithCheckDigit(3);
        }

        public override ExtendedOrganization GetInsuranceCompanyName()
        {
            return GetExtendedOrganization(4);
        }

        public override ExtendedAddress GetInsuranceCompanyAddress()
        {
            return GetExtendedAddress(5);
        }

        public override ExtendedPersonName GetInsuranceCompanyContactPerson()
        {
            return GetExtendedPersonName(6);
        }

        public override ExtendedPhoneNumber GetInsuranceCompanyPhoneNumber()
        {
            return GetExtendedPhoneNumber(7);
        }

        public override string GetGroupNumber()
        {
            return GetField(8);
        }

        public override ExtendedOrganization GetGroupName()
        {
            return GetExtendedOrganization(9);
        }

        public override ExtendedCompositeIdWithCheckDigit GetInsuredsGroupEmployeeId()
        {
            return GetExtendedCompositeIdWithCheckDigit(10);
        }

        public override ExtendedOrganization GetInsuredsGroupEmployeeName()
        {
            return GetExtendedOrganization(11);
        }

        public override DateTime? GetPlanEffectiveDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(12), "yyyyMMddHHmmss");
        }

        public override DateTime? GetPlanExpirationDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(13), "yyyyMMddHHmmss");
        }

        public override string GetAuthorizationInformation()
        {
            return GetField(14);
        }

        public override string GetPlanType()
        {
            return GetField(15);
        }

        public override ExtendedPersonName GetNameOfInsured()
        {
            return GetExtendedPersonName(16);
        }

        public override string GetInsuredsRelationshipToPatient()
        {
            return GetField(17);
        }

        public override DateTime? GetInsuredsDateOfBirth()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(18), "yyyyMMddHHmmss");
        }

        public override ExtendedAddress GetInsuredsAddress()
        {
            return GetExtendedAddress(19);
        }

        public override string GetAssignmentOfBenefits()
        {
            return GetField(20);
        }

        public override string GetCoordinationOfBenefits()
        {
            return GetField(21);
        }

        public override string GetCoordinationOfBenefitsPriority()
        {
            return GetField(22);
        }

        public override string GetNoticeOfAdmissionFlag()
        {
            return GetField(23);
        }

        public override DateTime? GetNoticeOfAdmissionDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(24), "yyyyMMddHHmmss");
        }

        public override string GetReportOfEligibilityFlag()
        {
            return GetField(25);
        }

        public override DateTime? GetReportOfEligibilityDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(26), "yyyyMMddHHmmss");
        }

        public override string GetReleaseInformationCode()
        {
            return GetField(27);
        }

        public override string GetPAC()
        {
            return GetField(28);
        }

        public override DateTime? GetVerificationDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(29), "yyyyMMddHHmmss");
        }

        public override ExtendedCompositeIdAndName GetVerificationBy()
        {
            return GetExtendedCompositeIdAndName(30);
        }

        public override string GetTypeOfAgreementCode()
        {
            return GetField(31);
        }

        public override string GetBillingStatus()
        {
            return GetField(32);
        }

        public override int GetLifetimeReserveDays()
        {
            int parsedInt;
            int.TryParse(GetField(33), out parsedInt);

            return parsedInt;
        }

        public override int GetDelayBeforeLRDay()
        {
            int parsedInt;
            int.TryParse(GetField(34), out parsedInt);

            return parsedInt;
        }

        public override string GetCompanyPlanCode()
        {
            return GetField(35);
        }

        public override string GetPolicyNumber()
        {
            return GetField(36);
        }

        public override string GetPolicyDeductible()
        {
            return GetField(37);
        }

        public override string GetPolicyLimitAmount()
        {
            return GetField(38);
        }

        public override int GetPolicyLimitDays()
        {
            int parsedInt;
            int.TryParse(GetField(39), out parsedInt);

            return parsedInt;
        }

        public override string GetRoomRateSemiPrivate()
        {
            return GetField(40);
        }

        public override string GetRoomRatePrivate()
        {
            return GetField(41);
        }

        public override CodedElement GetInsuredsEmploymentStatus()
        {
            return GetCodedElement(42);
        }

        public override string GetInsuredsSex()
        {
            return GetField(43);
        }

        public override ExtendedAddress GetInsuredsEmployerAddress()
        {
            return GetExtendedAddress(44);
        }

        public override string GetVerificationStatus()
        {
            return GetField(45);
        }

        public override string GetPriorInsurancePlanID()
        {
            return GetField(46);
        }

        public override string GetCoverageType()
        {
            return GetField(47);
        }

        public override string GetHandicap()
        {
            return GetField(48);
        }

        public override CompositeIdWithCheckDigit GetInsuredsIdNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(49);
        }
    }
}
