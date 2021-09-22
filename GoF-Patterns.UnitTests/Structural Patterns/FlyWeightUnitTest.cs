using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class FlyWeightUnitTest
    {
        private FlyWeightFactory _flyWeightFactory;

        [SetUp]
        public void Setup()
        {
            _flyWeightFactory = new FlyWeightFactory(new Phone[]
            {
                new Phone("Samsung","S20","Black"),
                new Phone("Samsung","S21","Black"),
                new Phone("Samsung","S21","Pink"),
                new Phone("Xiaomi","Redmi 10","Grey"),
                new Phone("Xiaomi", "Note 10", null)
            });
        }

        [Test]
        public void NewObjectSameAsFromFlyweightList()
        {
            Phone phone = new Phone("Apple", "Iphone 13", "gray");
            Phone deepCopyPhone = new Phone("Apple", "Iphone 13", "gray"); 
            
            Assert.AreNotSame(phone,deepCopyPhone);
            Assert.IsFalse(_flyWeightFactory.Contains(phone));
            Assert.IsFalse(_flyWeightFactory.Contains(deepCopyPhone));

            FlyWeight flyWeightForPhone = _flyWeightFactory.GetFlyweight(phone);
            FlyWeight flyWeightForDeepCopy = _flyWeightFactory.GetFlyweight(deepCopyPhone);
            
            Assert.AreSame(flyWeightForPhone,flyWeightForDeepCopy);
            Assert.AreEqual(flyWeightForPhone,flyWeightForDeepCopy);
        }
    }
}