using GoF_Patterns.Creational_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Creational_Patterns
{
    public class AbstractFactoryUnitTest
    {
        private Animal _snake;
        private Animal _peacock;
        
        [SetUp]
        public void Setup()
        {
            _snake = new Animal(new SnakeFactory());
            _peacock = new Animal(new PeacockFactory());
        }

        [Test]
        public void SnakeRightTypes()
        {
            Assert.IsInstanceOf<Movement>(_snake.Movement);
            Assert.IsInstanceOf<Volume>(_snake.Volume);
            
            Assert.IsInstanceOf<CrawlMovement>(_snake.Movement);
            Assert.IsInstanceOf<SnakeVolume>(_snake.Volume);
        }
        
        [Test]
        public void PeacockRightTypes()
        {
            Assert.IsInstanceOf<Movement>(_peacock.Movement);
            Assert.IsInstanceOf<Volume>(_peacock.Volume);
            
            Assert.IsInstanceOf<FlyMovement>(_peacock.Movement);
            Assert.IsInstanceOf<PeacockVolume>(_peacock.Volume);
            
        }
    }
}