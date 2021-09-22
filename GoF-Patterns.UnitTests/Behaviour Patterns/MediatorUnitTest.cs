using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class MediatorUnitTest
    {
        private Shop _shop;
        private Buyer _buyer;

        [SetUp]
        public void Setup()
        {
            var mediator = new Mediator();
            
            _shop = new Shop(mediator);
            _buyer = new Buyer(mediator);

            mediator.Shop = _shop;
            mediator.Buyer = _buyer;
        }

        [Test]
        public void ShopReturnString()
        {
            var message = "Want this";
            var response = _buyer.Notify(message);
            Assert.AreEqual($"Message to shop: {message}",response);
        }
        
        [Test]
        public void BuyerReturnString()
        {
            var message = "Buy this";
            var response = _shop.Notify(message);
            Assert.AreEqual($"Message to buyer: {message}",response);
        }
    }
}