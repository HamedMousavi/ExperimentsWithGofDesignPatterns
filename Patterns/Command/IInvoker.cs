
namespace Patterns.Command
{
    public interface IInvoker
    {
        ICommand Command { get; set; }

        void ExecuteCommands();

        void Undo();

        void Redo();
    }
}
