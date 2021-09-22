using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class CommandUnitTest
    {
        private Invoker _invoker;
        
        [SetUp]
        public void Setup()
        {
            var receiver = new Receiver();
            var command = new Command(receiver);
            _invoker = new Invoker(command);
        }

        [Test]
        public void SaveCommandReturnString()
        {
            Assert.AreEqual("Command save received!", _invoker.Save());
        }
        
        [Test]
        public void CancelCommandReturnString()
        {
            Assert.AreEqual("Command undo received!",_invoker.Cancel());
        }
    }
}