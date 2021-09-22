using System.Collections.Generic;
using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class VisitorUnitTest
    {
        private Postman _postman;
        private ElementsList _houses;

        [SetUp]
        public void Setup()
        {
            _postman = new Postman();
            _houses = new ElementsList(new List<AbstractHouse>()
            {
                new House("first house"),
                new House("second house"),
                new House("third house"),
                new Flat("first flat"),
                new Flat("second flat")
            });
        }

        [Test]
        public void CheckVisited()
        {
            _houses.Accept(_postman);
            
            CollectionAssert.AreEqual(_houses.GetList(),
                                        _postman.Visited);
        }
    }
}