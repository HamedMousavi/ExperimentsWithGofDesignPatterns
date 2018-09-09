
namespace Patterns.Observer
{
    public interface IObserver
    {
        void OnSubjectChanged(IObservable observable, object args);
    }
}
