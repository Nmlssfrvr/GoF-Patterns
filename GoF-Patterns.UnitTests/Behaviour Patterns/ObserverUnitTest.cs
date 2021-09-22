using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class ObserverUnitTest
    {
        private Publisher _publisher;

        [SetUp]
        public void Setup()
        {
            _publisher = new Publisher();
        }

        [Test]
        public void CheckNotifyForAddedObservers()
        {
            Subscriber firstSub = new Subscriber();
            Subscriber secondSub = new Subscriber();
            Subscriber notSub = new Subscriber();
            _publisher.AddObserver(firstSub);
            _publisher.AddObserver(secondSub);
            int firstCountNotifiesBeforeNotify = firstSub.CountNotifies,
                secondCountNotifiesBeforeNotify = secondSub.CountNotifies,
                thirdCountNotifiesBeforeNotify = notSub.CountNotifies;

            _publisher.NotifyObservers();
            
            int firstCountNotifiesAfterNotify = firstSub.CountNotifies,
                secondCountNotifiesAfterNotify = secondSub.CountNotifies,
                thirdCountNotifiesAfterNotify = notSub.CountNotifies;
            
            Assert.AreNotEqual(firstCountNotifiesBeforeNotify,
                                firstCountNotifiesAfterNotify);
            Assert.AreNotEqual(secondCountNotifiesBeforeNotify,
                                secondCountNotifiesAfterNotify);
            Assert.AreEqual(thirdCountNotifiesBeforeNotify,
                            thirdCountNotifiesAfterNotify);
        }

        [Test]
        public void CheckNotifyForDeletedObservers()
        {
            Subscriber firstSub = new Subscriber();
            _publisher.AddObserver(firstSub);
            int firstCountNotifiesBeforeNotify = firstSub.CountNotifies;
            _publisher.RemoveObserver(firstSub);
            _publisher.NotifyObservers();

            int firstCountNotifiesAfterNotify = firstSub.CountNotifies;

            Assert.AreEqual(firstCountNotifiesBeforeNotify,
                            firstCountNotifiesAfterNotify);
        }
    }
}