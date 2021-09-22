
namespace GoF_Patterns.Creational_Patterns
{
    public abstract class Factory
    {
        public abstract Product Create();
    }

    public class WoodFactory : Factory
    {
        public override Product Create()
        {
            return new Wood();
        }
    }
    
    public class BrickFactory : Factory
    {
        public override Product Create()
        {
            return new Brick();
        }
    }

    public abstract class Product
    {
    }

    public class Wood : Product
    {
    }

    public class Brick : Product
    {
    }
}