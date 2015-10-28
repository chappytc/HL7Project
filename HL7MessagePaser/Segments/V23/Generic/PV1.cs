using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class PV1 : Abstracts.PV1
    {
        public PV1(string mshSegment)
            : base(mshSegment)
        {

        }

        public PV1(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }

        public override int GetSetID()
        {
            int parsedInt;
            int.TryParse(GetField(1), out parsedInt);

            return parsedInt;
        }

        public override string GetPatientClass()
        {
            return GetField(2);
        }

        public override PersonLocation GetAssignedPatientLocation()
        {
            return GetPersonLocation(3);
        }

        public override string GetAdmissionType()
        {
            return GetField(4);
        }

        public override ExtendedCompositeIdWithCheckDigit GetPreadmitNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(5);
        }

        public override PersonLocation GetPriorPatientLocation()
        {
            return GetPersonLocation(6);
        }

        public override ExtendedCompositeIdAndName GetAttendingDoctor()
        {
            return GetExtendedCompositeIdAndName(7);
        }

        public override ExtendedCompositeIdAndName GetReferringDoctor()
        {
            return GetExtendedCompositeIdAndName(8);
        }

        public override ExtendedCompositeIdAndName GetConsultingDoctor()
        {
            return GetExtendedCompositeIdAndName(9);
        }

        public override string GetHospitalService()
        {
            return GetField(10);
        }

        public override PersonLocation GetTemporaryLocation()
        {
            return GetPersonLocation(11);
        }

        public override string GetPreadmitTestIndicator()
        {
            return GetField(12);
        }

        public override string GetReadmissionIndicator()
        {
            return GetField(13);
        }

        public override string GetAdmitSource()
        {
            return GetField(14);
        }

        public override string GetAmbulatoryStatus()
        {
            return GetField(15);
        }

        public override string GetVIPIndicator()
        {
            return GetField(16);
        }

        public override ExtendedCompositeIdAndName GetAdmittingDoctor()
        {
            return GetExtendedCompositeIdAndName(17);
        }

        public override string GetPatientType()
        {
            return GetField(18);
        }

        public override ExtendedCompositeIdWithCheckDigit GetVisitNumber()
        {
            return GetExtendedCompositeIdWithCheckDigit(19);
        }

        public override string GetFinancialClass()
        {
            return GetField(20);
        }

        public override string GetChargePriceIndicator()
        {
            return GetField(21);
        }

        public override string GetCourtesyCode()
        {
            return GetField(22);
        }

        public override string GetCreditRating()
        {
            return GetField(23);
        }

        public override string GetContractCode()
        {
            return GetField(24);
        }

        public override DateTime? GetContractEffectiveDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(25), "yyyyMMddHHmmss");
        }

        public override double GetContractAmount()
        {
            double parsedDouble;
            double.TryParse(GetField(26), out parsedDouble);

            return parsedDouble;
        }

        public override double GetContractPeriod()
        {
            double parsedDouble;
            double.TryParse(GetField(27), out parsedDouble);

            return parsedDouble;
        }

        public override string GetInterestCode()
        {
            return GetField(28);
        }

        public override string GetTransferToBadDebtCode()
        {
            return GetField(29);
        }

        public override DateTime? GetTransferToBadDebtDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(30), "yyyyMMddHHmmss");
        }

        public override string GetBadDebtAgencyCode()
        {
            return GetField(31);
        }

        public override double GetBadDebtTransferAmount()
        {
            double parsedDouble;
            double.TryParse(GetField(32), out parsedDouble);

            return parsedDouble;
        }

        public override double GetBadDebtRecoveryAmount()
        {
            double parsedDouble;
            double.TryParse(GetField(33), out parsedDouble);

            return parsedDouble;
        }

        public override string GetDeleteAccountIndicator()
        {
            return GetField(34);
        }

        public override DateTime? GetDeleteAccountDate()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(35), "yyyyMMddHHmmss");
        }

        public override string GetDischargeDisposition()
        {
            return GetField(36);
        }

        public override string GetDischargedToLocation()
        {
            return GetField(37);
        }

        public override string GetDietType()
        {
            return GetField(38);
        }

        public override string GetServicingFacility()
        {
            return GetField(39);
        }

        public override string GetBedStatus()
        {
            return GetField(40);
        }

        public override string GetAccountStatus()
        {
            return GetField(41);
        }

        public override PersonLocation GetPendingLocation()
        {
            return GetPersonLocation(42);
        }

        public override PersonLocation GetPriorTemporaryLocation()
        {
            return GetPersonLocation(43);
        }

        public override DateTime? GetAdmitDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(44), "yyyyMMddHHmmss");
        }

        public override DateTime? GetDischargeDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(45), "yyyyMMddHHmmss");
        }

        public override double GetCurrentPatientBalance()
        {
            double parsedDouble;
            double.TryParse(GetField(46), out parsedDouble);

            return parsedDouble;
        }

        public override double GetTotalCharges()
        {
            double parsedDouble;
            double.TryParse(GetField(47), out parsedDouble);

            return parsedDouble;
        }

        public override double GetTotalAdjustments()
        {
            double parsedDouble;
            double.TryParse(GetField(48), out parsedDouble);

            return parsedDouble;
        }

        public override double GetTotalPayments()
        {
            double parsedDouble;
            double.TryParse(GetField(49), out parsedDouble);

            return parsedDouble;
        }

        public override ExtendedCompositeIdWithCheckDigit GetAlternateVisitId()
        {
            return GetExtendedCompositeIdWithCheckDigit(50);
        }

        public override string GetVisitIndicator()
        {
            return GetField(51);
        }

        public override ExtendedCompositeIdAndName GetOtherHealthcareProvider()
        {
            return GetExtendedCompositeIdAndName(52);
        }
    }
}
