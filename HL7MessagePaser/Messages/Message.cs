using System;
using System.Collections.Generic;
using HL7MessagePaser.Enums;
using HL7MessagePaser.Segments;
using HL7MessagePaser.Segments.Abstracts;
using HL7MessagePaser.Types;

namespace HL7MessagePaser.Messages
{
    public abstract class Message
    {
        internal string _message;
        internal SegmentDelimiters _delimiters;
        internal DateTime? _messageDate = null;
        internal MessageType _type = null;
        internal string _versioinId = null;
        internal string _processingId = null;
        internal string _messageControlId = null;
        internal List<Segment> _segments = null;
        internal DriverTypes _driverType = DriverTypes.Unknown;

        public string MessageContents
        {
            get { return _message; }
            set { _message = value; }
        }

        public SegmentDelimiters Delimiters
        {
            get { return _delimiters; }
            set { _delimiters = value; }
        }
        
        public DateTime? MessageDate
        {
            get { return _messageDate; }
        }
        
        public MessageType Type
        {
            get { return _type; }
        }
       
        public string VersionId
        {
            get { return _versioinId; }
        }
        
        public string ProcessingId
        {
            get { return _processingId; }
        }
        
        public string MessageControlId
        {
            get { return _messageControlId; }
        }
        
        public List<Segment> Segments
        {
            get { return _segments; }
            set { _segments = value; }
        }

        protected Message(string message)
        {
            _segments = new List<Segment>();
            _delimiters = new SegmentDelimiters();
            _message = message;
        }

        public virtual void SetDriverType(DriverTypes driverType)
        {
            _driverType = driverType;
        }

        public virtual void Parse()
        {
            if (!string.IsNullOrEmpty(_message))
            {
                SegmentFactoryManager segmentBuilder = new SegmentFactoryManager();
                SegmentFactory segmentFactory = segmentBuilder.GetFactory(_driverType);

                List<string> segments = new List<string>(_message.Replace("\r\n", "\r").Split('\r'));

                foreach (string segment in segments)
                {
                    Segment newSegment = segmentFactory.CreateSegmentInstance(
                        ((SegmentTypes)EnumUtils.enumValueOf(segment.Substring(0, 3), typeof(SegmentTypes))),
                        segment);

                    _segments.Add(newSegment);
                }

                if (_segments != null && _segments.Count > 0)
                {
                    MSH msh = (MSH)_segments.Find(s => s.SegmentType == SegmentTypes.MSH);
                    _delimiters.FieldSeparator = msh.GetFieldSeparator();
                    _delimiters.ComponentSeparator = msh.GetComponentSeparator();
                    _delimiters.FieldRepeatSeparator = msh.GetFieldRepeatSeparator();
                    _delimiters.EscapeCharacter = msh.GetEscapeCharacter();
                    _delimiters.SubComponentSeparator = msh.GetSubComponentSeparator();

                    _versioinId = msh.GetVersionId();
                    _messageDate = msh.GetMessageDateTime();
                    _type = msh.GetMessageType();
                    _messageControlId = msh.GetMessageControlId();
                    _processingId = msh.GetProcessingId();
                }
            }            
        }
    }
}
