using GoF_Patterns.Structural_Patterns;
using NUnit.Framework;

namespace GoF_Patterns.UnitTests.Structural_Patterns
{
    public class ProxyUnitTest
    {
        [Test]
        public void CallingProxyObjectMethod()
        {
            Proxy proxy = new Proxy();
            RealSubject realSubject = new RealSubject();
            
            Assert.AreEqual(realSubject.Request(),proxy.Request());
            Assert.AreNotEqual(realSubject.Request(),proxy.Request());
            
        }
    }
}