using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Diagnosis segment
    /// </summary>
    public abstract class DG1 : SegmentV23
    {
        protected DG1(string mshSegment)
            : base(mshSegment)
        {
            _segmentType = SegmentTypes.DG1;
        }

        public abstract int GetSetId();
        public abstract string GetDiagnosisCodingMethod();
        public abstract CodedElement GetDiagnosisCode();
        public abstract string GetDiagnosisDescription();
        public abstract DateTime? GetDiagnosisDateTime();
        public abstract string GetDiagnosisType();
        public abstract CodedElement GetMajorDiagnosticCategory();
        public abstract string GetDiagnosticRelatedGroup();
        public abstract string GetDrgApprovalIndicator();
        public abstract string GetDrgGrouperReviewCode();
        public abstract CodedElement GetOutlierType();
        public abstract int GetOutlierDays();
        public abstract double GetOutlierCost();
        public abstract string GetGrouperVersionAndType();
        public abstract int GetDiagnosisPriority();
        public abstract string GetDiagnosingClinician();
        public abstract string GetDiagnosisClassification();
        public abstract string GetConfidentialIndicator();
        public abstract DateTime? GetAttestationDateTime();
    }
}
