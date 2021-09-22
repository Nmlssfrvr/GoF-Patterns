using GoF_Patterns.Behaviour_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Behaviour_Patterns
{
    public class TemplateMethodUnitTest
    {
        [Test]
        public void CheckInheritance()
        {
            Pc pc = new Pc();
            Fridge fridge = new Fridge(); 
            
            Assert.IsInstanceOf<Power>(pc);
            Assert.IsInstanceOf<Power>(fridge);
        }
    }
}