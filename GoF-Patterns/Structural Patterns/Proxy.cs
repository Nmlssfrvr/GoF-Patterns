using System.Collections.Generic;

namespace GoF_Patterns.Structural_Patterns
{
    public abstract class Subject
    {
        public abstract string Request();
    }

    public class RealSubject : Subject
    {
        public override string Request()
        {
            return "Real";
        }
    }

    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject=null)
        {
            _realSubject = realSubject;
        }

        public override string Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
                return _realSubject.Request();
            }
            return "Proxy";
        }
    }
}