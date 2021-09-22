using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class ChainOfResponsibilityUnitTest
    {
        private Deputy _deputy;
        private Chief _chief;

        [SetUp]
        public void Setup()
        {
            _deputy = new Deputy();
            _chief = new Chief();

            _deputy.SetNext(_chief);
        }

        [Test]
        public void DeputyResponsibility()
        {
            var message = _deputy.Handle("Ordinary");
            
            Assert.AreEqual("Document was processed by Deputy",message);
        }
        
        [Test]
        public void ChiefResponsibility()
        {
            var message = _deputy.Handle("Important");
            
            Assert.AreEqual("Document was processed by Chief",message);
        }

        [Test]
        public void NoBodysResponsibility()
        {
            var message = _deputy.Handle("Code");
            
            Assert.AreEqual("Not a doc", message);
        }
    }
}