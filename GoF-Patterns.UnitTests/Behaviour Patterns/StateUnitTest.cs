using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class StateUnitTest
    {
        private Phone _phone;
        
        [SetUp]
        public void Setup()
        {
            _phone = new Phone(new PhonePowerOn());
        }

        [Test]
        public void CheckOnState()
        {
            Assert.IsInstanceOf<PhonePowerOn>(_phone.State);
        }
        
        [Test]
        public void CheckOffState()
        {
            _phone.TurnOff();
            
            Assert.IsInstanceOf<PhonePowerOff>(_phone.State);
        }
    }
}