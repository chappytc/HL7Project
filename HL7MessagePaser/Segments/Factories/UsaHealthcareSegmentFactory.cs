using HL7MessagePaser.Segments.Abstracts;

namespace HL7MessagePaser.Segments.Factories
{
    [HL7SegmentFactory("USAHealthCare")]
    public class UsaHealthcareSegmentFactory : SegmentFactory
    {
        public UsaHealthcareSegmentFactory()
        {
            
        }

        public UsaHealthcareSegmentFactory(SegmentDelimiters delimiters) 
            : base(delimiters)
        {
            
        }

        public override DG1 CreateDG1Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.DG1(segmentFromMessage, _delimiters);
        }

        public override EVN CreateEVNInstance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.EVN(segmentFromMessage, _delimiters);
        }

        public override GT1 CreateGT1Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.GT1(segmentFromMessage, _delimiters);
        }

        public override IN1 CreateIN1Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.IN1(segmentFromMessage, _delimiters);
        }

        public override IN2 CreateIN2Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.IN2(segmentFromMessage, _delimiters);
        }

        public override MSH CreateMSHInstance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.MSH(segmentFromMessage);
        }

        public override NK1 CreateNK1Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.NK1(segmentFromMessage, _delimiters);
        }

        public override PID CreatePIDInstance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.PID(segmentFromMessage, _delimiters);
        }

        public override PV1 CreatePV1Instance(string segmentFromMessage)
        {
            return new V23.USAHealthCare.PV1(segmentFromMessage, _delimiters);
        }
    }
}
