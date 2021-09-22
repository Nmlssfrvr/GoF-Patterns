using GoF_Patterns.Creational_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Creational_Patterns
{
    public class FactoryMethodUnitTest
    {
        private WoodFactory _woodFactory;
        private BrickFactory _brickFactory;
        
        [SetUp]
        public void Setup()
        {
            _woodFactory = new WoodFactory();
            _brickFactory = new BrickFactory();
        }

        [Test]
        public void WoodFactoryRightCreateType()
        {
            var wood = _woodFactory.Create();
            
            Assert.IsInstanceOf<Product>(wood);
            Assert.IsInstanceOf<Wood>(wood);
        }
        
        [Test]
        public void BrickFactoryRightCreateType()
        {
            var brick = _brickFactory.Create();
            
            Assert.IsInstanceOf<Product>(brick);
            Assert.IsInstanceOf<Brick>(brick);
        }
    }
}