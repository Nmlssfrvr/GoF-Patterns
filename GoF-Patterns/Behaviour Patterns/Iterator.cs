using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IEnumerator
    {
        bool HasNext();
        Sheet Next { get; }
    }

    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
        int Count { get; }
        Sheet this[int index] { get; }
    }
    
    public class Sheet
    {
        private int _number;
        public Sheet(int number)
        {
            _number = number;
        }

        #nullable enable
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Sheet second))
            {
                return false;
            }

            return this._number == second._number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
    public class SheetEnumerator : IEnumerator
    {
        private IEnumerable _collection;
        private int _index = 0;
        
        public SheetEnumerator(IEnumerable collection)
        {
            _collection = collection;
        }

        public bool HasNext() => _index < _collection.Count;

        public Sheet Next => _collection[_index++];
        
    }

    public class Book : IEnumerable
    {
        private Sheet[] _collection;

        public int Count => _collection.Length;

        public Sheet this[int index] => _collection[index];

        public Book(Sheet[] collection)
        {
            _collection = collection;
        }
        
        public IEnumerator GetEnumerator()
        {
            return new SheetEnumerator(this);
        }
    }
}