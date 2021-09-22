using System.Diagnostics;
using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class CompositeUnitTest
    {
        private Leaf _firstTest;
        private Tree _secondTest;
        
        [SetUp]
        public void Setup()
        {
            _firstTest = new Leaf("leaf");
            
            _secondTest = new Tree("tree");
            _secondTest.Add(_firstTest);
            _secondTest.Add(_firstTest);
            var anotherTree = new Tree("tree2");
            anotherTree.Add(_firstTest);
            anotherTree.Add(new Leaf("leaf2"));
            anotherTree.Add(_firstTest);
            _secondTest.Add(anotherTree);
        }

        [Test]
        public void ReturnLeafString()
        {
            Assert.AreEqual("leaf",_firstTest.Print());
        }

        [Test]
        public void ReturnTreeString()
        {
            TestContext.Out.WriteLine(_secondTest.Print());
            Assert.AreEqual("tree\r\n\tleaf\r\n\tleaf\r\n\ttree2\r\n\tleaf\r\n\tleaf2\r\n\tleaf\r\n\r\n",
                            _secondTest.Print());
        }
    }
}