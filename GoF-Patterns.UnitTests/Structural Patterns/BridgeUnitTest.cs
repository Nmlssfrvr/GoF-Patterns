using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class BridgeUnitTest
    {
        private Pilot _pilot;
        private Storyteller _storyteller;

        [SetUp]
        public void Setup()
        {
            _pilot = new Pilot(new Plane());
            _storyteller = new Storyteller(new Carpet());
        }

        [Test]
        public void SameImplementationDifferentClasses()
        {
            Assert.IsInstanceOf<Flyer>(_pilot);
            Assert.IsInstanceOf<Flyer>(_storyteller);
            
            Assert.AreNotEqual(_pilot.GoToFlyee(),
                                _storyteller.GoToFlyee());
        }
    }
}