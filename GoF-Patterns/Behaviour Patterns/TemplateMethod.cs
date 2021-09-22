namespace GoF_Patterns.Behaviour_Patterns
{
    public class Power
    {
        public virtual void TurnOn()
        {
        }

        public virtual void TurnOff()
        {
        }
    }

    public class Pc : Power
    {
        public override void TurnOn()
        {
        }

        public override void TurnOff()
        {
        }
    }

    public class Fridge : Power
    {
        public override void TurnOn()
        {
        }

        public override void TurnOff()
        {
        }
    }
}