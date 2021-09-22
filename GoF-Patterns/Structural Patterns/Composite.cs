using System.Collections.Generic;
using System.Text;

namespace GoF_Patterns.Structural_Patterns
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }
        public abstract void Add(Component component);
        public abstract string Print();
        public abstract void Remove(Component component);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            
        }

        public override string Print()
        {
           return _name;
        }

        public override void Remove(Component component)
        {
            
        }
    }
    
    public class Tree : Component
    {
        private readonly IList<Component> _children = new List<Component>();
        
        public Tree(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override string Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_name);
            foreach (var child in _children)
            {
                stringBuilder.AppendLine("\t" + child.Print());
            }

            return stringBuilder.ToString();
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}