
namespace GoF_Patterns.Structural_Patterns
{
    public interface IFlyable
    {
        public void Fly();
    }
    
    public class Plane : IFlyable
    {
        public void Fly()
        {
        }
    }
    
    public class Carpet : IFlyable
    {
        public void Fly()
        {
        }
    }

    public abstract class Flyer
    {
        protected IFlyable Flyee;
        
        public void SetFlyee(IFlyable flyee)
        {
            Flyee = flyee;
        }

        public Flyer(IFlyable flyee)
        {
            Flyee = flyee;
        }

        public virtual void Move()
        {
            Flyee.Fly();
        }

        public abstract string GoToFlyee();
    }
    
    public class Pilot : Flyer
    {
        public Pilot(IFlyable flyee) : base(flyee)
        {
        }

        public override string GoToFlyee()
        {
            return "Driving Car";
        }
    }
    
    public class Storyteller : Flyer
    {
        public Storyteller(IFlyable flyee) : base(flyee)
        {
        }

        public override string GoToFlyee()
        {
            return "Ride a lion";
        }
    }
}