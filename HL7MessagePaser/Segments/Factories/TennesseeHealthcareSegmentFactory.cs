using HL7MessagePaser.Segments.Abstracts;

namespace HL7MessagePaser.Segments.Factories
{
    [HL7SegmentFactory("TNHealthCare")]
    public class TennesseeHealthcareSegmentFactory : SegmentFactory
    {
        public TennesseeHealthcareSegmentFactory()
        {
            
        }

        public TennesseeHealthcareSegmentFactory(SegmentDelimiters delimiters)
            : base(delimiters)
        {
            
        }

        public override DG1 CreateDG1Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.DG1(segmentFromMessage, _delimiters);
        }

        public override EVN CreateEVNInstance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.EVN(segmentFromMessage, _delimiters);
        }

        public override GT1 CreateGT1Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.GT1(segmentFromMessage, _delimiters);
        }

        public override IN1 CreateIN1Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.IN1(segmentFromMessage, _delimiters);
        }

        public override IN2 CreateIN2Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.IN2(segmentFromMessage, _delimiters);
        }

        public override MSH CreateMSHInstance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.MSH(segmentFromMessage);
        }

        public override NK1 CreateNK1Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.NK1(segmentFromMessage, _delimiters);
        }

        public override PID CreatePIDInstance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.PID(segmentFromMessage, _delimiters);
        }

        public override PV1 CreatePV1Instance(string segmentFromMessage)
        {
            return new V23.TennesseeHealthCare.PV1(segmentFromMessage, _delimiters);
        }
    }
}
