using System;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.Abstracts
{
    /// <summary>
    /// Message Header
    /// </summary>
    public abstract class MSH : SegmentV23
    {
        protected MSH(string mshSegment)
            : base(mshSegment)
        {            
            _segmentType = SegmentTypes.MSH;
        }

        public abstract char GetFieldSeparator();

        public abstract char GetComponentSeparator();

        public abstract char GetFieldRepeatSeparator();

        public abstract char GetEscapeCharacter();

        public abstract char GetSubComponentSeparator();

        public abstract string GetSendingApplication();

        public abstract string GetSendingFacility();

        public abstract string GetReceivingApplication();

        public abstract string GetReceivingFacility();

        public abstract DateTime? GetMessageDateTime();

        public abstract string GetSecurity();

        public abstract MessageType GetMessageType();

        public abstract string GetMessageControlId();

        public abstract string GetProcessingId();

        public abstract string GetVersionId();

        public abstract int GetSequenceNumber();

        public abstract string GetContinuationPointer();

        public abstract string GetAcceptAcknowledgementType();

        public abstract string GetApplicationAcknowledgementType();

        public abstract string GetCountryCode();

        public abstract string GetCharacterSet();

        public abstract string GetPrincipalLanguage();
    }
}
