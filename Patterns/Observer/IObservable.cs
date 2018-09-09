
namespace Patterns.Observer
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);

        string Name { get; set; }
    }
}
