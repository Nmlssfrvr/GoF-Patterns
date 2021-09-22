
using System.Collections.ObjectModel;

namespace GoF_Patterns.Creational_Patterns
{
    public interface ICloneable
    {
        public ICloneable Clone();
    }
    
    public class Robot : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Robot(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ICloneable Clone()
        {
            return new Robot(Id, Name);
        }

        #nullable enable
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Robot second))
            {
                return false;
            }

            return this.Id == second.Id && 
                   this.Name == second.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}