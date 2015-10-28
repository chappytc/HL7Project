using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Patient visit segment
    /// </summary>
    public abstract class PV1 : SegmentV23
    {
        protected PV1(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.PV1;
        }

        public abstract int GetSetID();
        public abstract string GetPatientClass();
        public abstract PersonLocation GetAssignedPatientLocation();
        public abstract string GetAdmissionType();
        public abstract ExtendedCompositeIdWithCheckDigit GetPreadmitNumber();
        public abstract PersonLocation GetPriorPatientLocation();
        public abstract ExtendedCompositeIdAndName GetAttendingDoctor();
        public abstract ExtendedCompositeIdAndName GetReferringDoctor();
        public abstract ExtendedCompositeIdAndName GetConsultingDoctor();
        public abstract string GetHospitalService();
        public abstract PersonLocation GetTemporaryLocation();
        public abstract string GetPreadmitTestIndicator();
        public abstract string GetReadmissionIndicator();
        public abstract string GetAdmitSource();
        public abstract string GetAmbulatoryStatus();
        public abstract string GetVIPIndicator();
        public abstract ExtendedCompositeIdAndName GetAdmittingDoctor();
        public abstract string GetPatientType();
        public abstract ExtendedCompositeIdWithCheckDigit GetVisitNumber();
        public abstract string GetFinancialClass();
        public abstract string GetChargePriceIndicator();
        public abstract string GetCourtesyCode();
        public abstract string GetCreditRating();
        public abstract string GetContractCode();
        public abstract DateTime? GetContractEffectiveDate();
        public abstract double GetContractAmount();
        public abstract double GetContractPeriod();
        public abstract string GetInterestCode();
        public abstract string GetTransferToBadDebtCode();
        public abstract DateTime? GetTransferToBadDebtDate();
        public abstract string GetBadDebtAgencyCode();
        public abstract double GetBadDebtTransferAmount();
        public abstract double GetBadDebtRecoveryAmount();
        public abstract string GetDeleteAccountIndicator();
        public abstract DateTime? GetDeleteAccountDate();
        public abstract string GetDischargeDisposition();
        public abstract string GetDischargedToLocation();
        public abstract string GetDietType();
        public abstract string GetServicingFacility();
        public abstract string GetBedStatus();
        public abstract string GetAccountStatus();
        public abstract PersonLocation GetPendingLocation();
        public abstract PersonLocation GetPriorTemporaryLocation();
        public abstract DateTime? GetAdmitDateTime();
        public abstract DateTime? GetDischargeDateTime();
        public abstract double GetCurrentPatientBalance();
        public abstract double GetTotalCharges();
        public abstract double GetTotalAdjustments();
        public abstract double GetTotalPayments();
        public abstract ExtendedCompositeIdWithCheckDigit GetAlternateVisitId();
        public abstract string GetVisitIndicator();
        public abstract ExtendedCompositeIdAndName GetOtherHealthcareProvider();
    }
}
