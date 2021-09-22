using GoF_Patterns.Creational_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Creational_Patterns
{
    public class PrototypeUnitTest
    {
        private Robot _firstRobot;
        
        [SetUp]
        public void Setup()
        {
            _firstRobot = new Robot(1, "Robo");
        }
        
        [Test]
        public void ClonedInstanceNotSame()
        {
            ICloneable secondRobot = _firstRobot.Clone();

            Assert.IsInstanceOf<Robot>(secondRobot);
            Assert.AreEqual(_firstRobot,secondRobot);
            Assert.AreNotSame(_firstRobot,secondRobot);
        }
    }
}