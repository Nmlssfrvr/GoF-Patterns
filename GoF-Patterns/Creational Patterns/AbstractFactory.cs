using System.Collections.Generic;

namespace GoF_Patterns.Creational_Patterns
{
    public abstract class AnimalFactory
    {
        public abstract Movement CreateMovement();
        public abstract Volume CreateVolume();
    }

    public abstract class Movement
    {
    }
    
    public abstract class Volume
    {
    }

    public class PeacockFactory : AnimalFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Volume CreateVolume()
        {
            return new PeacockVolume();
        }
    }
    
    public class FlyMovement : Movement
    {
    }

    public class PeacockVolume : Volume
    {
    }
    
    public class SnakeFactory : AnimalFactory
    {
        public override Movement CreateMovement()
        {
            return new CrawlMovement();
        }

        public override Volume CreateVolume()
        {
            return new SnakeVolume();
        }
    }
    
    public class CrawlMovement : Movement
    {
    }

    public class SnakeVolume : Volume
    {
    }

    public class Animal
    {
        public Movement Movement { get; }
        public Volume Volume { get; }

        public Animal(AnimalFactory factory)
        {
            Movement = factory.CreateMovement();
            Volume = factory.CreateVolume();
        }
    }
}