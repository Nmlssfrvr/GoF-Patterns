using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class AdapterUnitTest
    {
        private Adapter _adapter;
        private Student _student;
        private TaxiDriver _driver;

        [SetUp]
        public void Setup()
        {
            _student = new Student();
            _driver = new TaxiDriver();
            _adapter = new Adapter(_student);
        }

        [Test] public void CheckCompability()
        {
            Assert.IsInstanceOf<IDriver>(_adapter);
            Assert.IsNotInstanceOf<IHuman>(_adapter);
            Assert.AreEqual(_adapter.Drive(),_student.Walk());
            Assert.AreNotEqual(_adapter.Drive(),_driver.Drive());
        }
    }
}