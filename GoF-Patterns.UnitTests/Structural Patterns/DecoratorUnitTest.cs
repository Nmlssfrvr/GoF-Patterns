using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class DecoratorUnitTest
    {
        private BitterChocolate _bitterChocolate;
        private MilkChocolate _milkChocolate;
        
        [SetUp]
        public void Setup()
        {
            _bitterChocolate = new BitterChocolate();
            _milkChocolate = new MilkChocolate();
        }

        [Test]
        public void CheckInstanceForFirstChocolate()
        {
            Assert.AreEqual("Bitter Chocolate", _bitterChocolate.Name);
            Assert.IsNotInstanceOf<Decorator>(_bitterChocolate);
            
            ChocoWithBlueberry chocoWithBlueberry = new ChocoWithBlueberry(_bitterChocolate);

            Assert.IsInstanceOf<Decorator>(chocoWithBlueberry);
            Assert.AreEqual("Bitter Chocolate with Blueberry", chocoWithBlueberry.Name);
        }
        
        [Test]
        public void CheckInstanceForSecondChocolate()
        {
            Assert.AreEqual("Milk Chocolate", _milkChocolate.Name);
            Assert.IsNotInstanceOf<Decorator>(_milkChocolate);
            
            ChocoWithBlueberry chocoWithBlueberry = new ChocoWithBlueberry(_milkChocolate);
            ChocoInBox chocoInBox = new ChocoInBox(chocoWithBlueberry);

            Assert.IsInstanceOf<Decorator>(chocoInBox);
            Assert.AreEqual("Milk Chocolate with Blueberry in box", chocoInBox.Name);
        }
    }
}