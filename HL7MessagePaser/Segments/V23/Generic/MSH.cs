using System;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Segments.V23.Generic
{
    public class MSH : Abstracts.MSH
    {
        public MSH(string mshSegment)
            : base(mshSegment)
        {
            _delimiters.FieldSeparator = GetFieldSeparator();
            _delimiters.ComponentSeparator = GetComponentSeparator();
            _delimiters.FieldRepeatSeparator = GetFieldRepeatSeparator();
            _delimiters.EscapeCharacter = GetEscapeCharacter();
            _delimiters.SubComponentSeparator = GetSubComponentSeparator();
        }

        public override char GetFieldSeparator()
        {
            return _segment.Substring(3, 1).ToCharArray()[0];
        }

        public override char GetComponentSeparator()
        {
            return _segment.Substring(4, 1).ToCharArray()[0];
        }

        public override char GetFieldRepeatSeparator()
        {
            return _segment.Substring(5, 1).ToCharArray()[0];
        }

        public override char GetEscapeCharacter()
        {
            return _segment.Substring(6, 1).ToCharArray()[0];
        }

        public override char GetSubComponentSeparator()
        {
            return _segment.Substring(7, 1).ToCharArray()[0];
        }

        public override string GetSendingApplication()
        {
            return GetField(2);
        }

        public override string GetSendingFacility()
        {
            return GetField(3);
        }

        public override string GetReceivingApplication()
        {
            return GetField(4);
        }

        public override string GetReceivingFacility()
        {
            return GetField(5);
        }

        public override DateTime? GetMessageDateTime()
        {
            return Utils.DateTimeFromNonStandardDateTimeFormat(GetField(6), "yyyyMMMddHHmmss");
        }

        public override string GetSecurity()
        {
            return GetField(7);
        }

        public override MessageType GetMessageType()
        {
            string msgType = GetField(8);
            return new MessageType(GetComponent(msgType, 0), GetComponent(msgType, 1));
        }

        public override string GetMessageControlId()
        {
            return GetField(9);
        }

        public override string GetProcessingId()
        {
            return GetField(10);
        }

        public override string GetVersionId()
        {
            return GetField(11);
        }

        public override int GetSequenceNumber()
        {
            int parsedSequenceNumber;
            if (!Int32.TryParse(GetField(12), out parsedSequenceNumber))
                parsedSequenceNumber = -1;
            return parsedSequenceNumber;
        }

        public override string GetContinuationPointer()
        {
            return GetField(13);
        }

        public override string GetAcceptAcknowledgementType()
        {
            return GetField(14);
        }

        public override string GetApplicationAcknowledgementType()
        {
            return GetField(15);
        }

        public override string GetCountryCode()
        {
            return GetField(16);
        }

        public override string GetCharacterSet()
        {
            return GetField(17);
        }

        public override string GetPrincipalLanguage()
        {
            return GetField(18);
        }
    }
}
