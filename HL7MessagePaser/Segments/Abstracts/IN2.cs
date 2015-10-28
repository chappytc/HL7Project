using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    public abstract class IN2 : SegmentV23
    {
        protected IN2(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.IN2;
        }

        public abstract ExtendedCompositeIdWithCheckDigit GetInsuredsEmployeeID();
        public abstract string GetInsuredsSocialSecurityNumber();
        public abstract ExtendedCompositeIdAndName GetInsuredsEmployerName();
        public abstract string GetEmployerInformationData();
        public abstract string GetMailClaimParty();
        public abstract string GetMedicareHealthInsuranceCardNumber();
        public abstract ExtendedPersonName GetMedicaidCaseName();
        public abstract string GetMedicaidCaseNumber();
        public abstract ExtendedPersonName GetChampusSponsorName();
        public abstract string GetChampusIDNumber();
        public abstract CodedElement GetDependentOfChampusRecipient();
        public abstract string GetChampusOrganization();
        public abstract string GetChampusStation();
        public abstract string GetChampusService();
        public abstract string GetChampusRankGrade();
        public abstract string GetChampusStatus();
        public abstract DateTime? GetChampusRetireDate();
        public abstract string GetChampusNonAvailableCertOnFile();
        public abstract string GetBabyCoverage();
        public abstract string GetCombineBabyBill();
        public abstract string GetBloodDeductible();
        public abstract ExtendedPersonName GetSpecialCoverageApprovalName();
        public abstract string GetSpecialCoverageApprovalTitle();
        public abstract string GetNonCoveredInsuranceCode();
        public abstract ExtendedCompositeIdWithCheckDigit GetPayorID();
        public abstract ExtendedCompositeIdWithCheckDigit GetPayorSubscriberID();
        public abstract string GetEligibilitySource();
        public abstract string GetRoomCoverageTypeAmount();
        public abstract string GetPolicyTypeAmount();
        public abstract string GetDailyDeductible();
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
        public abstract string GetMaritalStatus();
        public abstract DateTime? GetInsuredsEmploymentStartDate();
        public abstract DateTime? GetInsuredsEmploymentStopDate();
        public abstract string GetJobTitle();
        public abstract JobCodeClass GetJobCodeClass();
        public abstract string GetJobStatus();
        public abstract ExtendedPersonName GetEmployerContactPersonName();
        public abstract ExtendedPhoneNumber GetEmployerContactPersonPhoneNumber();
        public abstract string GetEmployerContactReason();
        public abstract ExtendedPersonName GetInsuredsContactPersonsName();
        public abstract ExtendedPhoneNumber GetInsuredsContactPersonTelephoneNumber();
        public abstract string GetInsuredsContactPersonReason();
        public abstract DateTime? GetRelationshipToThePatientStartDate();
        public abstract DateTime? GetRelationshipToThePatientStopDate();
        public abstract string GetInsuranceCompanyContactReason();
        public abstract ExtendedPhoneNumber GetInsuranceCompanyContactPhoneNumber();
        public abstract string GetPolicyScope();
        public abstract string GetPolicySource();
        public abstract ExtendedCompositeIdWithCheckDigit GetPatientMemberNumber();
        public abstract string GetGuarantorsRelationshipToInsured();
        public abstract ExtendedPhoneNumber GetInsuredsHomeTelephoneNumber();
        public abstract ExtendedPhoneNumber GetInsuredsEmployerTelephoneNumber();
        public abstract CodedElement GetMilitaryHandicappedProgram();
        public abstract string GetSuspendFlag();
        public abstract string GetCopayLimitFlag();
        public abstract string GetStoplossLimitFlag();
        public abstract ExtendedOrganization GetInsuredOrganizationNameAndID();
        public abstract ExtendedOrganization GetInsuredEmployerOrganizationNameAndID();
        public abstract string GetRace();
        public abstract CodedElement GetHCFAPatientRelationshipToInsured();
    }
}
