
namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IMediator
    {
        public string Send(string request, Component sender);
    }

    public abstract class Component
    {
        protected IMediator Mediator;

        public Component(IMediator mediator)
        {
            Mediator = mediator;
        }

        public virtual string Send(string request)
        {
            return Mediator.Send(request, this);
        }

        public abstract string Notify(string request);
    }
    
    public class Shop : Component
    {
        public Shop(IMediator mediator) : base(mediator)
        {
        }

        public override string Notify(string request)
        {
            return $"Message to buyer: {request}";
        }
    }

    public class Buyer : Component
    {
        public Buyer(IMediator mediator) : base(mediator)
        {
        }

        public override string Notify(string request)
        {
            return $"Message to shop: {request}";
        }
    }
    
    public class Mediator : IMediator
    {
        public Buyer Buyer { get; set; }
        public Shop Shop { get; set; }

        public Mediator(Buyer buyer=null, Shop shop=null)
        {
            Buyer = buyer;
            Shop = shop;
        }
        
        public string Send(string request, Component sender)
        {
            if (sender is Buyer)
            {
                return Shop.Notify(request);
            }

            if (sender is Shop)
            {
                return Buyer.Notify(request);
            }

            return null;
        }
    }
}