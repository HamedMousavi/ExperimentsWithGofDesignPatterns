
namespace Patterns.Observer
{

    public class Observable : IObservable
    {

        private ObserverList _observers;


        public Observable(string name)
        {
            Name = name;
            _observers = new ObserverList();
        }

        
        public void Register(IObserver observer)
        {
            lock (_observers)
            {
                _observers.Add(observer);
            }
        }


        public void Unregister(IObserver observer)
        {
            lock (_observers)
            {
                _observers.Remove(observer);
            }
        }


        protected void NotifyObservers(object args)
        {
            lock (_observers)
            {
                foreach (IObserver observer in _observers)
                {
                    observer.OnSubjectChanged(this, args);
                }
            }
        }


        public string Name { get; set; }

        private int _value;

        public int Value
        {
            get { return _value; }
            set 
            { 
                _value = value;
                NotifyObservers(this.Value);
            }
        }

    }
}
