
namespace GoF_Patterns.Structural_Patterns
{
    public abstract class Chocolate
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Chocolate(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    
    public class BitterChocolate : Chocolate
    {
        public BitterChocolate() : base("Bitter Chocolate", 35)
        {
        }
        
    }

    public class MilkChocolate : Chocolate
    {
        public MilkChocolate() : base("Milk Chocolate", 40)
        {
        }
    }

    public abstract class Decorator : Chocolate
    {
        protected Chocolate Chocolate;

        public Decorator(Chocolate chocolate, string name, double price) : base(name,price)
        {
            Chocolate = chocolate;
        }

        public void SetChocolate(Chocolate chocolate)
        {
            Chocolate = chocolate;
        }
    }
    
    public class ChocoWithBlueberry : Decorator
    {
        public ChocoWithBlueberry(Chocolate chocolate) : 
            base(chocolate, chocolate.Name + " with Blueberry", chocolate.Price + 10)
        {
        }
    }
    
    public class ChocoInBox : Decorator
    {
        public ChocoInBox(Chocolate chocolate) : 
            base(chocolate, chocolate.Name + " in box", chocolate.Price + 30)
        {
        }
    }
}