
namespace Patterns.Command
{
    public class BaseCommand : ICommand
    {
        public IReceiver Receiver { get; set; }


        public BaseCommand()
        {
            Receiver = new Receivers.NullReceiver();
        }


        public BaseCommand(IReceiver receiver)
        {
            Receiver = receiver;
        }


        public void Execute()
        {
            Receiver.Execute();
        }
    }
}
