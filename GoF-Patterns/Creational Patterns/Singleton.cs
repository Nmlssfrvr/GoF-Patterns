namespace GoF_Patterns.Creational_Patterns
{
    public class Singleton
    {
        public string Name { get; }
        private static Singleton _instance;

        public static Singleton GetInstance(string name="default")
        {
            if (_instance == null)
                _instance = new Singleton(name);
            return _instance;
        }
        
        private Singleton(string name)
        {
            Name = name;
        }

        #nullable enable
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Robot second))
            {
                return false;
            }

            return this.Name == second.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}