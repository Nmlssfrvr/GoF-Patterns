using System.Reflection.Emit;

namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IHandler
    {
        public IHandler SetNext(IHandler handler);
        public string Handle(string request);
    }
    
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _successor;
        
        public IHandler SetNext(IHandler handler)
        {
            _successor = handler;

            return handler;
        }
        
        public virtual string Handle(string request)
        {
            if (_successor != null)
            {
                return _successor.Handle(request);
            }
            return "Not a doc";
        }
    }
    

    public class Deputy : AbstractHandler
    {
        public override string Handle(string request)
        {
            if (request == "Ordinary")
            {
                return "Document was processed by Deputy";
            }
            return base.Handle(request);
        }
    }

    public class Chief : AbstractHandler
    {
        public override string Handle(string request)
        {
            if (request == "Important")
            {
                return "Document was processed by Chief";
            }
            return base.Handle(request);
        }
    }
}