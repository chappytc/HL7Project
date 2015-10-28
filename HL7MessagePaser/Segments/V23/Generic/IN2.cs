using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class IN2 : Abstracts.IN2
    {
        public IN2(string mshSegment)
            : base(mshSegment)
        {

        }

        public IN2(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }

        public override ExtendedCompositeIdWithCheckDigit GetInsuredsEmployeeID()
        {
            return GetExtendedCompositeIdWithCheckDigit(1);
        }

        public override string GetInsuredsSocialSecurityNumber()
        {
            return GetField(2);
        }

        public override ExtendedCompositeIdAndName GetInsuredsEmployerName()
        {
            return GetExtendedCompositeIdAndName(3);
        }

        public override string GetEmployerInformationData()
        {
            return GetField(4);
        }

        public override string GetMailClaimParty()
        {
            return GetField(5);
        }

        public override string GetMedicareHealthInsuranceCardNumber()
        {
            return GetField(6);
        }

        public override ExtendedPersonName GetMedicaidCaseName()
        {
            return GetExtendedPersonName(7);
        }

        public override string GetMedicaidCaseNumber()
        {
            return GetField(8);
        }

        public override ExtendedPersonName GetChampusSponsorName()
        {
            return GetExtendedPersonName(9);
        }

        public override string GetChampusIDNumber()
        {
            return GetField(10);
        }

        public override CodedElement GetDependentOfChampusRecipient()
        {
            return GetCodedElement(11);
        }

        public override string GetChampusOrganization()
        {
            return GetField(12);
        }

        public override string GetChampusStation()
        {
            return GetField(13);
        }

        public override string GetChampusService()
        {
            return GetField(14);
        }

        public override string GetChampusRankGrade()
        {
            return GetField(15);
        }

        public override string GetChampusStatus()
        {
            return GetField(16);
        }

        public override DateTime? GetChampusRetireDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(17), "yyyyMMddHHmmss");
        }

        public override string GetChampusNonAvailableCertOnFile()
        {
            return GetField(18);
        }

        public override string GetBabyCoverage()
        {
            return GetField(19);
        }

        public override string GetCombineBabyBill()
        {
            return GetField(20);
        }

        public override string GetBloodDeductible()
        {
            return GetField(21);
        }

        public override ExtendedPersonName GetSpecialCoverageApprovalName()
        {
            return GetExtendedPersonName(22);
        }

        public override string GetSpecialCoverageApprovalTitle()
        {
            return GetField(23);
        }

        public override string GetNonCoveredInsuranceCode()
        {
            return GetField(24);
        }

        public override ExtendedCompositeIdWithCheckDigit GetPayorID()
        {
            return GetExtendedCompositeIdWithCheckDigit(25);
        }

        public override ExtendedCompositeIdWithCheckDigit GetPayorSubscriberID()
        {
            return GetExtendedCompositeIdWithCheckDigit(26);
        }

        public override string GetEligibilitySource()
        {
            return GetField(27);
        }

        public override string GetRoomCoverageTypeAmount()
        {
            return GetField(28);
        }

        public override string GetPolicyTypeAmount()
        {
            return GetField(29);
        }

        public override string GetDailyDeductible()
        {
            return GetField(30);
        }

        public override string GetLivingDependency()
        {
            return GetField(31);
        }

        public override string GetAmbulatoryStatus()
        {
            return GetField(32);
        }

        public override string GetCitizenship()
        {
            return GetField(33);
        }

        public override CodedElement GetPrimaryLanguage()
        {
            return GetCodedElement(34);
        }

        public override string GetLivingArrangement()
        {
            return GetField(35);
        }

        public override string GetPublicityIndicator()
        {
            return GetField(36);
        }

        public override string GetProtectionIndicator()
        {
            return GetField(37);
        }

        public override string GetStudentIndicator()
        {
            return GetField(38);
        }

        public override string GetReligion()
        {
            return GetField(39);
        }

        public override ExtendedPersonName GetMothersMaidenName()
        {
            return GetExtendedPersonName(40);
        }

        public override CodedElement GetNationality()
        {
            return GetCodedElement(41);
        }

        public override string GetEthnicGroup()
        {
            return GetField(42);
        }

        public override string GetMaritalStatus()
        {
            return GetField(43);
        }

        public override DateTime? GetInsuredsEmploymentStartDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(44), "yyyyMMddHHmmss");
        }

        public override DateTime? GetInsuredsEmploymentStopDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(45), "yyyyMMddHHmmss");
        }

        public override string GetJobTitle()
        {
            return GetField(46);
        }

        public override JobCodeClass GetJobCodeClass()
        {
            return GetJobCodeClass(47);
        }

        public override string GetJobStatus()
        {
            return GetField(48);
        }

        public override ExtendedPersonName GetEmployerContactPersonName()
        {
            return GetExtendedPersonName(49);
        }

        public override ExtendedPhoneNumber GetEmployerContactPersonPhoneNumber()
        {
            return GetExtendedPhoneNumber(50);
        }

        public override string GetEmployerContactReason()
        {
            return GetField(51);
        }

        public override ExtendedPersonName GetInsuredsContactPersonsName()
        {
            return GetExtendedPersonName(52);
        }

        public override ExtendedPhoneNumber GetInsuredsContactPersonTelephoneNumber()
        {
            return GetExtendedPhoneNumber(53);
        }

        public override string GetInsuredsContactPersonReason()
        {
            return GetField(54);
        }

        public override DateTime? GetRelationshipToThePatientStartDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(55), "yyyyMMddHHmmss");
        }

        public override DateTime? GetRelationshipToThePatientStopDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(56), "yyyyMMddHHmmss");
        }

        public override string GetInsuranceCompanyContactReason()
        {
            return GetField(57);
        }

        public override ExtendedPhoneNumber GetInsuranceCompanyContactPhoneNumber()
        {
            return GetExtendedPhoneNumber(58);
        }

        public override string GetPolicyScope()
        {
            return GetField(59);
        }

        public override string GetPolicySource()
        {
            return GetField(60);
        }

        public override ExtendedCompositeIdWithCheckDigit GetPatientMemberNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(61);
        }

        public override string GetGuarantorsRelationshipToInsured()
        {
            return GetField(62);
        }

        public override ExtendedPhoneNumber GetInsuredsHomeTelephoneNumber()
        {
            return GetExtendedPhoneNumber(63);
        }

        public override ExtendedPhoneNumber GetInsuredsEmployerTelephoneNumber()
        {
            return GetExtendedPhoneNumber(64);
        }

        public override CodedElement GetMilitaryHandicappedProgram()
        {
            return GetCodedElement(65);
        }

        public override string GetSuspendFlag()
        {
            return GetField(66);
        }

        public override string GetCopayLimitFlag()
        {
            return GetField(67);
        }

        public override string GetStoplossLimitFlag()
        {
            return GetField(68);
        }

        public override ExtendedOrganization GetInsuredOrganizationNameAndID()
        {
            return GetExtendedOrganization(69);
        }

        public override ExtendedOrganization GetInsuredEmployerOrganizationNameAndID()
        {
            return GetExtendedOrganization(70);
        }

        public override string GetRace()
        {
            return GetField(71);
        }

        public override CodedElement GetHCFAPatientRelationshipToInsured()
        {
            return GetCodedElement(72);
        }
    }
}
