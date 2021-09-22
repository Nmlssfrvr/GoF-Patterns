using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class FacadeUnitTest
    {
        private Facade _facade;
            
        [SetUp]
        public void Setup()
        {
            _facade = new Facade(
                new Creator(),
                new Builder(),
                new Executor());
        }

        [Test]
        public void ReturnStringForCreateExecute()
        {
            Assert.AreEqual("Create Execute",_facade.CreateExecute());
        }
        
        [Test]
        public void ReturnStringForCreateBuildExecute()
        {
            Assert.AreEqual("Create Build Execute",_facade.CreateBuildExecute());
        }
    }
}