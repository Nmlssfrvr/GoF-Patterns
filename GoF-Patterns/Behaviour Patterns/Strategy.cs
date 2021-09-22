using System;

namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IGrowable
    {
        public string Grow();
    }
    
    public class AppleTree : IGrowable
    {
        public string Grow()
        {
           return "Apple tree is growing";
        }
    }
    
    public class Watermelon : IGrowable
    {
        public string Grow()
        {
            return "Watermelon in growing";
        }
    }

    public class Gardener
    {
        private IGrowable _plant;

        public IGrowable Plant
        {
            get => _plant;
            set => _plant = value;
        }

        public Gardener(IGrowable plant)
        {
            _plant = plant;
        }

        public string Pour()
        {
            return _plant.Grow();
        }
        
    }
}