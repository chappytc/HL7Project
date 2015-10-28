using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class DG1 : Abstracts.DG1
    {
        public DG1(string mshSegment)
            : base(mshSegment)
        {

        }

        public DG1(string mshSegment,SegmentDelimiters delimiters)
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

        public override string GetDiagnosisCodingMethod()
        {
            return GetField(2);
        }

        public override CodedElement GetDiagnosisCode()
        {
            return GetCodedElement(3);
        }

        public override string GetDiagnosisDescription()
        {
            return GetField(4);
        }

        public override DateTime? GetDiagnosisDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(5), "yyyyMMddHHmmss");
        }

        public override string GetDiagnosisType()
        {
            return GetField(6);
        }

        public override CodedElement GetMajorDiagnosticCategory()
        {
            return GetCodedElement(7);
        }

        public override string GetDiagnosticRelatedGroup()
        {
            return GetField(8);
        }

        public override string GetDrgApprovalIndicator()
        {
            return GetField(9);
        }

        public override string GetDrgGrouperReviewCode()
        {
            return GetField(10);
        }

        public override CodedElement GetOutlierType()
        {
            return GetCodedElement(11);
        }

        public override int GetOutlierDays()
        {
            int parsedInt;
            int.TryParse(GetField(12), out parsedInt);

            return parsedInt;
        }

        public override double GetOutlierCost()
        {
            double parsedInt;
            double.TryParse(GetField(13), out parsedInt);

            return parsedInt;
        }

        public override string GetGrouperVersionAndType()
        {
            return GetField(14);
        }

        public override int GetDiagnosisPriority()
        {
            int parsedInt;
            int.TryParse(GetField(15), out parsedInt);

            return parsedInt;
        }

        public override string GetDiagnosingClinician()
        {
            return GetField(16);
        }

        public override string GetDiagnosisClassification()
        {
            return GetField(17);
        }

        public override string GetConfidentialIndicator()
        {
            return GetField(18);
        }

        public override DateTime? GetAttestationDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(19), "yyyyMMddHHmmss");
        }
    }
}
