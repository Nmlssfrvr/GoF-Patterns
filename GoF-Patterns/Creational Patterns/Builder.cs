
namespace GoF_Patterns.Creational_Patterns
{
    public abstract class SodaBuilder
    {
        public Soda Soda { get; private set; }

        public void CreateSoda()
        {
            this.Soda = new Soda();
        }
        public abstract void SetSugar();
        public abstract void SetColour();
        public abstract void SetVolume();
        public abstract Soda GetSoda();
    }

    public class Soda
    {
        public string Sugar { get; set; }
        public string Colour { get; set; }
        public float Volume { get; set; }
    }
    
    public class Pepsi : SodaBuilder
    {
        public override void SetSugar()
        {
            Soda.Sugar = "With sugar";
        }

        public override void SetColour()
        {
            Soda.Colour = "Black";
        }

        public override void SetVolume()
        {
            Soda.Volume = 1.0f;
        }

        public override Soda GetSoda()
        {
            return Soda;
        }
    }
    
    public class DietCola : SodaBuilder
    {
        public override void SetSugar()
        {
            Soda.Sugar = "Sugar free";
        }

        public override void SetColour()
        {
            Soda.Colour = "Black";
        }

        public override void SetVolume()
        {
            Soda.Volume = 2.0f;
        }

        public override Soda GetSoda()
        {
            return Soda;
        }
    }

    public sealed class VendingMachine
    {
        public Soda Pull(SodaBuilder builder)
        {
            builder.CreateSoda();
            builder.SetSugar();
            builder.SetColour();
            builder.SetVolume();
            return builder.GetSoda();
        }
    }
}