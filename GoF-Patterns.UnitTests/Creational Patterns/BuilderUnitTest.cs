using GoF_Patterns.Creational_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Creational_Patterns
{
    public class BuilderUnitTest
    {
        private VendingMachine _vendingMachine;

        [SetUp]
        public void Setup()
        {
            _vendingMachine = new VendingMachine();
        }

        [Test]
        public void PepsiRightValues()
        {
            var pepsi = _vendingMachine.Pull(new Pepsi());
            
            Assert.AreEqual("With sugar", pepsi.Sugar);
            Assert.AreEqual("Black", pepsi.Colour);
            Assert.AreEqual(1.0f,pepsi.Volume,0.0001f);
        }

        [Test]
        public void DietColaRightValues()
        {
            var cola = _vendingMachine.Pull(new DietCola());
            
            Assert.AreEqual("Sugar free", cola.Sugar);
            Assert.AreEqual("Black", cola.Colour);
            Assert.AreEqual(2.0f,cola.Volume,0.0001f);
        }
        
    }
}