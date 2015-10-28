using HL7MessagePaser.Segments.Abstracts;

namespace HL7MessagePaser.Segments.Factories
{
    [HL7SegmentFactory("Generic23HealthCare")]
    [HL7SegmentFactory("Unknown")]
    public class GenericV23HealthcareSegmentFactory : SegmentFactory
    {
        public GenericV23HealthcareSegmentFactory()
        {
            
        }

        public GenericV23HealthcareSegmentFactory(SegmentDelimiters delimiters)
            : base(delimiters)
        {
            
        }

        public override DG1 CreateDG1Instance(string segmentFromMessage)
        {
            return new V23.Generic.DG1(segmentFromMessage, _delimiters);
        }

        public override EVN CreateEVNInstance(string segmentFromMessage)
        {
            return new V23.Generic.EVN(segmentFromMessage, _delimiters);
        }

        public override GT1 CreateGT1Instance(string segmentFromMessage)
        {
            return new V23.Generic.GT1(segmentFromMessage, _delimiters);
        }

        public override IN1 CreateIN1Instance(string segmentFromMessage)
        {
            return new V23.Generic.IN1(segmentFromMessage, _delimiters);
        }

        public override IN2 CreateIN2Instance(string segmentFromMessage)
        {
            return new V23.Generic.IN2(segmentFromMessage, _delimiters);
        }

        public override MSH CreateMSHInstance(string segmentFromMessage)
        {
            return new V23.Generic.MSH(segmentFromMessage);
        }

        public override NK1 CreateNK1Instance(string segmentFromMessage)
        {
            return new V23.Generic.NK1(segmentFromMessage, _delimiters);
        }

        public override PID CreatePIDInstance(string segmentFromMessage)
        {
            return new V23.Generic.PID(segmentFromMessage, _delimiters);
        }

        public override PV1 CreatePV1Instance(string segmentFromMessage)
        {
            return new V23.Generic.PV1(segmentFromMessage, _delimiters);
        }
    }
}
