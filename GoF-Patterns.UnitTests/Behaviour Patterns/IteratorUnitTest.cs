using System.Collections.Generic;
using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class IteratorUnitTest
    {
        private Book _book;
        private Sheet[] _correctArray;
        
        [SetUp]
        public void Setup()
        {
            Sheet first = new Sheet(1),
                second = new Sheet(2),
                third = new Sheet(3);
            _correctArray = new Sheet[]
            {
               first,first,
               third,third,
               second,second,
               first,first
            };
            _book = new Book(_correctArray);
        }

        [Test]
        public void EqualArrays()
        {
            var enumerator = _book.GetEnumerator();
            var list = new List<Sheet>();
            while (enumerator.HasNext())
            {
                list.Add(enumerator.Next);
            }
            
            CollectionAssert.AreEqual(_correctArray,list);
        }
    }
}