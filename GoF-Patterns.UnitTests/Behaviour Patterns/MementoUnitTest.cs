using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class MementoUnitTest
    {
        private Dispatcher _dispatcher;
        private Passenger _passenger;

        [SetUp]
        public void Setup()
        {
            _dispatcher = new Dispatcher();
            _passenger = new Passenger();
        }

        [Test]
        public void CheckForValidRestoreState()
        {
            _passenger.GoUp();
            _passenger.GoUp();
            _passenger.GoUp();
            _passenger.GoDown();
            var firstState = _passenger.GetState();
            _dispatcher.SaveState(firstState);
            
            _passenger.GoUp();
            _passenger.GoUp();
            _passenger.GoUp();

            Assert.AreNotEqual(_passenger.GetState(),firstState);

            _passenger.RestoreState(_dispatcher.GetPreviousState());
            
            Assert.AreEqual(_passenger.GetState(), firstState);
        }
    }
}