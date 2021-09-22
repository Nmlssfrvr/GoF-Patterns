using System;
using System.Collections.Generic;

namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IVisitor
    {
        public void VisitHouse(House house);
        public void VisitFlat(Flat flat);
    }

    public abstract class AbstractHouse
    {
        public string Address { get; private set; }

        public AbstractHouse(string address)
        {
            Address = address;
        }
        public abstract void Accept(IVisitor visitor);

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is AbstractHouse second))
            {
                return false;
            }

            return this.Address == second.Address;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
    public class House : AbstractHouse
    {
        public House(string address): base(address)
        {
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitHouse(this);
        }
    }
    
    public class Flat : AbstractHouse
    {
        public Flat(string address) : base(address)
        {
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitFlat(this);
        }
    }

    public class Postman : IVisitor
    {
        public IList<AbstractHouse> Visited { get; private set; }

        public Postman()
        {
            Visited = new List<AbstractHouse>();
        }
        public void VisitHouse(House house)
        {
            Visited.Add(house);
        }

        public void VisitFlat(Flat flat)
        {
           Visited.Add(flat);
        }

        public void ResetVisited()
        {
            Visited.Clear();
        }
    }

    public class ElementsList
    {
        private IList<AbstractHouse> _elements;

        public ElementsList(IList<AbstractHouse> elements=null)
        {
            if (elements != null)
                _elements = elements;
            else _elements = new List<AbstractHouse>();
        }

        public void Add(AbstractHouse abstractHouse)
        {
            _elements.Add(abstractHouse);
        }

        public void Remove(AbstractHouse abstractHouse)
        {
            _elements.Remove(abstractHouse);
        }

        public IList<AbstractHouse> GetList()
        {
            return _elements;
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}