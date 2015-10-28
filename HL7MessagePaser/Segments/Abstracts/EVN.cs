using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    public abstract class EVN : SegmentV23
    {
        protected EVN(string segment) : base(segment)
        {
            _segmentType = SegmentTypes.EVN;
        }
        
        public abstract string GetEventTypeCode();
        public abstract DateTime? GetRecordedDateTime();
        public abstract DateTime? GetDateTimePlannedEvent();
        public abstract string GetEventReasonCode();
        public abstract ExtendedCompositeIdAndName GetOperatorId();
        public abstract DateTime? GetEventOccurred();
    }
}
