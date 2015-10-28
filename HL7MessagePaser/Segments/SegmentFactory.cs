using HL7MessagePaser.Enums;
using HL7MessagePaser.Segments.Abstracts;

namespace HL7MessagePaser.Segments
{
    public abstract class SegmentFactory
    {
        internal SegmentDelimiters _delimiters;
        public SegmentDelimiters Delimiters
        {
            get { return _delimiters; }
            set { _delimiters = value; }
        }

        protected SegmentFactory()
        {
            _delimiters = new SegmentDelimiters();
        }

        protected SegmentFactory(SegmentDelimiters delimiters)
        {
            _delimiters = delimiters;
        }

        public Segment CreateSegmentInstance(SegmentTypes segmentType, string segmentFromMessage)
        {
            Segment newSegment = null;
            
            switch (segmentType)
            {
                case SegmentTypes.DG1:
                    newSegment = CreateDG1Instance(segmentFromMessage);
                    break;

                case SegmentTypes.EVN:
                    newSegment = CreateEVNInstance(segmentFromMessage);
                    break;

                case SegmentTypes.GT1:
                    newSegment = CreateGT1Instance(segmentFromMessage);
                    break;

                case SegmentTypes.IN1:
                    newSegment = CreateIN1Instance(segmentFromMessage);
                    break;

                case SegmentTypes.IN2:
                    newSegment = CreateIN2Instance(segmentFromMessage);
                    break;

                case SegmentTypes.MSH:
                    newSegment = CreateMSHInstance(segmentFromMessage);
                    break;

                case SegmentTypes.NK1:
                    newSegment = CreateNK1Instance(segmentFromMessage);
                    break;

                case SegmentTypes.PID:
                    newSegment = CreatePIDInstance(segmentFromMessage);
                    break;

                case SegmentTypes.PV1:
                    newSegment = CreatePV1Instance(segmentFromMessage);
                    break;
            }

            return newSegment;
        }

        public abstract DG1 CreateDG1Instance(string segmentFromMessage);
        public abstract EVN CreateEVNInstance(string segmentFromMessage);
        public abstract GT1 CreateGT1Instance(string segmentFromMessage);
        public abstract IN1 CreateIN1Instance(string segmentFromMessage);
        public abstract IN2 CreateIN2Instance(string segmentFromMessage);
        public abstract MSH CreateMSHInstance(string segmentFromMessage);
        public abstract NK1 CreateNK1Instance(string segmentFromMessage);
        public abstract PID CreatePIDInstance(string segmentFromMessage);
        public abstract PV1 CreatePV1Instance(string segmentFromMessage);
    }
}
