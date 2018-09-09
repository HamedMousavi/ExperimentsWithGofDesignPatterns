

namespace Patterns.Command
{

    public interface ICommand
    {

        IReceiver Receiver { get; set; }
        void Execute();
    }
}
