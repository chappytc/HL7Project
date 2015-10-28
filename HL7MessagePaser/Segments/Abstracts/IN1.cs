using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    public abstract class IN1 : SegmentV23
    {
        protected IN1(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.IN1;
        }

        public abstract int GetSetId();
        public abstract CodedElement GetInsurancePlanId();
        public abstract ExtendedCompositeIdWithCheckDigit GetInsuranceCompanyId();
        public abstract ExtendedOrganization GetInsuranceCompanyName();
        public abstract ExtendedAddress GetInsuranceCompanyAddress();
        public abstract ExtendedPersonName GetInsuranceCompanyContactPerson();
        public abstract ExtendedPhoneNumber GetInsuranceCompanyPhoneNumber();
        public abstract string GetGroupNumber();
        public abstract ExtendedOrganization GetGroupName();
        public abstract ExtendedCompositeIdWithCheckDigit GetInsuredsGroupEmployeeId();
        public abstract ExtendedOrganization GetInsuredsGroupEmployeeName();
        public abstract DateTime? GetPlanEffectiveDate();
        public abstract DateTime? GetPlanExpirationDate();
        public abstract string GetAuthorizationInformation();
        public abstract string GetPlanType();
        public abstract ExtendedPersonName GetNameOfInsured();
        public abstract string GetInsuredsRelationshipToPatient();
        public abstract DateTime? GetInsuredsDateOfBirth();
        public abstract ExtendedAddress GetInsuredsAddress();
        public abstract string GetAssignmentOfBenefits();
        public abstract string GetCoordinationOfBenefits();
        public abstract string GetCoordinationOfBenefitsPriority();
        public abstract string GetNoticeOfAdmissionFlag();
        public abstract DateTime? GetNoticeOfAdmissionDate();
        public abstract string GetReportOfEligibilityFlag();
        public abstract DateTime?GetReportOfEligibilityDate();
        public abstract string GetReleaseInformationCode();
        public abstract string GetPAC();
        public abstract DateTime? GetVerificationDateTime();
        public abstract ExtendedCompositeIdAndName GetVerificationBy();
        public abstract string GetTypeOfAgreementCode();
        public abstract string GetBillingStatus();
        public abstract int GetLifetimeReserveDays();
        public abstract int GetDelayBeforeLRDay();
        public abstract string GetCompanyPlanCode();
        public abstract string GetPolicyNumber();
        public abstract string GetPolicyDeductible();
        public abstract string GetPolicyLimitAmount();
        public abstract int GetPolicyLimitDays();
        public abstract string GetRoomRateSemiPrivate();
        public abstract string GetRoomRatePrivate();
        public abstract CodedElement GetInsuredsEmploymentStatus();
        public abstract string GetInsuredsSex();
        public abstract ExtendedAddress GetInsuredsEmployerAddress();
        public abstract string GetVerificationStatus();
        public abstract string GetPriorInsurancePlanID();
        public abstract string GetCoverageType();
        public abstract string GetHandicap();
        public abstract CompositeIdWithCheckDigit GetInsuredsIdNumber();
    }
}
