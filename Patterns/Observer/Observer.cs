using System;

namespace Patterns.Observer
{
    public class Observer : IObserver, IDisposable
    {

        private readonly IObservable _observable;


        public Observer(IObservable observable)
        {
            _observable = observable;
            _observable.Register(this);
        }


        public void OnSubjectChanged(IObservable observable, object args)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Subject [{observable.Name}] changed to [{args}].");
        }


        public void Dispose()
        {
            _observable.Unregister(this);
        }
    }
}
