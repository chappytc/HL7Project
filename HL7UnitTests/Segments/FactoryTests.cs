using HL7MessagePaser.Enums;
using HL7MessagePaser.Segments;
using HL7MessagePaser.Segments.Abstracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HL7UnitTests.Segments
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void GenericV23PidFirstNameIsDonaldUsingDefaultDelimiters()
        {
            // Arrange
            string testPidSegment = "PID|1||10006579^^^1^MRN^1||DUCK^DONALD^D||19241010|M||1|111 DUCK ST^^FOWL^CA^999990000^^M|1|(888)555-1212|(888)555-1212|1|2||40007716^^^AccMgr^VN^1|123121234|||||||||||NO";

            // Act
            SegmentFactoryManager newManager = new SegmentFactoryManager();
            SegmentFactory newFactory = newManager.GetFactory(DriverTypes.GenericV23);

            PID newPid = newFactory.CreatePIDInstance(testPidSegment);
            
            // Assert
            Assert.AreEqual("DONALD", newPid.GetPatientName().GivenName.ToUpper());
        }

        [TestMethod]
        public void GenericV23PidFirstNameIsDonaldUsingCustomDelimiters()
        {
            // Arrange
            SegmentDelimiters delimiters = new SegmentDelimiters { FieldSeparator = '%' };
            string testPidSegment = "PID%1%%10006579^^^1^MRN^1%%DUCK^DONALD^D%%19241010%M%%1%111 DUCK ST^^FOWL^CA^999990000^^M%1%(888)555-1212%(888)555-1212%1%2%%40007716^^^AccMgr^VN^1%123121234%%%%%%%%%%%NO";

            // Act            
            SegmentFactoryManager newManager = new SegmentFactoryManager(delimiters);
            SegmentFactory newFactory = newManager.GetFactory(DriverTypes.GenericV23);

            PID newPid = newFactory.CreatePIDInstance(testPidSegment);

            // Assert
            Assert.AreEqual("DONALD", newPid.GetPatientName().GivenName.ToUpper());
        }

        [TestMethod]
        public void TennesseePidFirstNameIsThomasUsingDefaultDelimiters()
        {
            // Arrange
            string testPidSegment = "PID|1||10006579^^^1^MRN^1||THOMAS^C^CHAPMAN||19241010|M||1|111 DUCK ST^^FOWL^CA^999990000^^M|1|8885551212|8885551212|1|2||40007716^^^AccMgr^VN^1|123121234|||||||||||NO";

            // Act
            SegmentFactoryManager newManager = new SegmentFactoryManager();
            SegmentFactory newFactory = newManager.GetFactory(DriverTypes.TennesseeHealthCare);

            PID newPid = newFactory.CreatePIDInstance(testPidSegment);

            // Assert
            Assert.AreEqual("THOMAS", newPid.GetPatientName().GivenName.ToUpper());
        }

        [TestMethod]
        public void TennesseePidFirstNameIsThomasUsingCustomDelimiters()
        {
            // Arrange
            SegmentDelimiters delimiters = new SegmentDelimiters { FieldSeparator = '*' };
            string testPidSegment = "PID*1**10006579^^^1^MRN^1**THOMAS^C^CHAPMAN**19241010*M**1*111 DUCK ST^^FOWL^CA^999990000^^M*1*8885551212*8885551212*1*2**40007716^^^AccMgr^VN^1*123121234***********NO";

            // Act            
            SegmentFactoryManager newManager = new SegmentFactoryManager(delimiters);
            SegmentFactory newFactory = newManager.GetFactory(DriverTypes.TennesseeHealthCare);

            PID newPid = newFactory.CreatePIDInstance(testPidSegment);

            // Assert
            Assert.AreEqual("THOMAS", newPid.GetPatientName().GivenName.ToUpper());
        }
    }
}
