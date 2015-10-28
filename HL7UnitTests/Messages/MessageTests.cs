using HL7MessagePaser.Enums;
using HL7MessagePaser.Messages;
using HL7MessagePaser.Segments.Abstracts;
using HL7MessagePaser.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HL7UnitTests.Messages
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void MessageWithNoMshWillReturnNull()
        {
            MessageFactory messageFactory = new MessageFactory();
            Message newMessage = messageFactory.MakeMessage(TestMessages.InvalidMessage_MissingMSH);

            Assert.IsNull(newMessage);
        }

        [TestMethod]
        public void GenericV23AdtA01MessageIsOfTypeAdtA01()
        {
            MessageFactory messageFactory = new MessageFactory();
            Message newMessage = messageFactory.MakeMessage(TestMessages.GenericV23_ADT_A01);

            Assert.AreEqual(EnumUtils.stringValueOf(MessageTypes.ADT_A01), (newMessage.Type.Type + newMessage.Type.TriggerEvent));
        }

        [TestMethod]
        public void TennesseeHealthCareAdtA01MessagePatientIsThomasCChapman()
        {
            MessageFactory messageFactory = new MessageFactory();
            ExtendedPersonName expectedExtendedPersonName = new ExtendedPersonName()
            {
                GivenName = "THOMAS",
                MiddleNameOrInitial = "C",
                FamilyName = "CHAPMAN"
            };
            
            Message newMessage = messageFactory.MakeMessage(TestMessages.TennesseeHealthCare_ADT_A01);
            PID pidSegment = (PID)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PID);
            ExtendedPersonName actualExtendedPersonName = pidSegment.GetPatientName();

            Assert.AreEqual(expectedExtendedPersonName, actualExtendedPersonName);
        }

        [TestMethod]
        public void TennesseeHealthSystemsAdtA01MessagePatientIsDarthAVader()
        {
            MessageFactory messageFactory = new MessageFactory();
            ExtendedPersonName expectedExtendedPersonName = new ExtendedPersonName()
            {
                GivenName = "DARTH",
                MiddleNameOrInitial = "A",
                FamilyName = "VADER"
            };

            Message newMessage = messageFactory.MakeMessage(TestMessages.TennesseeHealthSystems_ADT_A01);
            PID pidSegment = (PID)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PID);
            ExtendedPersonName actualExtendedPersonName = pidSegment.GetPatientName();

            Assert.AreEqual(expectedExtendedPersonName, actualExtendedPersonName);
        }

        [TestMethod]
        public void USAHealthCareAdtA01MessagePatientIsBobaBountyhunterFett()
        {
            MessageFactory messageFactory = new MessageFactory();
            ExtendedPersonName expectedExtendedPersonName = new ExtendedPersonName()
            {
                GivenName = "BOBA",
                MiddleNameOrInitial = "BOUNTYHUNTER",
                FamilyName = "FETT"
            };

            Message newMessage = messageFactory.MakeMessage(TestMessages.USAHealthCare_ADT_A01);
            PID pidSegment = (PID)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PID);
            ExtendedPersonName actualExtendedPersonName = pidSegment.GetPatientName();

            Assert.AreEqual(expectedExtendedPersonName, actualExtendedPersonName);
        }

        [TestMethod]
        public void GenericV23AdtA01MessagePatientIsDonaldDDuck()
        {
            MessageFactory messageFactory = new MessageFactory();
            ExtendedPersonName expectedExtendedPersonName = new ExtendedPersonName()
            {
                GivenName = "DONALD",
                MiddleNameOrInitial = "D",
                FamilyName = "DUCK"
            };

            Message newMessage = messageFactory.MakeMessage(TestMessages.GenericV23_ADT_A01);
            PID pidSegment = (PID)newMessage.Segments.Find(s => s.SegmentType == SegmentTypes.PID);
            ExtendedPersonName actualExtendedPersonName = pidSegment.GetPatientName();

            Assert.AreEqual(expectedExtendedPersonName, actualExtendedPersonName);
        }
    }
}
