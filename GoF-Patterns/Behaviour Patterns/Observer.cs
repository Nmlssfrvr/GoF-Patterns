using System.Collections.Generic;

namespace GoF_Patterns.Behaviour_Patterns
{
    public interface IObserver
    {
        public void Update();
    }

    public interface IObservable
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }
    
    public class Subscriber : IObserver
    {
        public int CountNotifies { get; private set; }

        public Subscriber()
        {
            CountNotifies = 0;
        }
        
        public void Update()
        {
            ++CountNotifies;
        }
    }
    
    public class Publisher : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update());
        }
    }
}