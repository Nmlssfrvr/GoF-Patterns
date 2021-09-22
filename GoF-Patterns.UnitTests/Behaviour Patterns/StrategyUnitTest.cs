using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class StrategyUnitTest
    {
        private Gardener _gardener;
        
        [SetUp]
        public void Setup()
        {
            _gardener = new Gardener(new Watermelon());
        }

        [Test]
        public void CheckWatermelonGrow()
        {
            Assert.IsInstanceOf<IGrowable>(_gardener.Plant);
            Assert.AreEqual("Watermelon in growing",_gardener.Pour());
        }

        [Test]
        public void SwitchToAppleTreeAndCheckGrow()
        {
            _gardener.Plant = new AppleTree();
            Assert.IsInstanceOf<IGrowable>(_gardener.Plant);
            Assert.AreEqual("Apple tree is growing",_gardener.Pour());
        }
    }
}