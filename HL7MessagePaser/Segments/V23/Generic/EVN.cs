using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class EVN : Abstracts.EVN
    {
        public EVN(string mshSegment)
            : base(mshSegment)
        {

        }

        public EVN(string mshSegment,SegmentDelimiters delimiters)
            : base(mshSegment)
        {
            _delimiters = delimiters;
        }

        public override string GetEventTypeCode()
        {
            return GetField(1);
        }

        public override DateTime? GetRecordedDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(2), "yyyyMMddHHmmss");
        }

        public override DateTime? GetDateTimePlannedEvent()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(3), "yyyyMMddHHmmss");
        }

        public override string GetEventReasonCode()
        {
            return GetField(4);
        }

        public override ExtendedCompositeIdAndName GetOperatorId()
        {
            return GetExtendedCompositeIdAndName(5);
        }

        public override DateTime? GetEventOccurred()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(6), "yyyyMMddHHmmss");
        }
    }
}
