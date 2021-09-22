using GoF_Patterns.Creational_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Creational_Patterns
{
    public class SingletonUnitTest
    {
        private Singleton _singleton;

        [SetUp]
        public void Setup()
        {
            _singleton = Singleton.GetInstance("Artem");
        }
        
        [Test]
        public void SingletonSameObject()
        {
            Singleton second = Singleton.GetInstance("Not Artem");
            
            Assert.AreEqual(_singleton,second);
            Assert.AreSame(_singleton,second);
        }
    }
}